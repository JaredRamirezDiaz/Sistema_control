using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ly_datos
{
    public class dat_Catalogo
    {
        public static List<Catalogo> obtenerTodos()
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
                            layoutPersonalizado: sqldr_obtenerCatalogos.GetBoolean("layoutPersonalizado")
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
        public static bool agregar(Catalogo catalogo)
        {
            return false;
        }
        public static bool editar(Catalogo catalogo)
        {
            return false;
        }

        public static bool eliminar(Catalogo catalogo)
        {
            return false;
        }

        public static Catalogo buscar(Catalogo catalogo)
        {
            return null;
        }
    }
}
