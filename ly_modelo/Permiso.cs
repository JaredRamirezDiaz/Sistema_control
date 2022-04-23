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

    }
}
