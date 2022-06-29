using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using System.Data.SqlClient;
using System.Data;

namespace ly_datos
{
    public class dat_Catalogo
    {
        public static List<Catalogo> obtenerTodos(int IdUsuario)
        {
            List<Catalogo> listaCatalogos = new List<Catalogo>();
            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_obtenerCatalogos = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_Catalogos";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.VarChar)).Value = 4;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@IdUsuario", SqlDbType.Int)).Value = IdUsuario;
                sqldr_obtenerCatalogos = conexion.SqlCommand.ExecuteReader();
                if (sqldr_obtenerCatalogos.HasRows)
                {
                    while (sqldr_obtenerCatalogos.Read())
                    {
                        listaCatalogos.Add(new Catalogo(
                            idCatalogo: sqldr_obtenerCatalogos.GetInt32("IdCatalogo"),
                            nombre: sqldr_obtenerCatalogos.GetString("Catalogo"),
                            icono: sqldr_obtenerCatalogos.GetInt32("iconoMenuFA"),
                            storedProcedure: sqldr_obtenerCatalogos.GetString("storedProcedure"),
                            controlSistema: sqldr_obtenerCatalogos.GetBoolean("controlSistema"),
                            layoutPersonalizado: sqldr_obtenerCatalogos.GetBoolean("layoutPersonalizado"),
                            formulario: sqldr_obtenerCatalogos.GetString("Formulario")
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (sqldr_obtenerCatalogos != null)
                {
                    if (!sqldr_obtenerCatalogos.IsClosed)
                    {
                        sqldr_obtenerCatalogos.Close();
                    }
                    sqldr_obtenerCatalogos.Dispose();
                }
            }
            return listaCatalogos;
        }

        public static bool agregar(string consulta)
        {
            Conexion conexion = new Conexion("Zapateria");
            bool resultado = false;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.Text;
                conexion.SqlCommand.CommandText = consulta;

                resultado = conexion.SqlCommand.ExecuteNonQuery() > 0;

                if (resultado)
                    conexion.SqlCommand.Transaction.Commit();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return resultado;
        }
        public static bool editar(string consulta)
        {
            Conexion conexion = new Conexion("Zapateria");
            int columnasAfectadas = 0;
            bool resultado = false;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.Text;
                conexion.SqlCommand.CommandText = consulta;

                columnasAfectadas = conexion.SqlCommand.ExecuteNonQuery();

                if (columnasAfectadas == 1)
                {
                    resultado = true;
                    conexion.SqlCommand.Transaction.Commit();
                }
                else if (columnasAfectadas == 0)
                {
                    resultado = false;
                    conexion.SqlCommand.Transaction.Rollback();
                }
                else
                {
                    resultado = false;
                    conexion.SqlCommand.Transaction.Rollback();
                }

                
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            


            return resultado;
        }

        public static bool eliminar(string consulta)
        {
            return false;
        }

        public static Catalogo buscar(string consulta)
        {
            return null;
        }
    }
}
