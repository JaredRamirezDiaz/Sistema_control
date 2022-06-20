
namespace Sistema_control
{
    partial class frmPuntoDeVenta
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
            this.panControlesPuntoVenta = new System.Windows.Forms.Panel();
            this.panPuntoVentaGrid = new System.Windows.Forms.Panel();
            this.dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCatalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubTotalCompra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescuentoCompra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.panBotonesPuntoVenta = new System.Windows.Forms.Panel();
            this.btnDescuento = new Sistema_control.StlButton();
            this.btnEliminarArticulo = new Sistema_control.StlButton();
            this.panBusquedaPuntoVenta = new System.Windows.Forms.Panel();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.panInferiorCatalogo = new System.Windows.Forms.Panel();
            this.btnCancelarCompra = new Sistema_control.StlButton();
            this.btnPagar = new Sistema_control.StlButton();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panSuperiorCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCatalogo)).BeginInit();
            this.panControlesPuntoVenta.SuspendLayout();
            this.panPuntoVentaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panBotonesPuntoVenta.SuspendLayout();
            this.panBusquedaPuntoVenta.SuspendLayout();
            this.panInferiorCatalogo.SuspendLayout();
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
            this.panSuperiorCatalogo.TabIndex = 1;
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
            // panControlesPuntoVenta
            // 
            this.panControlesPuntoVenta.Controls.Add(this.panPuntoVentaGrid);
            this.panControlesPuntoVenta.Controls.Add(this.panInferiorCatalogo);
            this.panControlesPuntoVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControlesPuntoVenta.Location = new System.Drawing.Point(0, 30);
            this.panControlesPuntoVenta.Name = "panControlesPuntoVenta";
            this.panControlesPuntoVenta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panControlesPuntoVenta.Size = new System.Drawing.Size(1300, 570);
            this.panControlesPuntoVenta.TabIndex = 2;
            // 
            // panPuntoVentaGrid
            // 
            this.panPuntoVentaGrid.Controls.Add(this.dgv_Articulos);
            this.panPuntoVentaGrid.Controls.Add(this.panel3);
            this.panPuntoVentaGrid.Controls.Add(this.panBotonesPuntoVenta);
            this.panPuntoVentaGrid.Controls.Add(this.panBusquedaPuntoVenta);
            this.panPuntoVentaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panPuntoVentaGrid.Location = new System.Drawing.Point(0, 5);
            this.panPuntoVentaGrid.Name = "panPuntoVentaGrid";
            this.panPuntoVentaGrid.Size = new System.Drawing.Size(1300, 523);
            this.panPuntoVentaGrid.TabIndex = 3;
            // 
            // dgv_Articulos
            // 
            this.dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.CodigoProducto,
            this.NombreProducto,
            this.PrecioCatalogo,
            this.PrecioVenta,
            this.Cantidad,
            this.Total,
            this.Estatus});
            this.dgv_Articulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Articulos.Location = new System.Drawing.Point(0, 31);
            this.dgv_Articulos.Name = "dgv_Articulos";
            this.dgv_Articulos.RowTemplate.Height = 25;
            this.dgv_Articulos.Size = new System.Drawing.Size(1263, 424);
            this.dgv_Articulos.TabIndex = 1;
            this.dgv_Articulos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Articulos_CellValueChanged);
            this.dgv_Articulos.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_Articulos_RowPostPaint);
            this.dgv_Articulos.SelectionChanged += new System.EventHandler(this.dgv_Articulos_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreProducto.HeaderText = "Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // PrecioCatalogo
            // 
            this.PrecioCatalogo.HeaderText = "Precio";
            this.PrecioCatalogo.Name = "PrecioCatalogo";
            this.PrecioCatalogo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblSubTotalCompra);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblDescuentoCompra);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblTotalCompra);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1263, 68);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(836, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subtotal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotalCompra
            // 
            this.lblSubTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSubTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotalCompra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalCompra.Location = new System.Drawing.Point(836, 28);
            this.lblSubTotalCompra.Name = "lblSubTotalCompra";
            this.lblSubTotalCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubTotalCompra.Size = new System.Drawing.Size(135, 34);
            this.lblSubTotalCompra.TabIndex = 7;
            this.lblSubTotalCompra.Text = "0.00";
            this.lblSubTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(977, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descuento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescuentoCompra
            // 
            this.lblDescuentoCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescuentoCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuentoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuentoCompra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescuentoCompra.Location = new System.Drawing.Point(977, 28);
            this.lblDescuentoCompra.Name = "lblDescuentoCompra";
            this.lblDescuentoCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescuentoCompra.Size = new System.Drawing.Size(135, 34);
            this.lblDescuentoCompra.TabIndex = 5;
            this.lblDescuentoCompra.Text = "0.00";
            this.lblDescuentoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1118, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCompra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCompra.Location = new System.Drawing.Point(1118, 28);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalCompra.Size = new System.Drawing.Size(135, 34);
            this.lblTotalCompra.TabIndex = 3;
            this.lblTotalCompra.Text = "0.00";
            this.lblTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panBotonesPuntoVenta
            // 
            this.panBotonesPuntoVenta.Controls.Add(this.btnDescuento);
            this.panBotonesPuntoVenta.Controls.Add(this.btnEliminarArticulo);
            this.panBotonesPuntoVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.panBotonesPuntoVenta.Location = new System.Drawing.Point(1263, 31);
            this.panBotonesPuntoVenta.Name = "panBotonesPuntoVenta";
            this.panBotonesPuntoVenta.Size = new System.Drawing.Size(37, 492);
            this.panBotonesPuntoVenta.TabIndex = 0;
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.Color.Gray;
            this.btnDescuento.BackgroundColor = System.Drawing.Color.Gray;
            this.btnDescuento.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDescuento.BorderRadius = 5;
            this.btnDescuento.BorderSize = 0;
            this.btnDescuento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.ForeColor = System.Drawing.Color.White;
            this.btnDescuento.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.btnDescuento.IconColor = System.Drawing.Color.White;
            this.btnDescuento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescuento.IconSize = 30;
            this.btnDescuento.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDescuento.Location = new System.Drawing.Point(0, 37);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnDescuento.Size = new System.Drawing.Size(37, 37);
            this.btnDescuento.TabIndex = 1;
            this.btnDescuento.TextColor = System.Drawing.Color.White;
            this.btnDescuento.UseVisualStyleBackColor = false;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.Gray;
            this.btnEliminarArticulo.BackgroundColor = System.Drawing.Color.Gray;
            this.btnEliminarArticulo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarArticulo.BorderRadius = 5;
            this.btnEliminarArticulo.BorderSize = 0;
            this.btnEliminarArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarArticulo.FlatAppearance.BorderSize = 0;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnEliminarArticulo.IconColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarArticulo.IconSize = 30;
            this.btnEliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(0, 0);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnEliminarArticulo.Size = new System.Drawing.Size(37, 37);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.TextColor = System.Drawing.Color.White;
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // panBusquedaPuntoVenta
            // 
            this.panBusquedaPuntoVenta.Controls.Add(this.txtBuscarProducto);
            this.panBusquedaPuntoVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panBusquedaPuntoVenta.Location = new System.Drawing.Point(0, 0);
            this.panBusquedaPuntoVenta.Name = "panBusquedaPuntoVenta";
            this.panBusquedaPuntoVenta.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panBusquedaPuntoVenta.Size = new System.Drawing.Size(1300, 31);
            this.panBusquedaPuntoVenta.TabIndex = 4;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuscarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarProducto.Location = new System.Drawing.Point(10, 0);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PlaceholderText = "Buscar producto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(1280, 23);
            this.txtBuscarProducto.TabIndex = 0;
            this.txtBuscarProducto.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyDown);
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // panInferiorCatalogo
            // 
            this.panInferiorCatalogo.BackColor = System.Drawing.SystemColors.Control;
            this.panInferiorCatalogo.Controls.Add(this.btnCancelarCompra);
            this.panInferiorCatalogo.Controls.Add(this.btnPagar);
            this.panInferiorCatalogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panInferiorCatalogo.Location = new System.Drawing.Point(0, 528);
            this.panInferiorCatalogo.Name = "panInferiorCatalogo";
            this.panInferiorCatalogo.Size = new System.Drawing.Size(1300, 37);
            this.panInferiorCatalogo.TabIndex = 2;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.BackColor = System.Drawing.Color.Gray;
            this.btnCancelarCompra.BackgroundColor = System.Drawing.Color.Gray;
            this.btnCancelarCompra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelarCompra.BorderRadius = 5;
            this.btnCancelarCompra.BorderSize = 0;
            this.btnCancelarCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelarCompra.FlatAppearance.BorderSize = 0;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCompra.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCancelarCompra.IconColor = System.Drawing.Color.White;
            this.btnCancelarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarCompra.IconSize = 30;
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelarCompra.Location = new System.Drawing.Point(0, 0);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnCancelarCompra.Rotation = 45D;
            this.btnCancelarCompra.Size = new System.Drawing.Size(148, 37);
            this.btnCancelarCompra.TabIndex = 2;
            this.btnCancelarCompra.Text = "Cancelar compra";
            this.btnCancelarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCompra.TextColor = System.Drawing.Color.White;
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Gray;
            this.btnPagar.BackgroundColor = System.Drawing.Color.Gray;
            this.btnPagar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPagar.BorderRadius = 5;
            this.btnPagar.BorderSize = 0;
            this.btnPagar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnPagar.IconColor = System.Drawing.Color.White;
            this.btnPagar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagar.IconSize = 30;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPagar.Location = new System.Drawing.Point(1215, 0);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnPagar.Size = new System.Drawing.Size(85, 37);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.TextColor = System.Drawing.Color.White;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 600);
            this.Controls.Add(this.panControlesPuntoVenta);
            this.Controls.Add(this.panSuperiorCatalogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPuntoDeVenta";
            this.Text = "frmPuntoDeVenta";
            this.Load += new System.EventHandler(this.frmPuntoDeVenta_Load);
            this.panSuperiorCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarCatalogo)).EndInit();
            this.panControlesPuntoVenta.ResumeLayout(false);
            this.panPuntoVentaGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Articulos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panBotonesPuntoVenta.ResumeLayout(false);
            this.panBusquedaPuntoVenta.ResumeLayout(false);
            this.panBusquedaPuntoVenta.PerformLayout();
            this.panInferiorCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSuperiorCatalogo;
        private FontAwesome.Sharp.IconPictureBox btnCerrarCatalogo;
        private System.Windows.Forms.Panel panControlesPuntoVenta;
        private System.Windows.Forms.Panel panInferiorCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panPuntoVentaGrid;
        private System.Windows.Forms.DataGridView dgv_Articulos;
        private System.Windows.Forms.Panel panBusquedaPuntoVenta;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubTotalCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescuentoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Panel panBotonesPuntoVenta;
        private StlButton btnDescuento;
        private StlButton btnEliminarArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private StlButton btnCancelarCompra;
        private StlButton btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
    }
}