
namespace Sistema_control
{
    partial class frmCatalogo
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
            this.panSuperiorCatalogo = new System.Windows.Forms.Panel();
            this.btnCerrarCatalogo = new FontAwesome.Sharp.IconPictureBox();
            this.panInferiorCatalogo = new System.Windows.Forms.Panel();
            this.panPrincipalCatalogo = new System.Windows.Forms.Panel();
            this.panControlesCatalogo = new System.Windows.Forms.FlowLayoutPanel();
            this.panFlowBusqueda = new System.Windows.Forms.FlowLayoutPanel();
            this.panSuperiorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCatalogo)).BeginInit();
            this.panPrincipalCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSuperiorCatalogo
            // 
            this.panSuperiorCatalogo.BackColor = System.Drawing.SystemColors.Control;
            this.panSuperiorCatalogo.Controls.Add(this.btnCerrarCatalogo);
            this.panSuperiorCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSuperiorCatalogo.Location = new System.Drawing.Point(0, 0);
            this.panSuperiorCatalogo.Name = "panSuperiorCatalogo";
            this.panSuperiorCatalogo.Size = new System.Drawing.Size(1300, 30);
            this.panSuperiorCatalogo.TabIndex = 0;
            // 
            // btnCerrarCatalogo
            // 
            this.btnCerrarCatalogo.BackColor = System.Drawing.SystemColors.Control;
            this.btnCerrarCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCatalogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarCatalogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarCatalogo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCerrarCatalogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarCatalogo.IconSize = 30;
            this.btnCerrarCatalogo.Location = new System.Drawing.Point(1270, 0);
            this.btnCerrarCatalogo.Name = "btnCerrarCatalogo";
            this.btnCerrarCatalogo.Rotation = 45D;
            this.btnCerrarCatalogo.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarCatalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrarCatalogo.TabIndex = 0;
            this.btnCerrarCatalogo.TabStop = false;
            this.btnCerrarCatalogo.Click += new System.EventHandler(this.btnCerrarCatalogo_Click);
            // 
            // panInferiorCatalogo
            // 
            this.panInferiorCatalogo.BackColor = System.Drawing.SystemColors.Control;
            this.panInferiorCatalogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panInferiorCatalogo.Location = new System.Drawing.Point(0, 620);
            this.panInferiorCatalogo.Name = "panInferiorCatalogo";
            this.panInferiorCatalogo.Size = new System.Drawing.Size(1300, 30);
            this.panInferiorCatalogo.TabIndex = 1;
            // 
            // panPrincipalCatalogo
            // 
            this.panPrincipalCatalogo.Controls.Add(this.panControlesCatalogo);
            this.panPrincipalCatalogo.Controls.Add(this.panFlowBusqueda);
            this.panPrincipalCatalogo.Controls.Add(this.panSuperiorCatalogo);
            this.panPrincipalCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPrincipalCatalogo.Location = new System.Drawing.Point(0, 0);
            this.panPrincipalCatalogo.Name = "panPrincipalCatalogo";
            this.panPrincipalCatalogo.Size = new System.Drawing.Size(1300, 620);
            this.panPrincipalCatalogo.TabIndex = 2;
            // 
            // panControlesCatalogo
            // 
            this.panControlesCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControlesCatalogo.Location = new System.Drawing.Point(0, 130);
            this.panControlesCatalogo.Name = "panControlesCatalogo";
            this.panControlesCatalogo.Size = new System.Drawing.Size(1300, 490);
            this.panControlesCatalogo.TabIndex = 1;
            // 
            // panFlowBusqueda
            // 
            this.panFlowBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFlowBusqueda.Location = new System.Drawing.Point(0, 30);
            this.panFlowBusqueda.Name = "panFlowBusqueda";
            this.panFlowBusqueda.Size = new System.Drawing.Size(1300, 100);
            this.panFlowBusqueda.TabIndex = 0;
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panPrincipalCatalogo);
            this.Controls.Add(this.panInferiorCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCatalogo";
            this.Text = "Catalogo";
            this.panSuperiorCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCatalogo)).EndInit();
            this.panPrincipalCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperiorCatalogo;
        private System.Windows.Forms.Panel panInferiorCatalogo;
        private System.Windows.Forms.Panel panPrincipalCatalogo;
        private FontAwesome.Sharp.IconPictureBox btnCerrarCatalogo;
        private System.Windows.Forms.FlowLayoutPanel panFlowBusqueda;
        private System.Windows.Forms.FlowLayoutPanel panControlesCatalogo;
    }
}