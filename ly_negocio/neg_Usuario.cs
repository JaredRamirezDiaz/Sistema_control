using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public static class neg_Usuario
    {
        public static List<Usuario> obtenerTodos()
        {
            return dat_Usuario.obtenerTodos();
        }
        public static Usuario iniciarSesion(string usuario, string password)
        {
            return dat_Usuario.iniciarSesion(usuario,password);
        }
        public static bool agregar(Usuario usuario)
        {
            return dat_Usuario.agregar(usuario);
        }
        public static bool editar(Usuario usuario)
        {
            return dat_Usuario.editar(usuario);
        }

        public static bool eliminar(Usuario usuario)
        {
            return dat_Usuario.eliminar(usuario);
        }

        public static Usuario buscar(Usuario usuario)
        {
            return dat_Usuario.buscar(usuario);
        }
    }
}
