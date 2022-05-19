using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ly_datos
{
    public static class dat_Configuracion
    {
        public static List<Configuracion> obtenerTodos(int idEmpresa)
        {
            List<Configuracion> listaConfiguraciones = new List<Configuracion>();
            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_obtenerCatalogos = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_Configuraciones";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.VarChar)).Value = 4;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idEmpresa", SqlDbType.Int)).Value = idEmpresa;
                sqldr_obtenerCatalogos = conexion.SqlCommand.ExecuteReader();
                if (sqldr_obtenerCatalogos.HasRows)
                {
                    while (sqldr_obtenerCatalogos.Read())
                    {
                        listaConfiguraciones.Add(new Configuracion(
                            idConfiguracion: sqldr_obtenerCatalogos.GetInt32("idConfiguracion"),
                            nombreParametro: sqldr_obtenerCatalogos.GetString("Parametro"),
                            valor: sqldr_obtenerCatalogos.GetString("valor"),
                            descripcion: sqldr_obtenerCatalogos.GetString("descripcion"),
                            empresa: sqldr_obtenerCatalogos.GetString("empresa"),
                            tipoParametro: sqldr_obtenerCatalogos.GetString("tipoParametro"),
                            tipoValor: sqldr_obtenerCatalogos.GetString("tipoValor")
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

            return listaConfiguraciones;

        }
        public static bool agregar(Configuracion configuracion)
        {
            return false;
        }
        public static bool editar(Configuracion configuracion)
        {
            return false;
        }

        public static bool eliminar(Configuracion configuracion)
        {
            return false;
        }

        public static List<Configuracion> buscar(Configuracion configuracion)
        {
            List<Configuracion> configuraciones = new List<Configuracion>();
            
            //switch (configuracion.tipoParametro)
            //{
            //    case "menu":
            //        configuraciones.Add(new Configuracion(1, "menu_Productos", "Productos", "frmProductos", "", "Zapatos", "menu"));
            //        configuraciones.Add(new Configuracion(2, "menu_Categorias", "Categorias", "frmCategorias", "", "Zapatos", "menu"));
            //        configuraciones.Add(new Configuracion(3, "menu_Orden", "Ordenes", "frmOrden", "", "Zapatos", "menu"));
            //        configuraciones.Add(new Configuracion(4, "menu_Permisos", "Permisos", "frmPermisos", "", "Zapatos", "menu"));
            //        configuraciones.Add(new Configuracion(5, "menu_Usuarios", "Usuarios", "frmUsuarios", "", "Zapatos", "menu"));
            //        break;
            //    case "sistema":
            //        configuraciones.Add(new Configuracion(6, "color_fondo_sistema", "Color fondo", "#FFF", "", "Zapatos", "color"));
            //        configuraciones.Add(new Configuracion(6, "color_primario", "Color primario", "#961414", "", "Zapatos", "color"));
            //        configuraciones.Add(new Configuracion(7, "color_secundario", "color secundario", "#FFF", "", "Zapatos", "color"));
            //        configuraciones.Add(new Configuracion(8, "color_texto_primario", "texto", "#000", "", "Zapatos", "color"));
            //        configuraciones.Add(new Configuracion(9, "color_texto_secundario", "texto secundario", "#FFF", "", "Zapatos", "color"));
            //        break;
            //    default:break;
            //}

            return configuraciones;
        }
    }
}
