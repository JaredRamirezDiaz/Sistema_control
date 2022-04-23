
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
            this.panSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panContenedorPrincipal = new System.Windows.Forms.Panel();
            this.panSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panMenu.Location = new System.Drawing.Point(13, 184);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(350, 859);
            this.panMenu.TabIndex = 0;
            // 
            // panLateralIzq
            // 
            this.panLateralIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateralIzq.Location = new System.Drawing.Point(0, 0);
            this.panLateralIzq.Name = "panLateralIzq";
            this.panLateralIzq.Size = new System.Drawing.Size(363, 1055);
            this.panLateralIzq.TabIndex = 3;
            // 
            // panSuperior
            // 
            this.panSuperior.Controls.Add(this.pictureBox1);
            this.panSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperior.Location = new System.Drawing.Point(363, 0);
            this.panSuperior.Name = "panSuperior";
            this.panSuperior.Size = new System.Drawing.Size(1020, 80);
            this.panSuperior.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Sistema_control.Properties.Resources.bars;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panContenedorPrincipal
            // 
            this.panContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContenedorPrincipal.Location = new System.Drawing.Point(363, 80);
            this.panContenedorPrincipal.Name = "panContenedorPrincipal";
            this.panContenedorPrincipal.Size = new System.Drawing.Size(1020, 975);
            this.panContenedorPrincipal.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 1055);
            this.Controls.Add(this.panContenedorPrincipal);
            this.Controls.Add(this.panSuperior);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panLateralIzq);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panLateralIzq;
        private System.Windows.Forms.Panel panSuperior;
        private System.Windows.Forms.Panel panContenedorPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}