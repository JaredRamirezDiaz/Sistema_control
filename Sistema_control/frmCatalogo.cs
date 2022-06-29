using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ly_modelo;
using ly_negocio;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace Sistema_control
{
    public partial class frmCatalogo : Form
    {

        public frmCatalogo()
        {
            InitializeComponent();
        }
        
        public string nombreCatalogo;
        public Dictionary<string, string> controlesLayout = new Dictionary<string, string>();
        


        public void datosIniciales()
        {
            
            crearLayout(nombreCatalogo);
        }

        #region Panel de búsqueda
        public void crearPanelBusqueda(string tipoForm)
        {
            btnBusqueda.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnBusqueda.BorderColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnBusqueda.IconColor = Sistema.obtenerConfiguracionColor("color_secundario");
            btnBusqueda.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");

            List<UIElements.CampoEstructura> campos = neg_UIElements.obtenerEstructura(tipoForm);

            for (int i = 0; i <campos.Count; i++)
            {
                panFlowBusqueda.Controls.Add(crearCampoBusqueda(campos[i]));
            }
        }

        public Panel crearCampoBusqueda(UIElements.CampoEstructura campo)
        {
            FlowLayoutPanel nuevoPanel = new FlowLayoutPanel();
            //nuevoPanel.Location = posicion;
            //nuevoPanel.BackColor = Color.LightGray;

            //+++++++++++++++++++++++++++++++++++++++++++++++++ Label
            Label lblEtiqueta = new Label();
            lblEtiqueta.Text = campo.columna;
            lblEtiqueta.ForeColor = Color.Black;
            

            // Ancho del Label
            int anchoEtiqueta = (int) Math.Ceiling(lblEtiqueta.CreateGraphics().MeasureString(campo.columna, lblEtiqueta.Font).Width);
            anchoEtiqueta = (anchoEtiqueta / campo.columna.Length) * (campo.columna.Length + 1);
            
            nuevoPanel.Size = new Size(anchoEtiqueta+campo.ancho+30,30);
            
            lblEtiqueta.TextAlign = ContentAlignment.MiddleCenter;
            
            lblEtiqueta.AutoSize = true;
            //nuevoPanel.Size = new Size(anchoEtiqueta + campo.tamanho + 30, nuevoPanel.Height);
            lblEtiqueta.Dock = DockStyle.Left;
            
            int verticalMargin = (int)(0.5 * (nuevoPanel.Height - lblEtiqueta.Height));
            lblEtiqueta.Margin = new Padding(0,verticalMargin, 0, verticalMargin);


            nuevoPanel.Controls.Add(lblEtiqueta);
            nuevoPanel.Controls.Add(crearControlCampo(campo));

            nuevoPanel.AutoSize = true;

            nuevoPanel.Visible = campo.visible;
            return nuevoPanel;
        }

        public Control crearControlCampo(UIElements.CampoEstructura campo)
        {
            try
            {
                switch (campo.tipoElemento)
                {
                    case UIElements.TipoElemento.TextBox:
                        TextBox nuevoTextBox = new TextBox();
                        nuevoTextBox.Width = campo.ancho;
                        nuevoTextBox.PlaceholderText = campo.columna;
                        
                        

                        return nuevoTextBox;
                    case UIElements.TipoElemento.ComboBox:
                        ComboBox nuevoCombo =new ComboBox();
                        
                        List<UIElements.CampoEstructura.CampoComboBox> elementosCombo = JsonSerializer.Deserialize<List<UIElements.CampoEstructura.CampoComboBox>>(campo.jsonElementos);
                        nuevoCombo.DataSource = elementosCombo;
                        nuevoCombo.DisplayMember = "text";
                        nuevoCombo.ValueMember = "value";
                        nuevoCombo.Width = campo.ancho;
                        
                        return nuevoCombo;
                    default:
                        return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnCerrarCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Layout Principal

        private void crearLayout(string tipoForm)
        {
            
            List <UIElements> elementosLayout = neg_UIElements.obtenerElementosLayout(tipoForm);
            List<Control> controles = new List<Control>();
            for (int i = 0; i < elementosLayout.Count; i++)
            {
                switch ((UIElements.TipoElemento)elementosLayout[i].tipoElemento)
                {
                    case UIElements.TipoElemento.GridView:
                        Panel panelGrid = crearGrid((elementosLayout[i] as ElementoLayoutGrid));
                        DataGridView nuevoGrid = panelGrid.Controls[0] as DataGridView;
                        controles.Add(panelGrid);
                        controlesLayout.Add(nuevoGrid.Name, UIElements.TipoElemento.GridView.ToString());
                        break;
                    case UIElements.TipoElemento.CardVistaPrevia:
                        Panel cardView = crearCardVistaPrevia((elementosLayout[i] as ElementoLayoutCardVistaPrevia));
                        if (elementosLayout.Exists(elemento=>(elemento.tipoElemento==UIElements.TipoElemento.GridView && (elemento as ElementoLayoutGrid).fuenteDeDatos==(elementosLayout[i] as ElementoLayoutCardVistaPrevia).fuenteDeDatos )))
                        {
                            DataGridView grid = (DataGridView)controles[elementosLayout.FindIndex(elemento => (elemento.tipoElemento == UIElements.TipoElemento.GridView && (elemento as ElementoLayoutGrid).fuenteDeDatos == (elementosLayout[i] as ElementoLayoutCardVistaPrevia).fuenteDeDatos))].Controls[0];

                            grid.SelectionChanged += (object sender, EventArgs e) => {
                                if ((sender as DataGridView).SelectedRows.Count>0 && (sender as DataGridView).SelectedRows[0].Cells[0].Value !=null)
                                {
                                    for (int i = 0; i < (sender as DataGridView).Columns.Count-1; i++)
                                    {
                                        Panel panel = (cardView.Controls[i] as Panel);
                                        (panel.Controls[1] as Label).Text = (sender as DataGridView).SelectedRows[0].Cells[i].Value.ToString();
                                    }
                                }
                            };
                            if (grid.Rows.Count>0)
                            {
                                for (int j = 0; j < grid.Columns.Count; j++)
                                {
                                    Panel panel = (cardView.Controls[j] as Panel);
                                    (panel.Controls[1] as Label).Text = grid.Rows[0].Cells[j].Value.ToString();
                                }
                            }

                            string[] tipos = new string[2];
                            //tipos[0] = "Agregar";
                            tipos[0] = "Editar";
                            tipos[1] = "Eliminar";
                            cardView.Controls.Add(crearBotonEditarVistaPrevia(tipos,tipoForm));

                        }
                        controles.Add(cardView);
                        controlesLayout.Add(cardView.Name,UIElements.TipoElemento.CardVistaPrevia.ToString());
                        break;
                    case UIElements.TipoElemento.BotonAgregar:
                        btnAgregar.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
                        btnAgregar.BorderColor = Sistema.obtenerConfiguracionColor("color_primario");
                        btnAgregar.IconColor = Sistema.obtenerConfiguracionColor("color_secundario");
                        btnAgregar.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");
                        btnAgregar.Visible = true;
                        btnAgregar.Click += (object sender, EventArgs e) =>
                        {
                            frmAgregar ventanaAgregar = new frmAgregar(tipoForm, "Agregar");
                            if (ventanaAgregar.ShowDialog(this)==DialogResult.OK)
                            {
                                actualizarGrid(nombreCatalogo);

                            }
                            

                        };
                        break;
                    case UIElements.TipoElemento.BotonBuscar:
                        btnBusqueda.Visible = true;
                        crearPanelBusqueda(tipoForm);
                        break;
                    default:
                        break;
                }

            }

            foreach (Control control in controles)
            {
                panControlesPuntoDeVenta.Controls.Add(control);
            }

            //foreach (Control control1 in panControlesCatalogo.Controls)
            //{
            //    int w, h, x, y;
            //    w = control1.Width;
            //    h = control1.Height;
            //    x = control1.Location.X;
            //    y = control1.Location.Y;

            //    control1.Dock = DockStyle.None;
            //    control1.Width = w;
            //    control1.Height = h;
            //    control1.Location = new Point(x, y);

            //    control1.Anchor= AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //}
        }

        private Panel crearGrid(ElementoLayoutGrid elementoGrid)
        {            
            Panel nuevoPanelGrid = new Panel();
            nuevoPanelGrid.Padding = new Padding(5);

            DataGridView nuevoGrid = new DataGridView();
            //nuevoGrid.Size = new Size(panControlesCatalogo.Width/2, elementoGrid.alto);
            //var d = nuevoGrid.Anchor;
            nuevoGrid.Name = "dgv_"+elementoGrid.fuenteDeDatos;

            foreach (UIElements.CampoEstructura column in elementoGrid.columnas)
            {
                DataGridViewColumn nuevaCol = new DataGridViewColumn();
                nuevaCol.HeaderText = column.etiqueta;
                nuevaCol.Name = column.columna;
                nuevaCol.Visible = column.visible;
                nuevaCol.CellTemplate= new DataGridViewTextBoxCell();
                nuevaCol.ReadOnly = true;
                nuevoGrid.Columns.Add(nuevaCol);
                if (column.columna=="Descripcion")
                {
                    nuevaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {

                    nuevaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            foreach (string[] linea in elementoGrid.elementos)
            {
                nuevoGrid.Rows.Add(linea);
            }

            switch (elementoGrid.dock)
            {
                case "Top":
                    nuevoPanelGrid.Dock = DockStyle.Top;
                    //nuevoGrid.Height = elementoGrid.alto;
                    //nuevoGrid.Width = panControlesCatalogo.Width;
                    //nuevoGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case "Right":
                    nuevoPanelGrid.Dock = DockStyle.Right;
                    nuevoPanelGrid.Width = elementoGrid.ancho;
                    //nuevoGrid.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Bottom":
                    nuevoPanelGrid.Dock = DockStyle.Bottom;
                    //nuevoGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Top ;
                    nuevoPanelGrid.Height = elementoGrid.alto;
                    //nuevoPanelGrid.Width = panControlesCatalogo.Width;
                    break;
                case "Left":
                    nuevoPanelGrid.Dock = DockStyle.Left;
                    nuevoPanelGrid.Width = elementoGrid.ancho;
                    //nuevoGrid.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Fill":
                    nuevoPanelGrid.Dock = DockStyle.Fill;
                    break;
                default:
                    nuevoPanelGrid.Dock = DockStyle.None;
                    //nuevoGrid.Width = elementoGrid.ancho;
                    nuevoPanelGrid.Height = elementoGrid.alto;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

                    break;
            }

            nuevoGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nuevoGrid.DefaultCellStyle.SelectionBackColor = Sistema.obtenerConfiguracionColor("color_primario");
            nuevoGrid.DefaultCellStyle.SelectionForeColor = Sistema.obtenerConfiguracionColor("color_texto_secundario");

            nuevoGrid.BackgroundColor = Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            nuevoGrid.DefaultCellStyle.ForeColor= Sistema.obtenerConfiguracionColor("color_texto_primario");
            nuevoGrid.GridColor= Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            nuevoGrid.EnableHeadersVisualStyles = false;
            nuevoGrid.ColumnHeadersDefaultCellStyle.BackColor= Sistema.obtenerConfiguracionColor("color_texto_secundario"); 
            nuevoGrid.ColumnHeadersDefaultCellStyle.ForeColor= Sistema.obtenerConfiguracionColor("color_texto_primario");
            nuevoGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor= Sistema.obtenerConfiguracionColor("color_texto_secundario");
            nuevoGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nuevoGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            nuevoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            nuevoGrid.ColumnHeadersHeight = 30;
            nuevoGrid.RowHeadersVisible = false;

            nuevoGrid.BorderStyle = BorderStyle.None;

            nuevoGrid.Dock = DockStyle.Fill;

            Label lblTituloGrid = new Label();
            lblTituloGrid.Text = elementoGrid.fuenteDeDatos;
            lblTituloGrid.Dock = DockStyle.Top;
            lblTituloGrid.AutoSize = false;
            lblTituloGrid.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloGrid.ForeColor= Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            lblTituloGrid.BackColor= Sistema.obtenerConfiguracionColor("color_barra_superior");
            lblTituloGrid.Font = new Font("Segoe UI", 12);



            nuevoPanelGrid.Controls.Add(nuevoGrid);
            nuevoPanelGrid.Controls.Add(lblTituloGrid);
            return nuevoPanelGrid;
        }

        private Panel crearCardVistaPrevia(ElementoLayoutCardVistaPrevia elementoCard)
        {
            FlowLayoutPanel nuevoPanelCard = new FlowLayoutPanel();
            nuevoPanelCard.Width = elementoCard.ancho;
            
            nuevoPanelCard.FlowDirection = FlowDirection.TopDown;
            //nuevoPanelCard.Height = elementoCard.alto;
            //nuevoPanelCard.MaximumSize = new Size(elementoCard.ancho,elementoCard.alto);

            //nuevoPanelCard.BackColor = Color.Red;
            string maxString = "";
            foreach (UIElements.CampoEstructura campo in elementoCard.campos)
            {
                maxString = campo.columna.Length > maxString.Length ? campo.columna : maxString;
            }
            foreach (UIElements.CampoEstructura campo in elementoCard.campos)
            {
                    nuevoPanelCard.Controls.Add(crearCampoCardVistaPrevia(campo,elementoCard.ancho-10,maxString));
            }

            

            switch (elementoCard.dock)
            {
                case "Top":
                    nuevoPanelCard.Dock = DockStyle.Top;
                    //nuevoPanelCard.Height = elementoCard.alto;
                    //nuevoPanelCard.Width = panControlesCatalogo.Width;
                    //nuevoGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case "Right":
                    nuevoPanelCard.Dock = DockStyle.Right;
                    //nuevoPanelCard.Width = elementoCard.ancho;
                    //nuevoPanelCard.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Bottom":
                    nuevoPanelCard.Dock = DockStyle.Bottom;
                    //nuevoPanelCard.Height = elementoCard.alto;
                    //nuevoPanelCard.Width = panControlesCatalogo.Width;
                    //nuevoGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case "Left":
                    nuevoPanelCard.Dock = DockStyle.Left;
                    //nuevoPanelCard.Width = elementoCard.ancho;
                    //nuevoPanelCard.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Fill":
                    nuevoPanelCard.Dock = DockStyle.Fill;
                    break;
                default:
                    nuevoPanelCard.Dock = DockStyle.None;
                    //nuevoPanelCard.Width = elementoCard.ancho;
                    //nuevoPanelCard.Height = elementoCard.alto;
                    nuevoPanelCard.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

                    break;
            }

            nuevoPanelCard.AutoScroll = true;

            return nuevoPanelCard;
        }

        public Panel crearCampoCardVistaPrevia(UIElements.CampoEstructura campo,int anchoPanel,string maxString)
        {
            Panel nuevoCampoCard = new Panel();


            Label labelCampo = new Label();
            labelCampo.Text = campo.columna;
            //labelCampo.AutoSize = true;
            labelCampo.Dock = DockStyle.Left;

            int anchoEtiqueta = (int)Math.Ceiling(labelCampo.CreateGraphics().MeasureString(maxString+"A", labelCampo.Font).Width);
            labelCampo.Width = anchoEtiqueta;
            


            

            Label labelValor = new Label();
            labelValor.Text = "";
            labelValor.AutoSize = true;
            //labelValor.Dock = DockStyle.Fill;

            labelValor.MaximumSize = new Size(anchoPanel-anchoEtiqueta, 0);
            labelValor.MinimumSize = new Size(anchoPanel-anchoEtiqueta, 0);
            labelValor.Location=new Point(anchoEtiqueta,0);

            nuevoCampoCard.Controls.Add(labelCampo);
            nuevoCampoCard.Controls.Add(labelValor);

            nuevoCampoCard.Height = labelValor.Height;
            nuevoCampoCard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nuevoCampoCard.MinimumSize = new Size(anchoPanel, labelValor.Height);
            nuevoCampoCard.MaximumSize= new Size(anchoPanel, 0);
            nuevoCampoCard.AutoSize = true;

            nuevoCampoCard.Dock = DockStyle.Top;

            nuevoCampoCard.Visible = campo.visible;
            
            return nuevoCampoCard;
        }

        

        public Panel crearBotonEditarVistaPrevia(string[] tipos,string nombreCatalogo)
        {
            Panel nuevoPanelBotones = new Panel();
            nuevoPanelBotones.Dock = DockStyle.Top;
            nuevoPanelBotones.Height = 35;
            nuevoPanelBotones.Padding = new Padding(0, 5, 0, 0);
            foreach (string tipo in tipos)
            {
                StlButton nuevoBoton = new StlButton();
                nuevoBoton.ImageAlign = ContentAlignment.TopCenter;
                nuevoBoton.BorderRadius = 15;
                nuevoBoton.IconSize = 20;
                nuevoBoton.Size = new Size(30, 30);
                nuevoBoton.Padding = new Padding(1, 2, 0, 0);
                nuevoBoton.IconColor = Sistema.obtenerConfiguracionColor("color_secundario");
                nuevoBoton.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
                nuevoBoton.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");
                nuevoBoton.Cursor = Cursors.Hand;
                nuevoBoton.Dock = DockStyle.Right;


                


                switch (tipo)
                {
                    case "Editar":
                        
                        nuevoBoton.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
                        nuevoBoton.Name = "btnEditar"+nombreCatalogo;
                        nuevoBoton.Click += (object sender, EventArgs e) => {
                            DataGridView grid = (DataGridView)(sender as Button).Parent.Parent.Parent.Controls.Find("dgv_"+(sender as Button).Name.Replace("btnEditar",""),true)[0];

                            Dictionary<string, UIElements.CampoEstructura> valores = new Dictionary<string, UIElements.CampoEstructura>();

                            foreach (UIElements.CampoEstructura column in neg_UIElements.obtenerEstructura(this.nombreCatalogo))
                            {
                                column.valor = grid.SelectedRows[0].Cells[column.columna].Value.ToString();
                                valores.Add(column.columna, column);
                            }
                            frmAgregar ventanaEditar = new frmAgregar(this.nombreCatalogo, "Editar", valores);
                            if (ventanaEditar.ShowDialog(this) == DialogResult.OK)
                            {
                                actualizarGrid(nombreCatalogo);
                            }
                            
                        };

                        break;
                    case "Eliminar":
                        //nuevoBoton.Text = "Agregar";
                        nuevoBoton.IconChar = FontAwesome.Sharp.IconChar.Trash;
                        
                        break;
                    default:
                        break;
                }
                nuevoPanelBotones.Controls.Add(nuevoBoton);
            }

            return nuevoPanelBotones;
        }

        public void actualizarGrid(string fuenteDatos = "")
        {
            List<UIElements> grids = neg_UIElements.obtenerElementosLayout(this.nombreCatalogo,(int)UIElements.TipoElemento.GridView,fuenteDatos);
            foreach (UIElements control in grids)
            {
                Control grid = this.Controls.Find("dgv_" + (control as ElementoLayoutGrid).fuenteDeDatos,true)[0];
                if(grid != null)
                {
                    (grid as DataGridView).Rows.Clear();

                    foreach (string[] linea in (control as ElementoLayoutGrid).elementos)
                    {
                        (grid as DataGridView).Rows.Add(linea);
                    }
                }
            }
        }

        #endregion

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (panFlowBusqueda.Height==0)
            {
                btnBusqueda.BackColor = Sistema.obtenerConfiguracionColor("color_secundario");
                btnBusqueda.BorderColor = Sistema.obtenerConfiguracionColor("color_primario");
                btnBusqueda.IconColor = Sistema.obtenerConfiguracionColor("color_primario");
                btnBusqueda.ForeColor = Sistema.obtenerConfiguracionColor("color_primario");
                //panFlowBusqueda.Height= Sistema.obtenerConfiguracionInt("alto_panel_busqueda");
                panFlowBusqueda.AutoSize = true;

                btnBusqueda.Text = "Buscar  ▲";
            }
            else
            {
                btnBusqueda.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
                btnBusqueda.BorderColor = Sistema.obtenerConfiguracionColor("color_primario");
                btnBusqueda.IconColor = Sistema.obtenerConfiguracionColor("color_secundario");
                btnBusqueda.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");
                panFlowBusqueda.AutoSize = false;
                panFlowBusqueda.Height = 0;
                btnBusqueda.Text = "Buscar  ▼";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
