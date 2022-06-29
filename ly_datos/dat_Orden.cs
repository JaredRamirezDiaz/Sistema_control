using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ly_modelo;
using System.Data.SqlClient;

namespace ly_datos
{
    public static class dat_Orden
    {
        public static List<Orden> obtenerTodos()
        {
            return null;
        }
        public static Orden agregar(int idUsuario)
        {
            Conexion conexion = new Conexion("Zapateria");

            Orden ordenAgregada = null;
            SqlDataReader sqldr_OrdenAgregada = null;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_ordenes";

                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.Int)).Value = 1;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.Int)).Value = idUsuario;



                sqldr_OrdenAgregada = conexion.SqlCommand.ExecuteReader();
                if (sqldr_OrdenAgregada.HasRows)
                {
                    while (sqldr_OrdenAgregada.Read())
                    {
                        ordenAgregada = new Orden(
                            idOrden: sqldr_OrdenAgregada.GetInt32("IdOrden"),
                            orden: sqldr_OrdenAgregada.GetString("Orden"),
                            estatus: sqldr_OrdenAgregada.GetInt32("Estatus"),
                            fecha: sqldr_OrdenAgregada.GetDateTime("Fecha"),
                            idUsuario= sqldr_OrdenAgregada.GetInt32("idUsuario")
                            );
                        break;
                    }

                }

                if (ordenAgregada!=null)
                {

                    sqldr_OrdenAgregada.Close();
                    conexion.SqlCommand.Transaction.Commit();
                }
                else
                {
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



            return ordenAgregada;
        }

        public static bool agregarProductoAOrden(int idProducto, int cantidad, double precioVenta, int estatus, Orden orden)
        {
            Conexion conexion = new Conexion("Zapateria");
            int columnasAfectadas = 0;
            bool resultado = false;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_ordenes";

                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.Int)).Value = 6;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idProducto", SqlDbType.Int)).Value = idProducto;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@precioVenta", SqlDbType.Decimal)).Value = precioVenta;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int)).Value = cantidad;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idOrden", SqlDbType.Int)).Value = orden.idOrden;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@estatus", SqlDbType.Int)).Value = estatus;


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

        public static bool cancelarOrden(Orden orden)
        {
            Conexion conexion = new Conexion("Zapateria");
            int columnasAfectadas = 0;
            bool resultado = false;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_ordenes";

                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.Int)).Value = 3;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idOrden", SqlDbType.Int)).Value = orden.idOrden;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@estatus", SqlDbType.Int)).Value = 0;


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

        public static bool ordenPagada(Orden orden)
        {
            Conexion conexion = new Conexion("Zapateria");
            int columnasAfectadas = 0;
            bool resultado = false;

            try
            {
                conexion.AbrirConexion(true);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_ordenes";

                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.Int)).Value = 3;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@idOrden", SqlDbType.Int)).Value = orden.idOrden;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@estatus", SqlDbType.Int)).Value = 2;


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
        public static bool editar(Orden orden)
        {
            return false;
        }

        public static bool eliminar(Orden orden)
        {
            return false;
        }

        public static Orden buscar(Orden orden)
        {
            return null;
        }
    }
}
