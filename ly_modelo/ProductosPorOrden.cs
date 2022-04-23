using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    class ProductosPorOrden
    {
        public int idProducto { get; set; }
        public int idOrden { get; set; }
        public int cantidadProductos { get; set; }
        public float precio { get; set; }


        public ProductosPorOrden(int idProducto, int idOrden, int cantidadProductos, float precio)
        {
            this.idProducto = idProducto;
            this.idOrden = idOrden;
            this.cantidadProductos = cantidadProductos;
            this.precio = precio;
        }

    }
}
