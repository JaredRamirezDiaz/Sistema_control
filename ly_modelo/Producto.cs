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

        public static List<UIElements.campoBusqueda> camposBusqueda()
        {
            List<UIElements.campoBusqueda> campos = new List<UIElements.campoBusqueda>();
            //campos.Add(new UIElements.campoBusqueda("Nombre",150,UIElements.campoBusqueda.TipoCampo.TEXTO));
            //campos.Add(new UIElements.campoBusqueda("Modelo",150,UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Talla",150,UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Color",150,UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Codigo",150,UIElements.campoBusqueda.TipoCampo.TEXTO));
            //campos.Add(new UIElements.campoBusqueda("Estatus",150,UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Precio",150,UIElements.campoBusqueda.TipoCampo.NUMERO_BETWEEN));
            //campos.Add(new UIElements.campoBusqueda("Categoria",150,UIElements.campoBusqueda.TipoCampo.COMBO_BOX));

            return campos;
        }
    }
}
