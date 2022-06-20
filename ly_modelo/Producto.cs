using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ly_modelo
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public string estiloModelo { get; set; }
        public string  talla { get; set; }
        public string  codigo { get; set; }
        public float precio { get; set; }
        public string color { get; set; }
        public int idCategoria { get; set; }
        public int estatus { get; set; }

        public Producto(int idProducto, string producto, string descripcion, string estiloModelo, string talla, string codigo, float precio, string color, int idCategoria, int estatus)
        {
            this.idProducto = idProducto;
            this.producto = producto;
            this.descripcion = descripcion;
            this.estiloModelo = estiloModelo;
            this.talla = talla;
            this.codigo = codigo;
            this.precio = precio;
            this.color = color;
            this.idCategoria = idCategoria;
            this.estatus = estatus;
        }

        public Producto(string[] elementos)
        {
            this.idProducto = int.Parse(elementos[0]);
            this.producto= elementos[1];
            this.descripcion= elementos[2];
            this.estiloModelo= elementos[3];
            this.talla= elementos[4];
            this.codigo= elementos[5];
            this.precio = float.Parse(elementos[6]);
            this.color = elementos[7];
            this.idCategoria = int.Parse(elementos[8]);
            this.estatus = int.Parse(elementos[9]);

        }

        public static List<UIElements.CampoEstructura> camposBusqueda()
        {
            List<UIElements.CampoEstructura> campos = new List<UIElements.CampoEstructura>();
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
