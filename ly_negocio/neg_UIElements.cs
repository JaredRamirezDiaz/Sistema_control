using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;
using System.Text.Json;
using System.Linq;
namespace ly_negocio
{
    public class neg_UIElements
    {
      

        public static List<UIElements> obtenerElementosLayout(string nombreCatalogo,int tipoElemento = 0, string fuenteDeDatos = "")
        {
            return dat_UIElements.obtenerElementosLayout(nombreCatalogo,tipoElemento,fuenteDeDatos);
        }

        public static List<UIElements.CampoEstructura> obtenerEstructura(string nombreCatalogo)
        {
            return dat_UIElements.obtenerEstructura(nombreCatalogo);
        }

        public static List<Producto> obtenerProductos()
        {
            Dictionary<string, string> info = dat_UIElements.obtenerElementos("Productos");
            List<UIElements.CampoEstructura> columnas = JsonSerializer.Deserialize<List<UIElements.CampoEstructura>>(info["estructura"]);
            List<string[]> elementos = (info["elementos"] != String.Empty) ? JsonSerializer.Deserialize<List<string[]>>(info["elementos"]) : new List<string[]>();

            List<Producto> listaProductos = new List<Producto>();

            string[] tiposValidos = {"PK","FK","N/A"};
            List<int> indicesValidos = new List<int>();

            for (int i = 0; i < columnas.Count; i++)
            {
                if (Array.Exists(tiposValidos,x=>x==columnas[i].tipoColumna))
                {
                    indicesValidos.Add(i);
                }
            }

            foreach (string[] elemento in elementos)
            {
                listaProductos.Add(new Producto(elemento.Where((source, index) => indicesValidos.Exists(valor => valor==index)).ToArray()));
            }

            return listaProductos;
        }

       

        //public static List<UIElements.AtributoEstructura> obtenerAtributos(string Catalogo)
        //{
        //    return dat_UIElements.obtenerAtributos(Catalogo);
        //}

    }
}
