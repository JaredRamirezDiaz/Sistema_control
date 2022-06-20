using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;

namespace ly_negocio
{
    public static class neg_Ordenes
    {
        public static List<Orden> obtenerTodos()
        {
            return dat_Orden.obtenerTodos();
        }

        public static Orden agregar(int idUsuario)
        {
            return dat_Orden.agregar(idUsuario);
        }

        public static bool agregarProductoAOrden(int producto,int cantidad, double precioVenta,string estatus, Orden orden)
        {
            int estatusInt = 0;
            switch (estatus)
            {
                case "Activo":
                    estatusInt = 1;
                    break;

                case "Eliminado":
                    estatusInt = 0;
                    break;
                default:
                    break;
            }
            return dat_Orden.agregarProductoAOrden(producto,cantidad,precioVenta,estatusInt, orden);
        }
        public static bool cancelarOrden(Orden orden)
        {
            return dat_Orden.cancelarOrden(orden);
        }
        public static bool ordenPagada(Orden orden)
        {
            return dat_Orden.ordenPagada(orden);
        }

        public static bool editar(Orden orden)
        {
            return dat_Orden.editar(orden);
        }

        public static bool eliminar(Orden orden)
        {
            return dat_Orden.eliminar(orden);
        }

        public static Orden buscar(Orden orden)
        {
            return dat_Orden.buscar(orden);
        }
    }
}
