using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ly_modelo;
using ly_negocio;

namespace Sistema_control
{
    public partial class frmPagar : Form
    {
        Orden orden = null;
        double totalAPagar = 0;
        public frmPagar(Orden orden,double total)
        {
            InitializeComponent();

            btnAceptarPagar.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnCancelarPagar.BackColor = Sistema.obtenerConfiguracionColor("color_texto_boton_cancelar");

            this.orden = orden;
            lblFolio.Text = orden.orden;
            this.totalAPagar = total;

            lblTotalAPagar.Text = total.ToString();
            this.StartPosition = FormStartPosition.CenterParent;

            panSuperiorPagar.BackColor = Sistema.obtenerConfiguracionColor("color_barra_superior");
            panSuperiorPagar.ForeColor= Sistema.obtenerConfiguracionColor("color_texto_barra_superior");

            btnCerrarPagar.ForeColor= Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            btnCerrarPagar.IconColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {

        }

        private void txtMontoRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void calcularCambio()
        {
            try
            {
                double recibido = double.Parse(txtMontoRecibido.Text);

                double cambio = recibido - totalAPagar;

                if (cambio >= 0)
                {
                    lblCambio.Text = cambio.ToString();
                }
            }
            catch (Exception)
            {
                lblCambio.Text = "0.00";
            }

        }

        private void btnAceptarPagar_Click(object sender, EventArgs e)
        {
            if (neg_Ordenes.ordenPagada(orden))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al pagar la orden");
            }
        }

        private void btnCancelarPagar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCerrarPagar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            calcularCambio();
        }
    }
}
