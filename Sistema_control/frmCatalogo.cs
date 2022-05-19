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
        public string titulo;
        public string tipoForm;


        public void datosIniciales()
        {
            crearPanelBusqueda(tipoForm);
            crearLayout(tipoForm);
        }

        #region Panel de búsqueda
        public void crearPanelBusqueda(string tipoForm)
        {
            btnBusqueda.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnBusqueda.BorderColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnBusqueda.IconColor = Sistema.obtenerConfiguracionColor("color_secundario");
            btnBusqueda.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");

            List<UIElements.campoBusqueda> campos = neg_UIElements.obtenerCamposDeBusqueda(tipoForm);

            for (int i = 0; i <campos.Count; i++)
            {
                panFlowBusqueda.Controls.Add(crearCampoBusqueda(campos[i]));
            }
        }

        public Panel crearCampoBusqueda(UIElements.campoBusqueda campo)
        {
            FlowLayoutPanel nuevoPanel = new FlowLayoutPanel();
            //nuevoPanel.Location = posicion;
            //nuevoPanel.BackColor = Color.LightGray;

            //+++++++++++++++++++++++++++++++++++++++++++++++++ Label
            Label lblEtiqueta = new Label();
            lblEtiqueta.Text = campo.etiqueta;
            lblEtiqueta.ForeColor = Color.Black;
            

            // Ancho del Label
            int anchoEtiqueta = (int) Math.Ceiling(lblEtiqueta.CreateGraphics().MeasureString(campo.etiqueta, lblEtiqueta.Font).Width);
            anchoEtiqueta = (anchoEtiqueta / campo.etiqueta.Length) * (campo.etiqueta.Length + 1);
            
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


            return nuevoPanel;
        }

        public Control crearControlCampo(UIElements.campoBusqueda campo)
        {
            try
            {
                switch (campo.tipoElemento)
                {
                    case UIElements.campoBusqueda.TipoElemento.TextBox:
                        TextBox nuevoTextBox = new TextBox();
                        nuevoTextBox.Width = campo.ancho;
                        nuevoTextBox.PlaceholderText = campo.etiqueta;
                        
                        

                        return nuevoTextBox;
                    case UIElements.campoBusqueda.TipoElemento.ComboBox:
                        ComboBox nuevoCombo =new ComboBox();
                        
                        List<UIElements.campoBusqueda.CampoComboBox> elementosCombo = JsonSerializer.Deserialize<List<UIElements.campoBusqueda.CampoComboBox>>(campo.jsonStringValores);
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
                        controles.Add(crearGrid((elementosLayout[i] as ElementoLayoutGrid)));
                        break;
                    case UIElements.TipoElemento.CardVistaPrevia:
                        controles.Add(crearCardVistaPrevia((elementosLayout[i] as ElementoLayoutCardVistaPrevia)));
                        break;
                    default:
                        break;
                }

            }

            foreach (Control control in controles)
            {
                panControlesCatalogo.Controls.Add(control);
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

        private DataGridView crearGrid(ElementoLayoutGrid elementoGrid)
        {
           
            
            DataGridView nuevoGrid = new DataGridView();
            //nuevoGrid.Size = new Size(panControlesCatalogo.Width/2, elementoGrid.alto);
            //var d = nuevoGrid.Anchor;
            
            foreach (ElementoLayoutGrid.ColumnaGrid column in elementoGrid.columnas)
            {
                DataGridViewColumn nuevaCol = new DataGridViewColumn();
                nuevaCol.HeaderText = column.columna;
                nuevaCol.Name = column.columna;
                nuevaCol.Visible = column.visible;
                nuevaCol.CellTemplate= new DataGridViewTextBoxCell();
                nuevoGrid.Columns.Add(nuevaCol);
                nuevaCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            foreach (string[] linea in elementoGrid.elementos)
            {
                nuevoGrid.Rows.Add(linea);
            }

            switch (elementoGrid.dock)
            {
                case "Top":
                    nuevoGrid.Dock = DockStyle.Top;
                    //nuevoGrid.Height = elementoGrid.alto;
                    //nuevoGrid.Width = panControlesCatalogo.Width;
                    //nuevoGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                    break;
                case "Right":
                    nuevoGrid.Dock = DockStyle.Right;
                    //nuevoGrid.Width = elementoGrid.ancho;
                    //nuevoGrid.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Bottom":
                    nuevoGrid.Dock = DockStyle.Bottom;
                    //nuevoGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Top ;
                    //nuevoGrid.Height = elementoGrid.alto;
                    //nuevoPanelGrid.Width = panControlesCatalogo.Width;
                    break;
                case "Left":
                    nuevoGrid.Dock = DockStyle.Left;
                    //nuevoGrid.Width = elementoGrid.ancho;
                    //nuevoGrid.Height = panControlesCatalogo.Height;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                    break;
                case "Fill":
                    nuevoGrid.Dock = DockStyle.Fill;
                    break;
                default:
                    nuevoGrid.Dock = DockStyle.None;
                    //nuevoGrid.Width = elementoGrid.ancho;
                    //nuevoGrid.Height = elementoGrid.alto;
                    //nuevoGrid.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

                    break;
            }

            nuevoGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nuevoGrid.DefaultCellStyle.SelectionBackColor = Sistema.obtenerConfiguracionColor("color_primario");
            nuevoGrid.DefaultCellStyle.SelectionForeColor = Sistema.obtenerConfiguracionColor("color_texto_secundario");

            
            

            return nuevoGrid;
        }

        private Panel crearCardVistaPrevia(ElementoLayoutCardVistaPrevia elementoCard)
        {
            FlowLayoutPanel nuevoPanelCard = new FlowLayoutPanel();
            //nuevoPanelCard.Width = elementoCard.ancho;
            //nuevoPanelCard.Height = elementoCard.alto;
            //nuevoPanelCard.MaximumSize = new Size(elementoCard.ancho,elementoCard.alto);

            nuevoPanelCard.BackColor = Color.Red;

            foreach (ElementoLayoutCardVistaPrevia.CampoCardVistaPrevia campo in elementoCard.campos)
            {
                nuevoPanelCard.Controls.Add(crearCampoCardVistaPrevia(campo));
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

        public Panel crearCampoCardVistaPrevia(ElementoLayoutCardVistaPrevia.CampoCardVistaPrevia campo)
        {
            Panel nuevoCampoCard = new Panel();

            Label labelCampo = new Label();
            labelCampo.Text = campo.columna;

            nuevoCampoCard.Controls.Add(labelCampo);

            nuevoCampoCard.Height = 32;
            
            nuevoCampoCard.Dock = DockStyle.Top;
            
            
            return nuevoCampoCard;
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
    }
}
