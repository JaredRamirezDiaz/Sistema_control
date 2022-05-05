using System;
using System.Collections.Generic;
using System.Text;
using ly_modelo;
using ly_datos;


namespace ly_negocio
{
    public class neg_UIElements
    {
        public static List<UIElements.campoBusqueda> obtenerCamposDeBusqueda(string nombreCatalogo)
        {
            return dat_UIElements.obtenerCamposDeBusqueda(nombreCatalogo);
        }

        public static List<UIElements> obtenerElementosLayout(string nombreCatalogo)
        {
            return dat_UIElements.obtenerElementosLayout(nombreCatalogo);
        }

    }
}
