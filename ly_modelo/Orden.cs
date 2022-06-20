using System;
using System.Collections.Generic;
using System.Text;


namespace ly_modelo
{
    public class Orden
    {
        public int idOrden { get; set; }
        public string orden { get; set; }
        public int estatus { get; set; }
        public DateTime fecha { get; set; }
        public int idUsuario { get; set; }  


        public Orden(int idOrden,string orden, int estatus, DateTime fecha, int idUsuario)
        {
            this.idOrden = idOrden;
            this.orden = orden;
            this.estatus = estatus;
            this.fecha = fecha;
            this.idUsuario = idUsuario;
        }

        public static List<UIElements.CampoEstructura> camposBusqueda()
        {
            List<UIElements.CampoEstructura> campos = new List<UIElements.CampoEstructura>();
            //campos.Add(new UIElements.campoBusqueda("idOrden", 150, UIElements.campoBusqueda.TipoCampo.NUMERO));
            //campos.Add(new UIElements.campoBusqueda("Estatus", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("fecha", 150, UIElements.campoBusqueda.TipoCampo.FECHA_BETWEEN));
            //campos.Add(new UIElements.campoBusqueda("Usuario", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            
            return campos;
        }

    }
}
