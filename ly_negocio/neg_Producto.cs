using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public class neg_Producto
    {
        public static List<Producto> obtenerTodos()
        {
            return dat_Producto.obtenerTodos();
        }
        public static bool agregar(Producto producto)
        {
            return dat_Producto.agregar(producto);
        }
        public static bool editar(Producto producto)
        {
            return dat_Producto.editar(producto);
        }

        public static bool eliminar(Producto producto)
        {
            return dat_Producto.eliminar(producto);
        }

        public static Producto buscar(Producto producto)
        {
            return dat_Producto.buscar(producto);
        }
    }
}
