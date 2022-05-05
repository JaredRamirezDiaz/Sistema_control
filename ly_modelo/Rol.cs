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
        public int idCatalogo { get; set; }
        public Rol(int idRol, string nombre, int estatus, string descripcion,int idCatalogo)
        {
            this.idRol = idRol;
            this.nombre = nombre;
            this.estatus = estatus;
            this.descripcion = descripcion;
            this.idCatalogo = idCatalogo;
        }

        public static List<UIElements.campoBusqueda> camposBusqueda()
        {
            List<UIElements.campoBusqueda> campos = new List<UIElements.campoBusqueda>();
            //campos.Add(new UIElements.campoBusqueda("Rol", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Descripción", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Catalogo", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Activo", 150, UIElements.campoBusqueda.TipoCampo.CHECK_BOX));

            return campos;
        }
    }
}
