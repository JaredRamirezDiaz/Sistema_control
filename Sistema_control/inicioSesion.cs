using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ly_negocio;
using ly_modelo;

namespace Sistema_control
{
    public partial class inicioSesion : Form
    {
        public inicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length>0 && txtPassword.Text.Length>0)
            {
                Usuario usuarioSesion = neg_Usuario.iniciarSesion(txtUsuario.Text, txtPassword.Text);
                if (usuarioSesion != null)
                {
                    Sistema.iniciarSesion(usuarioSesion);
                    frmPrincipal nuevoForm = new frmPrincipal();
                    nuevoForm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Por favor llena los campos");
            }
            
        }

        private void iconSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                if (txtUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
                {
                    Usuario usuarioSesion = neg_Usuario.iniciarSesion(txtUsuario.Text, txtPassword.Text);
                    if (usuarioSesion != null)
                    {
                        Sistema.iniciarSesion(usuarioSesion);
                        frmPrincipal nuevoForm = new frmPrincipal();
                        nuevoForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llena los campos");
                }

            }
        }
    }
}
