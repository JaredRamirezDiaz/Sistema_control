using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public static class Sistema
    {
        private static Dictionary<string, Valor> Configuraciones = new Dictionary<string, Valor>();
        public static Usuario usuarioSesion=new Usuario();

        public static int obtenerConfiguracionInt(string parametro)
        {
            return (int)(Configuraciones[parametro].valor);
        }

        public static string obtenerConfiguracionString(string parametro)
        {
            return (string)(Configuraciones[parametro].valor);
        }

        public static System.Drawing.Color obtenerConfiguracionColor(string parametro)
        {
            return (System.Drawing.Color)(Configuraciones[parametro].valor);
        }

        public static void cargarConfiguraciones(List<Configuracion> listaConf)
        {
            foreach (Configuracion configuracion in listaConf)
            {
                switch (configuracion.tipoValor)
                {
                    case "Color":
                        Configuraciones.Add(configuracion.nombreParametro, new Valor(configuracion.tipoValor, System.Drawing.ColorTranslator.FromHtml(configuracion.valor)));
                        break;
                    case "Entero":
                        Configuraciones.Add(configuracion.nombreParametro, new Valor(configuracion.tipoValor, int.Parse(configuracion.valor)));
                        break;
                }
            }
        }

        public static void iniciarSesion(Usuario usuario)
        {
            usuarioSesion.nombre = usuario.nombre;
            usuarioSesion.nombre = usuario.login;
            usuarioSesion.idUsuario = usuario.idUsuario;
            usuarioSesion.idRol = usuario.idRol;
        }

        public class Valor
        {
            public string tipoValor { get; set; }
            public Object valor { get; set; }
            
            public Valor(string tipoValor, Object valor)
            {
                this.tipoValor = tipoValor;
                this.valor = valor;
            }
        }

    }
    public class Configuracion
    {
        public int idConfiguracion { get; set; }
        public string nombreParametro { get; set; }
        public string valor { get; set; }
        public string descripcion { get; set; }
        public string empresa { get; set; }
        public string tipoParametro { get; set; }
            public string tipoValor { get; set; }

            public Configuracion(int idConfiguracion = 0, string nombreParametro="", string valor="",string descripcion="", string empresa="", string tipoParametro="", string tipoValor="")
        {
            this.idConfiguracion = idConfiguracion;
            this.nombreParametro = nombreParametro;
            this.valor = valor;
            this.descripcion = descripcion;
            this.empresa = empresa;
            this.tipoParametro = tipoParametro;
                this.tipoValor = tipoValor;
        }

        public static List<UIElements.CampoEstructura> camposBusqueda()
        {
            List<UIElements.CampoEstructura> campos = new List<UIElements.CampoEstructura>();
            //campos.Add(new UIElements.campoBusqueda("Parámetro", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Empresa", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));
            //campos.Add(new UIElements.campoBusqueda("Tipo de parámetro", 150, UIElements.campoBusqueda.TipoCampo.COMBO_BOX));

            return campos;
        }


    }
}
