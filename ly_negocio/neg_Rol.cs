using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Rol
    {
        public static List<Rol> obtenerTodos()
        {
            return dat_Rol.obtenerTodos();
        }
        public static bool agregar(Rol rol)
        {
            return dat_Rol.agregar(rol);
        }
        public static bool editar(Rol rol)
        {
            return dat_Rol.editar(rol);
        }

        public static bool eliminar(Rol rol)
        {
            return dat_Rol.eliminar(rol);
        }

        public static Rol buscar(Rol rol)
        {
            return dat_Rol.buscar(rol);
        }
    }
}
