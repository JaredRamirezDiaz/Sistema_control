using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Catalogo
    {
        public static List<Catalogo> obtenerTodos(int IdUsuario)
        {
            return dat_Catalogo.obtenerTodos(IdUsuario);
        }
        public static bool agregar(string consulta)
        {
            return dat_Catalogo.agregar(consulta);
        }
        public static bool editar(string consulta)
        {
            return dat_Catalogo.editar(consulta);
        }
        public static bool eliminar(string consulta)
        {
            return dat_Catalogo.eliminar(consulta);
        }
        public static Catalogo buscar(string consulta)
        {
            return dat_Catalogo.buscar(consulta);
        }

        
    }
}
