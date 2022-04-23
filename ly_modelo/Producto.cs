using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estiloModelo { get; set; }
        public string  talla { get; set; }
        public string color { get; set; }
        public string  codigo { get; set; }
        public int estatus { get; set; }
        public float precio { get; set; }
        public int idCategoria { get; set; }

        public Producto(int idProducto, string nombre, string descripcion, string estiloModelo, string talla, string color, string codigo, int estatus, float precio, int idCategoria)
        {
            this.idProducto = idProducto;
            this.nombre = nombre;
            this.estiloModelo = estiloModelo;
            this.talla = talla;
            this.color = color;
            this.codigo = codigo;
            this.estatus = estatus;
            this.precio = precio;
            this.idCategoria = idCategoria;
        }
    }
}
