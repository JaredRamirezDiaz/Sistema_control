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
            nuevoPanel.BackColor = Color.LightGray;

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
                    default:
                        break;
                }

            }

            foreach (Control control in controles)
            {
                panControlesCatalogo.Controls.Add(control);
            }
        }

        private DataGridView crearGrid(ElementoLayoutGrid elementoGrid)
        {
            DataGridView nuevoGrid = new DataGridView();
            nuevoGrid.Size = new Size(panControlesCatalogo.Width/2, elementoGrid.alto);
            var d = nuevoGrid.Anchor;
            foreach (ElementoLayoutGrid.ColumnaGrid column in elementoGrid.columnas)
            {
                DataGridViewColumn nuevaCol = new DataGridViewColumn();
                nuevaCol.HeaderText = column.columna;
                nuevaCol.Name = column.columna;
                nuevaCol.Visible = column.visible;
                nuevaCol.CellTemplate= new DataGridViewTextBoxCell();
                nuevoGrid.Columns.Add(nuevaCol);

            }

            foreach (string[] linea in elementoGrid.elementos)
            {
                nuevoGrid.Rows.Add(linea);
            }

            
            return nuevoGrid;
        }

        #endregion
    }
}
