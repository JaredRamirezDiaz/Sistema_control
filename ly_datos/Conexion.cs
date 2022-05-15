using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ly_datos
{
    public class Conexion
    {
        private SqlConnection SqlConnection;
        public SqlCommand SqlCommand { get; set; }
        private SqlTransaction SqlTransaction;
        public Conexion(string conexion)
        {
            SqlConnection = new SqlConnection();
            try
            {
                if (conexion == "Zapateria")
                {
                    SqlConnection.ConnectionString = @"Data Source=np:\\.\pipe\LOCALDB#3DBB2833\tsql\query;Initial Catalog=bd_zapateria;User ID=userZapateria;Password=contraseña";
                }
                

            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        public void AbrirConexion(Boolean transaccion)
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    SqlConnection.Open();
                    SqlCommand = SqlConnection.CreateCommand();
                    SqlCommand.CommandTimeout = 0;
                    if (transaccion)
                    {
                        SqlTransaction = SqlConnection.BeginTransaction();
                        SqlCommand.Transaction = SqlTransaction;
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }
            }
        }
        public void CerrarConexion()
        {
            try
            {
                if (SqlConnection.State == System.Data.ConnectionState.Open)
                {
                    SqlConnection.Close();
                    SqlConnection.Dispose();
                    if (SqlCommand != null)
                    {
                        SqlCommand.Dispose();
                    }
                    if (SqlTransaction != null)
                    {
                        SqlTransaction.Dispose();
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }


        public void Dispose()
        {
            SqlConnection.Dispose();
        }
    }
}
