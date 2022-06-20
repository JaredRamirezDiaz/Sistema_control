
namespace Sistema_control
{
    partial class frmPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarPagar = new Sistema_control.StlButton();
            this.btnAceptarPagar = new Sistema_control.StlButton();
            this.panSuperiorPagar = new System.Windows.Forms.Panel();
            this.btnCerrarPagar = new FontAwesome.Sharp.IconPictureBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAPagarTexto = new System.Windows.Forms.Label();
            this.txtMontoRecibido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panSuperiorPagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarPagar);
            this.panel1.Controls.Add(this.btnAceptarPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelarPagar
            // 
            this.btnCancelarPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarPagar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarPagar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCancelarPagar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarPagar.BorderRadius = 20;
            this.btnCancelarPagar.BorderSize = 0;
            this.btnCancelarPagar.FlatAppearance.BorderSize = 0;
            this.btnCancelarPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPagar.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPagar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarPagar.IconColor = System.Drawing.Color.Black;
            this.btnCancelarPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarPagar.Location = new System.Drawing.Point(12, 4);
            this.btnCancelarPagar.Name = "btnCancelarPagar";
            this.btnCancelarPagar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelarPagar.TabIndex = 3;
            this.btnCancelarPagar.Text = "Cancelar";
            this.btnCancelarPagar.TextColor = System.Drawing.Color.White;
            this.btnCancelarPagar.UseVisualStyleBackColor = false;
            this.btnCancelarPagar.Click += new System.EventHandler(this.btnCancelarPagar_Click);
            // 
            // btnAceptarPagar
            // 
            this.btnAceptarPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarPagar.BackColor = System.Drawing.Color.Gray;
            this.btnAceptarPagar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnAceptarPagar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptarPagar.BorderRadius = 20;
            this.btnAceptarPagar.BorderSize = 0;
            this.btnAceptarPagar.FlatAppearance.BorderSize = 0;
            this.btnAceptarPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPagar.ForeColor = System.Drawing.Color.White;
            this.btnAceptarPagar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarPagar.IconColor = System.Drawing.Color.Black;
            this.btnAceptarPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarPagar.Location = new System.Drawing.Point(190, 4);
            this.btnAceptarPagar.Name = "btnAceptarPagar";
            this.btnAceptarPagar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptarPagar.TabIndex = 2;
            this.btnAceptarPagar.Text = "Aceptar";
            this.btnAceptarPagar.TextColor = System.Drawing.Color.White;
            this.btnAceptarPagar.UseVisualStyleBackColor = false;
            this.btnAceptarPagar.Click += new System.EventHandler(this.btnAceptarPagar_Click);
            // 
            // panSuperiorPagar
            // 
            this.panSuperiorPagar.Controls.Add(this.btnCerrarPagar);
            this.panSuperiorPagar.Controls.Add(this.lblFolio);
            this.panSuperiorPagar.Controls.Add(this.label1);
            this.panSuperiorPagar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperiorPagar.Location = new System.Drawing.Point(0, 0);
            this.panSuperiorPagar.Name = "panSuperiorPagar";
            this.panSuperiorPagar.Size = new System.Drawing.Size(352, 29);
            this.panSuperiorPagar.TabIndex = 1;
            // 
            // btnCerrarPagar
            // 
            this.btnCerrarPagar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrarPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPagar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarPagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarPagar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCerrarPagar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPagar.IconSize = 29;
            this.btnCerrarPagar.Location = new System.Drawing.Point(322, 0);
            this.btnCerrarPagar.Name = "btnCerrarPagar";
            this.btnCerrarPagar.Rotation = 45D;
            this.btnCerrarPagar.Size = new System.Drawing.Size(30, 29);
            this.btnCerrarPagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrarPagar.TabIndex = 2;
            this.btnCerrarPagar.TabStop = false;
            this.btnCerrarPagar.Click += new System.EventHandler(this.btnCerrarPagar_Click);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFolio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFolio.Location = new System.Drawing.Point(83, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(82, 21);
            this.lblFolio.TabIndex = 1;
            this.lblFolio.Text = "00000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Folio:";
            // 
            // lblTotalAPagarTexto
            // 
            this.lblTotalAPagarTexto.AutoSize = true;
            this.lblTotalAPagarTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAPagarTexto.Location = new System.Drawing.Point(12, 51);
            this.lblTotalAPagarTexto.Name = "lblTotalAPagarTexto";
            this.lblTotalAPagarTexto.Size = new System.Drawing.Size(101, 21);
            this.lblTotalAPagarTexto.TabIndex = 2;
            this.lblTotalAPagarTexto.Text = "Total a pagar:";
            // 
            // txtMontoRecibido
            // 
            this.txtMontoRecibido.Location = new System.Drawing.Point(137, 133);
            this.txtMontoRecibido.Name = "txtMontoRecibido";
            this.txtMontoRecibido.Size = new System.Drawing.Size(195, 23);
            this.txtMontoRecibido.TabIndex = 4;
            this.txtMontoRecibido.TextChanged += new System.EventHandler(this.txtMontoRecibido_TextChanged);
            this.txtMontoRecibido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoRecibido_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto recibido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cambio:";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCambio.Location = new System.Drawing.Point(94, 165);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(46, 25);
            this.lblCambio.TabIndex = 7;
            this.lblCambio.Text = "0.00";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAPagar.Location = new System.Drawing.Point(119, 51);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(41, 21);
            this.lblTotalAPagar.TabIndex = 9;
            this.lblTotalAPagar.Text = "0.00";
            // 
            // frmPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 254);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMontoRecibido);
            this.Controls.Add(this.lblTotalAPagarTexto);
            this.Controls.Add(this.panSuperiorPagar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPagar";
            this.Text = "frmPagar";
            this.Load += new System.EventHandler(this.frmPagar_Load);
            this.panel1.ResumeLayout(false);
            this.panSuperiorPagar.ResumeLayout(false);
            this.panSuperiorPagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private StlButton btnCancelarPagar;
        private StlButton btnAceptarPagar;
        private System.Windows.Forms.Panel panSuperiorPagar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAPagarTexto;
        private System.Windows.Forms.TextBox txtMontoRecibido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblTotalAPagar;
        private FontAwesome.Sharp.IconPictureBox btnCerrarPagar;
    }
}