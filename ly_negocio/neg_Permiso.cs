using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Permiso
    {
        public static List<Permiso> obtenerTodos()
        {
            return dat_Permiso.obtenerTodos();
        }
        public static bool agregar(Permiso permiso)
        {
            return dat_Permiso.agregar(permiso);
        }
        public static bool editar(Permiso permiso)
        {
            return dat_Permiso.editar(permiso);
        }

        public static bool eliminar(Permiso permiso)
        {
            return dat_Permiso.eliminar(permiso);
        }

        public static Permiso buscar(Permiso permiso)
        {
            return dat_Permiso.buscar(permiso);
        }
    }
}
