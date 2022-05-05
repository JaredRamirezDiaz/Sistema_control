
namespace Sistema_control
{
    partial class frmPrincipal
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.panLateralIzq = new System.Windows.Forms.Panel();
            this.panLateralInferior = new System.Windows.Forms.Panel();
            this.panLateralSuperior = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panSuperior = new System.Windows.Forms.Panel();
            this.iconVentana = new FontAwesome.Sharp.IconPictureBox();
            this.iconSalir = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.iconColapsarMenu = new FontAwesome.Sharp.IconPictureBox();
            this.panContenedorPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panPrincipalVentana = new System.Windows.Forms.Panel();
            this.panSuperiorOpciones = new System.Windows.Forms.Panel();
            this.panLateralIzq.SuspendLayout();
            this.panLateralSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconColapsarMenu)).BeginInit();
            this.panContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panPrincipalVentana.SuspendLayout();
            this.panSuperiorOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMenu.Location = new System.Drawing.Point(0, 105);
            this.panMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(318, 510);
            this.panMenu.TabIndex = 0;
            this.panMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panMenu_Paint);
            // 
            // panLateralIzq
            // 
            this.panLateralIzq.Controls.Add(this.panLateralInferior);
            this.panLateralIzq.Controls.Add(this.panMenu);
            this.panLateralIzq.Controls.Add(this.panLateralSuperior);
            this.panLateralIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateralIzq.Location = new System.Drawing.Point(0, 30);
            this.panLateralIzq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panLateralIzq.Name = "panLateralIzq";
            this.panLateralIzq.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panLateralIzq.Size = new System.Drawing.Size(318, 620);
            this.panLateralIzq.TabIndex = 3;
            // 
            // panLateralInferior
            // 
            this.panLateralInferior.Location = new System.Drawing.Point(0, 515);
            this.panLateralInferior.Name = "panLateralInferior";
            this.panLateralInferior.Size = new System.Drawing.Size(318, 100);
            this.panLateralInferior.TabIndex = 1;
            // 
            // panLateralSuperior
            // 
            this.panLateralSuperior.Controls.Add(this.pictureBox2);
            this.panLateralSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panLateralSuperior.Location = new System.Drawing.Point(0, 5);
            this.panLateralSuperior.Name = "panLateralSuperior";
            this.panLateralSuperior.Padding = new System.Windows.Forms.Padding(5);
            this.panLateralSuperior.Size = new System.Drawing.Size(318, 100);
            this.panLateralSuperior.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Sistema_control.Properties.Resources.Recurso_11_3x;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(308, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panSuperior
            // 
            this.panSuperior.Controls.Add(this.iconVentana);
            this.panSuperior.Controls.Add(this.iconSalir);
            this.panSuperior.Controls.Add(this.iconMinimizar);
            this.panSuperior.Controls.Add(this.iconMaximizar);
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(0, 0);
            this.panSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panSuperior.Size = new System.Drawing.Size(1300, 30);
            this.panSuperior.TabIndex = 4;
            this.panSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panSuperior_MouseDown);
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
            this.iconVentana.Location = new System.Drawing.Point(1240, 5);
            this.iconVentana.Name = "iconVentana";
            this.iconVentana.Rotation = 90D;
            this.iconVentana.Size = new System.Drawing.Size(25, 25);
            this.iconVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconVentana.TabIndex = 5;
            this.iconVentana.TabStop = false;
            this.iconVentana.Visible = false;
            this.iconVentana.Click += new System.EventHandler(this.iconVentana_Click);
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
            this.iconSalir.Location = new System.Drawing.Point(1271, 5);
            this.iconSalir.Name = "iconSalir";
            this.iconSalir.Rotation = 45D;
            this.iconSalir.Size = new System.Drawing.Size(25, 25);
            this.iconSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconSalir.TabIndex = 4;
            this.iconSalir.TabStop = false;
            this.iconSalir.Click += new System.EventHandler(this.iconPictureBox4_Click);
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
            this.iconMinimizar.Location = new System.Drawing.Point(1209, 5);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(25, 25);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
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
            this.iconMaximizar.Location = new System.Drawing.Point(1240, 5);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(25, 25);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconColapsarMenu
            // 
            this.iconColapsarMenu.BackColor = System.Drawing.SystemColors.Control;
            this.iconColapsarMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconColapsarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconColapsarMenu.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconColapsarMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconColapsarMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconColapsarMenu.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconColapsarMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconColapsarMenu.IconSize = 30;
            this.iconColapsarMenu.Location = new System.Drawing.Point(0, 0);
            this.iconColapsarMenu.Name = "iconColapsarMenu";
            this.iconColapsarMenu.Rotation = 180D;
            this.iconColapsarMenu.Size = new System.Drawing.Size(30, 30);
            this.iconColapsarMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconColapsarMenu.TabIndex = 1;
            this.iconColapsarMenu.TabStop = false;
            this.iconColapsarMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panContenedorPrincipal
            // 
            this.panContenedorPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.panContenedorPrincipal.Controls.Add(this.pictureBox1);
            this.panContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedorPrincipal.Location = new System.Drawing.Point(318, 60);
            this.panContenedorPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panContenedorPrincipal.Name = "panContenedorPrincipal";
            this.panContenedorPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.panContenedorPrincipal.Size = new System.Drawing.Size(982, 590);
            this.panContenedorPrincipal.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Sistema_control.Properties.Resources.Recurso_2_3x;
            this.pictureBox1.Location = new System.Drawing.Point(283, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panPrincipalVentana
            // 
            this.panPrincipalVentana.Controls.Add(this.panContenedorPrincipal);
            this.panPrincipalVentana.Controls.Add(this.panSuperiorOpciones);
            this.panPrincipalVentana.Controls.Add(this.panLateralIzq);
            this.panPrincipalVentana.Controls.Add(this.panSuperior);
            this.panPrincipalVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipalVentana.Location = new System.Drawing.Point(0, 0);
            this.panPrincipalVentana.Name = "panPrincipalVentana";
            this.panPrincipalVentana.Size = new System.Drawing.Size(1300, 650);
            this.panPrincipalVentana.TabIndex = 6;
            // 
            // panSuperiorOpciones
            // 
            this.panSuperiorOpciones.Controls.Add(this.iconColapsarMenu);
            this.panSuperiorOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperiorOpciones.Location = new System.Drawing.Point(318, 30);
            this.panSuperiorOpciones.Name = "panSuperiorOpciones";
            this.panSuperiorOpciones.Size = new System.Drawing.Size(982, 30);
            this.panSuperiorOpciones.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panPrincipalVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panLateralIzq.ResumeLayout(false);
            this.panLateralSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconColapsarMenu)).EndInit();
            this.panContenedorPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panPrincipalVentana.ResumeLayout(false);
            this.panSuperiorOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panLateralIzq;
        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Panel panLateralSuperior;
        private System.Windows.Forms.Panel panLateralInferior;
        private System.Windows.Forms.Panel panContenedorPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconColapsarMenu;
        private FontAwesome.Sharp.IconPictureBox iconSalir;
        private FontAwesome.Sharp.IconPictureBox iconMinimizar;
        private FontAwesome.Sharp.IconPictureBox iconMaximizar;
        private FontAwesome.Sharp.IconPictureBox iconVentana;
        private System.Windows.Forms.Panel panPrincipalVentana;
        private System.Windows.Forms.Panel panSuperiorOpciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}