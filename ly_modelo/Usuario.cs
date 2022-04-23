using System;
using System.Collections.Generic;
using System.Text;

namespace ly_modelo
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int estatus { get; set; }
        public int idRol { get; set; }

        public Usuario(int idUsuario, string nombre, string login, int estatus, int idRol, string password = "")
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.login = login;
            this.password = password;
            this.estatus = estatus;
            this.idRol = idRol;
        }

    }
}
