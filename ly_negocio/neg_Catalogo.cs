using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Catalogo
    {
        public static List<Catalogo> obtenerTodos()
        {
            return dat_Catalogo.obtenerTodos();
        }
        public static bool agregar(Catalogo catalogo)
        {
            return dat_Catalogo.agregar(catalogo);
        }
        public static bool editar(Catalogo catalogo)
        {
            return dat_Catalogo.editar(catalogo);
        }
        public static bool eliminar(Catalogo catalogo)
        {
            return dat_Catalogo.eliminar(catalogo);
        }
        public static Catalogo buscar(Catalogo catalogo)
        {
            return dat_Catalogo.buscar(catalogo);
        }
    }
}
