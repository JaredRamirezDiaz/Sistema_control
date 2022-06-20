using System;
using System.Collections.Generic;
using System.Text;


namespace ly_modelo
{
    public class Catalogo
    {
        public int idCatalogo { get; set; }
        public string nombre { get; set; }
        public int iconoMenuFA { get; set; }
        public string storedProcedure { get; set; }
        public bool controlSistema { get; set; }
        public bool layoutPersonalizado { get; set; }
        public string formulario { get; set; }

        //public string categoriaCatalogo { get; set; }

        public Catalogo(int idCatalogo, string nombre, int icono,string storedProcedure,bool controlSistema, bool layoutPersonalizado,string formulario)
        {
            this.idCatalogo = idCatalogo;
            this.nombre = nombre;
            this.iconoMenuFA = icono;
            this.storedProcedure = storedProcedure;
            this.controlSistema = controlSistema;
            this.layoutPersonalizado = layoutPersonalizado;
            this.formulario = formulario;
        }

    }
}
