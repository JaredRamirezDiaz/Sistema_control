using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Rol
    {
        public int idRol { get; set; }
        public string nombre { get; set; }
        public int estatus { get; set; }
        public string descripcion { get; set; }

        public Rol(int idRol, string nombre, int estatus, string descripcion)
        {
            this.idRol = idRol;
            this.nombre = nombre;
            this.estatus = estatus;
            this.descripcion = descripcion;
        }
    }
}
