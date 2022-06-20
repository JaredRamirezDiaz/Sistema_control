using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace ly_modelo
{
    public class UIElements
    {
        public enum TipoElemento
        {
            TextBox         =   1,
            ComboBox        =   2,
            CheckBox        =   3,
            Numero          =   4,
            NumeroRango     =   5,
            Fecha           =   6,
            FechaRango      =   7,
            NumeroUpDown    =   8,
            GridView        =   9,
            CardVistaPrevia =   10,
            BotonAgregar    =   11,
            BotonBuscar     =   12
        }

        public TipoElemento tipoElemento { get; set; }
        public int ancho { get; set; }
        public int alto { get; set; }
        



        public UIElements(TipoElemento tipoElemento, int ancho, int alto)
        {
            this.tipoElemento = tipoElemento;
            this.ancho = ancho;
            this.alto = alto;
        }

        //public class campoBusqueda : UIElements
        //{
        //    public string etiqueta { get; set; }
        //    public string jsonStringValores { get; set; }
        //    public string campo { get; set; }
        //    public bool Principal { get; set; }


        //    public campoBusqueda(string etiqueta, int ancho,int alto, TipoElemento tipoCampo,string campo, bool principal,string jsonStringValores="") : base (tipoCampo,ancho,alto)
        //    {
        //        this.etiqueta = etiqueta;
        //        this.campo = campo;
        //        this.Principal = principal;
        //        this.jsonStringValores = jsonStringValores;
        //    }

        //    public class CampoComboBox
        //    {
        //        public string value{ get; set; }
        //        public string text { get; set; }

        //        public CampoComboBox() { }
        //        public CampoComboBox(string value, string text)
        //        {
        //            this.value = value;
        //            this.text = text;
        //        }
        //    }

        //}

        public class CampoEstructura
        {
            public CampoEstructura(string columna, int ancho, int alto, TipoElemento tipoElemento, string jsonElementos, string etiqueta, bool principal, bool buscable, bool visible, bool clavePrimaria, int posicion, string tipoColumna, string reference, string valor, bool requerido, int longitudMaxima,string tipoDato)
            {
                this.columna = columna;
                this.ancho = ancho;
                this.alto = alto;
                this.tipoElemento = tipoElemento;
                this.jsonElementos = jsonElementos;
                this.etiqueta = etiqueta;
                this.principal = principal;
                this.buscable = buscable;
                this.visible = visible;
                this.clavePrimaria = clavePrimaria;
                this.posicion = posicion;
                this.tipoColumna = tipoColumna;
                this.reference = reference;
                this.valor = valor;
                this.requerido = requerido;
                this.longitudMaxima = longitudMaxima;
                this.tipoDato = tipoDato;
                
            }

            public CampoEstructura() { }

            public string columna { get; set; }
            public int ancho { get; set; }
            public int alto { get; set; }
            public TipoElemento tipoElemento { get; set; }
            public string jsonElementos { get; set; }
            public string etiqueta { get; set; }
            public bool principal { get; set; }
            public bool buscable { get; set; }
            public bool visible { get; set; }
            public bool clavePrimaria { get; set; }
            public int posicion { get; set; }
            public string tipoColumna { get; set; }
            public string reference { get; set; }
            public string valor { get; set; }
            public bool requerido { get; set; }
            public int longitudMaxima { get; set; }
            public string tipoDato { get; set; }
            

            public class CampoComboBox
            {
                public string value { get; set; }
                public string text { get; set; }

                public CampoComboBox() { }
                public CampoComboBox(string value, string text)
                {
                    this.value = value;
                    this.text = text;
                }
            }

        }

    }
    public class ElementoLayoutGrid : UIElements
    {
        public List<UIElements.CampoEstructura> columnas { get; set; }
        public List<string[]> elementos { get; set; }
        public string dock { get; set; }
        public string fuenteDeDatos{ get; set; }


        //public ElementoLayoutGrid(TipoElemento tipoElemento, int ancho, int alto, List<ColumnaGrid> columnas, List<string[]> elementos,string dock) : base(tipoElemento, ancho, alto)
        //{
        //    this.columnas = columnas;
        //    this.elementos = elementos;
        //    this.dock = dock;
        //}

        public ElementoLayoutGrid(TipoElemento tipoElemento, int ancho, int alto,string columnasJSON, string elementosJSON, string dock, string fuenteDeDatos) : base(tipoElemento, ancho, alto)
        {
            this.columnas = JsonSerializer.Deserialize<List<UIElements.CampoEstructura>>(columnasJSON);
            this.elementos=(elementosJSON!=String.Empty)? this.elementos = JsonSerializer.Deserialize<List<string[]>>(elementosJSON):new List<string[]>();
            this.dock = dock;
            this.fuenteDeDatos = fuenteDeDatos;
        }

        public class CeldaGrid{
            public string clave { get; set; }
            public string valor { get; set; }

            public CeldaGrid(string clave, string valor) {
                this.clave = clave;
                this.valor = valor;
            }

            public CeldaGrid() { }

            
        }

        
    }


    
   

    public class ElementoLayoutCardVistaPrevia : UIElements
    {
        public List<UIElements.CampoEstructura> campos { get; set; }
        public string dock { get; set; }
        public string fuenteDeDatos { get; set; }

        //public ElementoLayoutGrid(TipoElemento tipoElemento, int ancho, int alto, List<ColumnaGrid> columnas, List<string[]> elementos,string dock) : base(tipoElemento, ancho, alto)
        //{
        //    this.columnas = columnas;
        //    this.elementos = elementos;
        //    this.dock = dock;
        //}

        public ElementoLayoutCardVistaPrevia(TipoElemento tipoElemento, int ancho, int alto, string camposJSON, string dock, string fuenteDeDatos) : base(tipoElemento, ancho, alto)
        {
            this.campos = JsonSerializer.Deserialize<List<UIElements.CampoEstructura>>(camposJSON);
            this.dock = dock;
            this.fuenteDeDatos = fuenteDeDatos;
        }

        

        
    }
}
