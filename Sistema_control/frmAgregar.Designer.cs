
namespace Sistema_control
{
    partial class frmAgregar
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
            this.panSuperiorAgregar = new System.Windows.Forms.Panel();
            this.lblTituloAgregar = new System.Windows.Forms.Label();
            this.iconVentana = new FontAwesome.Sharp.IconPictureBox();
            this.iconSalir = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconSalirAgregar = new FontAwesome.Sharp.IconPictureBox();
            this.panPrincipalAgregar = new System.Windows.Forms.Panel();
            this.panControlesAgregar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panBotonesAgregar = new System.Windows.Forms.Panel();
            this.btnCancelar = new Sistema_control.StlButton();
            this.btnAceptarAgregar = new Sistema_control.StlButton();
            this.panSuperiorAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalirAgregar)).BeginInit();
            this.panPrincipalAgregar.SuspendLayout();
            this.panBotonesAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSuperiorAgregar
            // 
            this.panSuperiorAgregar.Controls.Add(this.lblTituloAgregar);
            this.panSuperiorAgregar.Controls.Add(this.iconVentana);
            this.panSuperiorAgregar.Controls.Add(this.iconSalir);
            this.panSuperiorAgregar.Controls.Add(this.iconMinimizar);
            this.panSuperiorAgregar.Controls.Add(this.iconMaximizar);
            this.panSuperiorAgregar.Controls.Add(this.iconSalirAgregar);
            this.panSuperiorAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperiorAgregar.Location = new System.Drawing.Point(0, 0);
            this.panSuperiorAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panSuperiorAgregar.Name = "panSuperiorAgregar";
            this.panSuperiorAgregar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panSuperiorAgregar.Size = new System.Drawing.Size(400, 30);
            this.panSuperiorAgregar.TabIndex = 5;
            this.panSuperiorAgregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panSuperiorAgregar_MouseDown);
            // 
            // lblTituloAgregar
            // 
            this.lblTituloAgregar.AutoSize = true;
            this.lblTituloAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloAgregar.Location = new System.Drawing.Point(12, 9);
            this.lblTituloAgregar.Name = "lblTituloAgregar";
            this.lblTituloAgregar.Size = new System.Drawing.Size(44, 19);
            this.lblTituloAgregar.TabIndex = 8;
            this.lblTituloAgregar.Text = "titulo";
            // 
            // iconVentana
            // 
            this.iconVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconVentana.BackColor = System.Drawing.SystemColors.Control;
            this.iconVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconVentana.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconVentana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconVentana.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.iconVentana.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconVentana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentana.IconSize = 25;
            this.iconVentana.Location = new System.Drawing.Point(1440, 10);
            this.iconVentana.Name = "iconVentana";
            this.iconVentana.Rotation = 90D;
            this.iconVentana.Size = new System.Drawing.Size(25, 25);
            this.iconVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconVentana.TabIndex = 5;
            this.iconVentana.TabStop = false;
            this.iconVentana.Visible = false;
            // 
            // iconSalir
            // 
            this.iconSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconSalir.BackColor = System.Drawing.SystemColors.Control;
            this.iconSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSalir.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconSalir.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSalir.IconSize = 25;
            this.iconSalir.Location = new System.Drawing.Point(1471, 10);
            this.iconSalir.Name = "iconSalir";
            this.iconSalir.Rotation = 45D;
            this.iconSalir.Size = new System.Drawing.Size(25, 25);
            this.iconSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSalir.TabIndex = 4;
            this.iconSalir.TabStop = false;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.BackColor = System.Drawing.SystemColors.Control;
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMinimizar.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconMinimizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimizar.IconSize = 25;
            this.iconMinimizar.Location = new System.Drawing.Point(1409, 10);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.BackColor = System.Drawing.SystemColors.Control;
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconMaximizar.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.iconMaximizar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMaximizar.IconSize = 25;
            this.iconMaximizar.Location = new System.Drawing.Point(1440, 10);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            // 
            // iconSalirAgregar
            // 
            this.iconSalirAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.iconSalirAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSalirAgregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconSalirAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconSalirAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconSalirAgregar.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconSalirAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSalirAgregar.IconSize = 25;
            this.iconSalirAgregar.Location = new System.Drawing.Point(375, 5);
            this.iconSalirAgregar.Name = "iconSalirAgregar";
            this.iconSalirAgregar.Rotation = 45D;
            this.iconSalirAgregar.Size = new System.Drawing.Size(25, 25);
            this.iconSalirAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSalirAgregar.TabIndex = 7;
            this.iconSalirAgregar.TabStop = false;
            this.iconSalirAgregar.Click += new System.EventHandler(this.iconSalirAgregar_Click);
            // 
            // panPrincipalAgregar
            // 
            this.panPrincipalAgregar.Controls.Add(this.panControlesAgregar);
            this.panPrincipalAgregar.Controls.Add(this.label1);
            this.panPrincipalAgregar.Controls.Add(this.panBotonesAgregar);
            this.panPrincipalAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipalAgregar.Location = new System.Drawing.Point(0, 30);
            this.panPrincipalAgregar.Name = "panPrincipalAgregar";
            this.panPrincipalAgregar.Padding = new System.Windows.Forms.Padding(5);
            this.panPrincipalAgregar.Size = new System.Drawing.Size(400, 142);
            this.panPrincipalAgregar.TabIndex = 6;
            // 
            // panControlesAgregar
            // 
            this.panControlesAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.panControlesAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControlesAgregar.Location = new System.Drawing.Point(5, 5);
            this.panControlesAgregar.Name = "panControlesAgregar";
            this.panControlesAgregar.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panControlesAgregar.Size = new System.Drawing.Size(390, 78);
            this.panControlesAgregar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // panBotonesAgregar
            // 
            this.panBotonesAgregar.Controls.Add(this.btnCancelar);
            this.panBotonesAgregar.Controls.Add(this.btnAceptarAgregar);
            this.panBotonesAgregar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBotonesAgregar.Location = new System.Drawing.Point(5, 83);
            this.panBotonesAgregar.Name = "panBotonesAgregar";
            this.panBotonesAgregar.Size = new System.Drawing.Size(390, 54);
            this.panBotonesAgregar.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(12, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarAgregar
            // 
            this.btnAceptarAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptarAgregar.BackColor = System.Drawing.Color.Gray;
            this.btnAceptarAgregar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnAceptarAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptarAgregar.BorderRadius = 20;
            this.btnAceptarAgregar.BorderSize = 0;
            this.btnAceptarAgregar.FlatAppearance.BorderSize = 0;
            this.btnAceptarAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAceptarAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAceptarAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAceptarAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptarAgregar.Location = new System.Drawing.Point(228, 6);
            this.btnAceptarAgregar.Name = "btnAceptarAgregar";
            this.btnAceptarAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAceptarAgregar.TabIndex = 0;
            this.btnAceptarAgregar.Text = "Aceptar";
            this.btnAceptarAgregar.TextColor = System.Drawing.Color.White;
            this.btnAceptarAgregar.UseVisualStyleBackColor = false;
            this.btnAceptarAgregar.Click += new System.EventHandler(this.btnAceptarAgregar_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 172);
            this.Controls.Add(this.panPrincipalAgregar);
            this.Controls.Add(this.panSuperiorAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregar";
            this.Text = "frmAgregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.panSuperiorAgregar.ResumeLayout(false);
            this.panSuperiorAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalirAgregar)).EndInit();
            this.panPrincipalAgregar.ResumeLayout(false);
            this.panPrincipalAgregar.PerformLayout();
            this.panBotonesAgregar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperiorAgregar;
        private FontAwesome.Sharp.IconPictureBox iconVentana;
        private FontAwesome.Sharp.IconPictureBox iconSalir;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
        private System.Windows.Forms.Panel panPrincipalAgregar;
        private FontAwesome.Sharp.IconPictureBox iconSalirAgregar;
        private System.Windows.Forms.Panel panBotonesAgregar;
        private StlButton btnCancelar;
        private StlButton btnAceptarAgregar;
        private System.Windows.Forms.FlowLayoutPanel panControlesAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloAgregar;
    }
}