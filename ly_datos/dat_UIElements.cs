using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using Microsoft.Data.SqlClient;
using System.Data;
namespace ly_datos
{
    public class dat_UIElements
    {
        public static List<UIElements.campoBusqueda> obtenerCamposDeBusqueda(string nombreCatalogo)
        {
            List<UIElements.campoBusqueda> listaCampos = new List<UIElements.campoBusqueda>();
            //return listaCampos;

            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerCamposBusqueda = null;
            
            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType =CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_obtener_campos";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;
                sqldr_ObtenerCamposBusqueda = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerCamposBusqueda.HasRows)
                {
                    while (sqldr_ObtenerCamposBusqueda.Read())
                    {
                        listaCampos.Add(new UIElements.campoBusqueda(
                            etiqueta: sqldr_ObtenerCamposBusqueda.GetString("etiqueta"),
                            ancho: sqldr_ObtenerCamposBusqueda.GetInt32("ancho"),
                            alto: sqldr_ObtenerCamposBusqueda.GetInt32("alto"),
                            tipoCampo:(UIElements.TipoElemento)sqldr_ObtenerCamposBusqueda.GetInt32("tipoElemento"),
                            jsonStringValores:sqldr_ObtenerCamposBusqueda.GetString("jsonString")
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
                if (sqldr_ObtenerCamposBusqueda != null)
                {
                    if (!sqldr_ObtenerCamposBusqueda.IsClosed)
                    {
                        sqldr_ObtenerCamposBusqueda.Close();
                    }
                    sqldr_ObtenerCamposBusqueda.Dispose();
                }
            }
            return listaCampos;
        }
        public static List<UIElements> obtenerElementosLayout(string nombreCatalogo)
        {
            List<UIElements> listaCampos = new List<UIElements>();
            //return listaCampos;

            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerCamposBusqueda = null;
            
            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType =CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_obtener_elementos_layout";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;
                sqldr_ObtenerCamposBusqueda = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerCamposBusqueda.HasRows)
                {
                    while (sqldr_ObtenerCamposBusqueda.Read())
                    {
                        listaCampos.Add(new ElementoLayoutGrid(
                            tipoElemento:(UIElements.TipoElemento)sqldr_ObtenerCamposBusqueda.GetInt32("idTipoElemento"),
                            ancho: sqldr_ObtenerCamposBusqueda.GetInt32("ancho"),
                            alto: sqldr_ObtenerCamposBusqueda.GetInt32("alto"),
                            elementosJSON:sqldr_ObtenerCamposBusqueda.GetString("elementos"),
                            columnasJSON:sqldr_ObtenerCamposBusqueda.GetString("estructura")
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
                if (sqldr_ObtenerCamposBusqueda != null)
                {
                    if (!sqldr_ObtenerCamposBusqueda.IsClosed)
                    {
                        sqldr_ObtenerCamposBusqueda.Close();
                    }
                    sqldr_ObtenerCamposBusqueda.Dispose();
                }
            }
            return listaCampos;
        }
    }
}
