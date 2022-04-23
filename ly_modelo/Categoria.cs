using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public int estatus { get; set; }


        public Categoria(int idCategoria, string nombre, int estatus)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.estatus = estatus;
        }
    }
}
