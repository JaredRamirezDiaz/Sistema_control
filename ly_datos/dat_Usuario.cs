using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ly_modelo;
using System.Data.SqlClient;

namespace ly_datos
{
    public static class dat_Usuario
    {
        public static List<Usuario> obtenerTodos()
        {
            return null;
        }
        
        public static Usuario iniciarSesion(string usuario, string password)
        {
            Usuario usuarioLogin = null;
            Conexion conexion = new Conexion("Zapateria");
            SqlDataReader sqldr_obtenerUsuario = null;

            try
            {
                conexion.AbrirConexion(false);
                conexion.SqlCommand.CommandType = CommandType.StoredProcedure;
                conexion.SqlCommand.CommandText = "sp_Usuarios";
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@P_Action", SqlDbType.VarChar)).Value = 6;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar)).Value = usuario;
                conexion.SqlCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar)).Value = password;
                sqldr_obtenerUsuario = conexion.SqlCommand.ExecuteReader();
                if (sqldr_obtenerUsuario.HasRows)
                {
                    while (sqldr_obtenerUsuario.Read())
                    {
                        usuarioLogin = new Usuario(
                            idUsuario: sqldr_obtenerUsuario.GetInt32("IdUsuario"),
                            nombre: sqldr_obtenerUsuario.GetString("Usuario"),
                            login: sqldr_obtenerUsuario.GetString("UserLogin"),
                            activo: sqldr_obtenerUsuario.GetBoolean("Activo"),
                            idRol: sqldr_obtenerUsuario.GetInt32("IdRol")
                            );
                        
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
                if (sqldr_obtenerUsuario != null)
                {
                    if (!sqldr_obtenerUsuario.IsClosed)
                    {
                        sqldr_obtenerUsuario.Close();
                    }
                    sqldr_obtenerUsuario.Dispose();
                }
            }
            return usuarioLogin;
        }

        public static bool agregar(Usuario usuario)
        {
            return false;
        }
        public static bool editar(Usuario usuario)
        {
            return false;
        }

        public static bool eliminar(Usuario usuario)
        {
            return false;
        }

        public static Usuario buscar(Usuario usuario)
        {
            return null;
        }
    }
}
