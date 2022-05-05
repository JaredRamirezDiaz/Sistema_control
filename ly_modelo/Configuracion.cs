using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Configuracion
    {
        public int idConfiguracion { get; set; }
        public string nombreParametro { get; set; }
        public string valor { get; set; }
        public string descripcion { get; set; }
        public string empresa { get; set; }
        public string tipoParametro { get; set; }

        public Configuracion(int idConfiguracion = 0, string nombreParametro="", string valor="",string descripcion="", string empresa="", string tipoParametro="")
        {
            this.idConfiguracion = idConfiguracion;
            this.nombreParametro = nombreParametro;
            this.valor = valor;
            this.descripcion = descripcion;
            this.empresa = empresa;
            this.tipoParametro = tipoParametro;
        }

        public static List<UIElements.campoBusqueda> camposBusqueda()
        {
            List<UIElements.campoBusqueda> campos = new List<UIElements.campoBusqueda>();
            //campos.Add(new UIElements.campoBusqueda("Parámetro", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Empresa", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Tipo de parámetro", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));

            return campos;
        }


    }
}
