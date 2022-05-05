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
            GridView        =   9
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

        public class campoBusqueda : UIElements
        {
            public string etiqueta { get; set; }
            public string jsonStringValores { get; set; }


            public campoBusqueda(string etiqueta, int ancho,int alto, TipoElemento tipoCampo,string jsonStringValores="") : base (tipoCampo,ancho,alto)
            {
                this.etiqueta = etiqueta;
                this.jsonStringValores = jsonStringValores;
            }

            public class CampoComboBox
            {
                public string value{ get; set; }
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
            public List<ColumnaGrid> columnas { get; set; }
            public List<string[]> elementos { get; set; }


            public ElementoLayoutGrid(TipoElemento tipoElemento, int ancho, int alto, List<ColumnaGrid> columnas, List<string[]> elementos) : base(tipoElemento, ancho, alto)
            {
                this.columnas = columnas;
                this.elementos = elementos;
            }

            public ElementoLayoutGrid(TipoElemento tipoElemento, int ancho, int alto,string columnasJSON, string elementosJSON) : base(tipoElemento, ancho, alto)
            {
                this.columnas = JsonSerializer.Deserialize<List<ColumnaGrid>>(columnasJSON);
                this.elementos = JsonSerializer.Deserialize<List<string[]>>(elementosJSON);
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

            public class ColumnaGrid
            {
                public string columna { get; set; }
                public bool buscable { get; set; }
                public bool visible { get; set; }
                public bool clavePrimaria { get; set; }
                public string tipoColumna { get; set; }

                public ColumnaGrid(string columna,bool buscable, bool visible, bool clavePrimaria, string tipoColumna)
                {
                    this.columna = columna;
                    this.buscable = buscable;
                    this.visible = visible;
                    this.clavePrimaria = clavePrimaria;
                    this.tipoColumna = tipoColumna;
                }
                public ColumnaGrid() { }
            }
        }
}
