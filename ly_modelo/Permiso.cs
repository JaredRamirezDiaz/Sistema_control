using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Permiso
    {
        public int idPermiso { get; set; }
        public int idCatalogo { get; set; }
        public int soloLectura { get; set; }
        public int estatus { get; set; }

        public Permiso(int idPrermiso, int idCatalogo, int soloLectura, int estatus)
        {
            this.idPermiso = idPermiso;
            this.idCatalogo = idCatalogo;
            this.soloLectura = soloLectura;
            this.estatus = estatus;
        }

        public static List<UIElements.campoBusqueda> camposBusqueda()
        {
            List<UIElements.campoBusqueda> campos = new List<UIElements.campoBusqueda>();
            //campos.Add(new UIElements.campoBusqueda("Permiso", 150, UIElements.campoBusqueda.TipoCampo.NUMERO));
            //campos.Add(new UIElements.campoBusqueda("Catalogo", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Solo Lectura", 150, UIElements.campoBusqueda.TipoCampo.CHECK_BOX));
            //campos.Add(new UIElements.campoBusqueda("Activo", 150, UIElements.campoBusqueda.TipoCampo.CHECK_BOX));

            return campos;
        }

    }
}
