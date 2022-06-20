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
        public bool activo { get; set; }
        public int idRol { get; set; }

        public Usuario(int idUsuario, string nombre, string login, bool activo, int idRol, string password = "")
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.login = login;
            this.password = password;
            this.activo = activo;
            this.idRol = idRol;
        }

        public Usuario() { }

    }
}
