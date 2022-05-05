using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Configuracion
    {
        public static List<Configuracion> obtenerTodos(int idEmpresa)
        {
            return dat_Configuracion.obtenerTodos(idEmpresa);
        }
        public static bool agregar(Configuracion configuracion)
        {
            return dat_Configuracion.agregar(configuracion);
        }
        public static bool editar(Configuracion configuracion)
        {
            return dat_Configuracion.editar(configuracion);
        }

        public static bool eliminar(Configuracion configuracion)
        {
            return dat_Configuracion.eliminar(configuracion);
        }

        public static List<Configuracion> buscar(Configuracion configuracion)
        {
            return dat_Configuracion.buscar(configuracion);
        }
    }
}
