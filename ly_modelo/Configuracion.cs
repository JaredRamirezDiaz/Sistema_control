using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Configuracion
    {
        public int idConfiguracion { get; set; }
        public string nombreParametro { get; set; }
        public string valor1 { get; set; }
        public string valor2 { get; set; }
        public string valor3 { get; set; }
        public string empresa { get; set; }
        public string tipoParametro { get; set; }

        public Configuracion(int idConfiguracion=0, string nombreParametro="", string valor1="", string valor2="", string valor3="", string empresa="", string tipoParametro="")
        {
            this.idConfiguracion = idConfiguracion;
            this.nombreParametro = nombreParametro;
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.valor3 = valor3;
            this.empresa = empresa;
            this.tipoParametro = tipoParametro;
        }

        
    }
}
