using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace ly_datos
{
    public class dat_UIElements
    {
       
        public static List<UIElements> obtenerElementosLayout(string nombreCatalogo, int tipoElemento = 0, string fuenteDatos = "")
        {
            List<UIElements> listaCampos = new List<UIElements>();
            //return listaCampos;

            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerElementosLayout = null;
            
            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType =CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_obtener_elementos_layout";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;


                if (tipoElemento > 0)
                    conexion.SqlCommand.Parameters.Add(new SqlParameter("@idTipoElemento", SqlDbType.Int)).Value = tipoElemento;

                if (!fuenteDatos.Equals(string.Empty))
                    conexion.SqlCommand.Parameters.Add(new SqlParameter("@fuenteDatos", SqlDbType.VarChar)).Value = fuenteDatos;


                sqldr_ObtenerElementosLayout = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerElementosLayout.HasRows)
                {
                    while (sqldr_ObtenerElementosLayout.Read())
                    {
                        switch ((UIElements.TipoElemento) sqldr_ObtenerElementosLayout.GetInt32("idTipoElemento") )
                        {
                            case UIElements.TipoElemento.GridView:
                                listaCampos.Add(new ElementoLayoutGrid(
                                    tipoElemento: (UIElements.TipoElemento)sqldr_ObtenerElementosLayout.GetInt32("idTipoElemento"),
                                    ancho: sqldr_ObtenerElementosLayout.GetInt32("ancho"),
                                    alto: sqldr_ObtenerElementosLayout.GetInt32("alto"),
                                    elementosJSON: sqldr_ObtenerElementosLayout.GetString("elementos"),
                                    columnasJSON: sqldr_ObtenerElementosLayout.GetString("estructura"),
                                    dock: sqldr_ObtenerElementosLayout.GetString("dock"),
                                    fuenteDeDatos: sqldr_ObtenerElementosLayout.GetString("fuenteDeDatos")
                                    ));
                                break;
                            case UIElements.TipoElemento.CardVistaPrevia:
                                listaCampos.Add(new ElementoLayoutCardVistaPrevia(
                                   tipoElemento: (UIElements.TipoElemento)sqldr_ObtenerElementosLayout.GetInt32("idTipoElemento"),
                                   ancho: sqldr_ObtenerElementosLayout.GetInt32("ancho"),
                                   alto: sqldr_ObtenerElementosLayout.GetInt32("alto"),
                                   camposJSON: sqldr_ObtenerElementosLayout.GetString("estructura"),
                                   dock: sqldr_ObtenerElementosLayout.GetString("dock"),
                                   fuenteDeDatos: sqldr_ObtenerElementosLayout.GetString("fuenteDeDatos")
                                   ));
                                break;
                            case UIElements.TipoElemento.BotonAgregar:
                                listaCampos.Add(new UIElements(
                                        tipoElemento: (UIElements.TipoElemento)sqldr_ObtenerElementosLayout.GetInt32("idTipoElemento"),
                                   ancho: sqldr_ObtenerElementosLayout.GetInt32("ancho"),
                                   alto: sqldr_ObtenerElementosLayout.GetInt32("alto")
                                    ));
                                break;
                            case UIElements.TipoElemento.BotonBuscar:
                                listaCampos.Add(new UIElements(
                                        tipoElemento: (UIElements.TipoElemento)sqldr_ObtenerElementosLayout.GetInt32("idTipoElemento"),
                                   ancho: sqldr_ObtenerElementosLayout.GetInt32("ancho"),
                                   alto: sqldr_ObtenerElementosLayout.GetInt32("alto")
                                    ));
                                break;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (sqldr_ObtenerElementosLayout != null)
                {
                    if (!sqldr_ObtenerElementosLayout.IsClosed)
                    {
                        sqldr_ObtenerElementosLayout.Close();
                    }
                    sqldr_ObtenerElementosLayout.Dispose();
                }
            }
            return listaCampos;
        }

        public static List<UIElements.CampoEstructura> obtenerAtributos(string nombreCatalogo)
        {
            List<UIElements.CampoEstructura> listaAtributos = new List<UIElements.CampoEstructura>();
            

            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerAtributos = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_obtener_estructura";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;
                sqldr_ObtenerAtributos = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerAtributos.HasRows)
                {
                    sqldr_ObtenerAtributos.Read();
                    listaAtributos = JsonSerializer.Deserialize<List<UIElements.CampoEstructura>>(sqldr_ObtenerAtributos.GetString("Estructura"));
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (sqldr_ObtenerAtributos != null)
                {
                    if (!sqldr_ObtenerAtributos.IsClosed)
                    {
                        sqldr_ObtenerAtributos.Close();
                    }
                    sqldr_ObtenerAtributos.Dispose();
                }
            }
            return listaAtributos;

        }

        public static List<UIElements.CampoEstructura> obtenerEstructura(string nombreCatalogo,int tipoElemento = 0 , string fuenteDatos = "" )
        {
            List<UIElements.CampoEstructura> listaAtributos = new List<UIElements.CampoEstructura>();


            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerAtributos = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_obtener_estructura";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;
                
                if (tipoElemento>0)
                    conexion.SqlCommand.Parameters.Add(new SqlParameter("@idTipoElemento", SqlDbType.Int)).Value = tipoElemento;

                if (!fuenteDatos.Equals(string.Empty))
                    conexion.SqlCommand.Parameters.Add(new SqlParameter("@fuenteDatos", SqlDbType.VarChar)).Value = fuenteDatos;


                sqldr_ObtenerAtributos = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerAtributos.HasRows)
                {
                    while (sqldr_ObtenerAtributos.Read())
                    {
             
                        listaAtributos.Add(new UIElements.CampoEstructura(
                            columna: sqldr_ObtenerAtributos.GetString("columna"),
                            ancho: sqldr_ObtenerAtributos.GetInt32("ancho"),
                            alto: sqldr_ObtenerAtributos.GetInt32("alto"),
                            tipoElemento: (UIElements.TipoElemento)sqldr_ObtenerAtributos.GetInt32("tipoElemento"),
                            jsonElementos: sqldr_ObtenerAtributos.GetString("jsonString"),
                            etiqueta: sqldr_ObtenerAtributos.GetString("etiqueta"),
                            principal: sqldr_ObtenerAtributos.GetInt32("principal")==1,
                            buscable: sqldr_ObtenerAtributos.GetInt32("buscable")==1,
                            visible: sqldr_ObtenerAtributos.GetInt32("visible")==1,
                            clavePrimaria: sqldr_ObtenerAtributos.GetInt32("clavePrimaria")==1,
                            posicion: sqldr_ObtenerAtributos.GetInt32("posicion"),
                            tipoColumna: sqldr_ObtenerAtributos.GetString("tipoColumna"),
                            reference: sqldr_ObtenerAtributos.GetString("reference"),
                            valor: sqldr_ObtenerAtributos.GetString("valor"),
                            requerido: sqldr_ObtenerAtributos.GetInt32("requerido")==1,
                            longitudMaxima: sqldr_ObtenerAtributos.GetInt32("longitudMaxima"),
                            tipoDato: sqldr_ObtenerAtributos.GetString("tipoDato")
                        )

                            );
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (sqldr_ObtenerAtributos != null)
                {
                    if (!sqldr_ObtenerAtributos.IsClosed)
                    {
                        sqldr_ObtenerAtributos.Close();
                    }
                    sqldr_ObtenerAtributos.Dispose();
                }
            }
            return listaAtributos;

        }

        public static Dictionary<string,string> obtenerElementos(string nombreCatalogo)
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();


            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_ObtenerAtributos = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_catalogo_elementos_grid";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@nombreCatalogo", SqlDbType.VarChar)).Value = nombreCatalogo;

               

                sqldr_ObtenerAtributos = conexion.SqlCommand.ExecuteReader();
                if (sqldr_ObtenerAtributos.HasRows)
                {
                    while (sqldr_ObtenerAtributos.Read())
                    {
                        resultado.Add("elementos", sqldr_ObtenerAtributos.GetString("elementos"));
                        resultado.Add("estructura", sqldr_ObtenerAtributos.GetString("estructura"));
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            finally
            {
                if (sqldr_ObtenerAtributos != null)
                {
                    if (!sqldr_ObtenerAtributos.IsClosed)
                    {
                        sqldr_ObtenerAtributos.Close();
                    }
                    sqldr_ObtenerAtributos.Dispose();
                }
            }
            return resultado;
        }
       
    }
}
