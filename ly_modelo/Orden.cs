using System;
using System.Collections.Generic;
using System.Text;


namespace ly_modelo
{
    public class Orden
    {
        public int idOrden { get; set; }
        public int estatus { get; set; }
        public DateTime fecha { get; set; }
        public int idUsuario { get; set; }  


        public Orden(int idOrden, int estatus, DateTime fecha, int idUsuario)
        {
            this.idOrden = idOrden;
            this.estatus = estatus;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
        }

    }
}
