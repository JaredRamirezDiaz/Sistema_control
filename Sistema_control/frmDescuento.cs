using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_control
{
    public partial class frmDescuento : Form
    {

        public decimal descuento = 0;
        public frmDescuento()
        {
            InitializeComponent();
        }

        private void frmDescuento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                if (txtDescuento.Value > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.descuento = txtDescuento.Value;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else if ((int)e.KeyCode == (int)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void frmDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                if (txtDescuento.Value>0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.descuento = txtDescuento.Value;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else if ((int)e.KeyCode == (int)Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void frmDescuento_Load(object sender, EventArgs e)
        {

        }
    }
}
