using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using ly_modelo;
using ly_negocio;

namespace Sistema_control
{
    public partial class frmAgregar : Form
    {
        public string _Catalogo { get; set; }
        public string _Comando { get; set; }

        Dictionary<string, UIElements.CampoEstructura> _Valores = new Dictionary<string, UIElements.CampoEstructura>();


        public frmAgregar(string catalogo, string comando, Dictionary<string, UIElements.CampoEstructura> valores)
        {
            InitializeComponent();
            this._Catalogo = catalogo;
            this._Comando = comando;
            this.StartPosition = FormStartPosition.CenterParent;

            this._Valores = valores;
            personalizarVentana();
        }

        public frmAgregar(string catalogo, string comando)
        {
            InitializeComponent();
            this._Catalogo = catalogo;
            this._Comando = comando;
            this.StartPosition = FormStartPosition.CenterParent;

            _Valores = new Dictionary<string, UIElements.CampoEstructura>();

            foreach (UIElements.CampoEstructura column in neg_UIElements.obtenerEstructura(catalogo))
            {
                _Valores.Add(column.columna, column);
            }
            personalizarVentana();
        }

        private const int CS_DropShadow = 0x20000;

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + (Sistema.obtenerConfiguracionInt("ancho_panel_izquierdo")/2), this.Location.Y - (int)(this.Height / 1.5));
            crearControles();
            if (this._Comando == "Editar")
            {
                cargarValores();
            }
        }


        public void cargarValores()
        {
            foreach (string nombreAtributo in _Valores.Keys)
            {
                UIElements.CampoEstructura atributo = _Valores[nombreAtributo];
                switch ((UIElements.TipoElemento)atributo.tipoElemento)
                {
                    case UIElements.TipoElemento.TextBox:
                        ((TextBox)this.Controls.Find("ctrl" + atributo.columna, true)[0]).Text = atributo.valor;
                        break;
                    case UIElements.TipoElemento.ComboBox:
                        ComboBox combo = ((ComboBox)this.Controls.Find("ctrl" + atributo.columna, true)[0]);
                        if (atributo.tipoColumna=="FT")
                        {
                            combo.SelectedIndex = combo.FindString(atributo.valor);
                        }
                        else
                        {
                            combo.SelectedValue = atributo.valor;
                        }
                        combo.SelectedIndexChanged += (object sender, EventArgs e) => {
                            UIElements.CampoEstructura attributo = _Valores[((ComboBox)sender).Name.Replace("ctrl", "")];
                            if (atributo.tipoColumna=="FT")
                            {
                                attributo.valor = ((ComboBox)sender).SelectedText.ToString();
                            }
                            else
                            {
                                attributo.valor = ((ComboBox)sender).SelectedValue.ToString();
                            }
                        };
                        break;
                    case UIElements.TipoElemento.CheckBox:
                        bool check = false;
                        Boolean.TryParse(atributo.columna, out check);
                        ((CheckBox)this.Controls.Find("ctrl" + atributo.columna, true)[0]).Checked = check;
                        break;
                    case UIElements.TipoElemento.Numero:
                        ((TextBox)this.Controls.Find("ctrl" + atributo.columna, true)[0]).Text = atributo.valor;
                        break;
                    case UIElements.TipoElemento.NumeroRango:
                        break;
                    case UIElements.TipoElemento.Fecha:
                        break;
                    case UIElements.TipoElemento.FechaRango:
                        break;
                    case UIElements.TipoElemento.NumeroUpDown:
                        break;
                    case UIElements.TipoElemento.GridView:
                        break;
                    case UIElements.TipoElemento.CardVistaPrevia:
                        break;
                    case UIElements.TipoElemento.BotonAgregar:
                        break;
                    case UIElements.TipoElemento.BotonBuscar:
                        break;
                    default:
                        break;
                }
            }
        }
        public void personalizarVentana()
        {
            //panMenu.BackColor = Sistema.obtenerConfiguracionColor("color_primario");

            // panLateralIzq.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            // panLateralIzq.Width = Sistema.obtenerConfiguracionInt("ancho_panel_izquierdo");

            lblTituloAgregar.Text = _Catalogo;
            lblTituloAgregar.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            

            panSuperiorAgregar.BackColor = Sistema.obtenerConfiguracionColor("color_barra_superior");
            iconSalirAgregar.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            


            btnAceptarAgregar.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnAceptarAgregar.ForeColor = Sistema.obtenerConfiguracionColor("color_secundario");
            btnAceptarAgregar.Text = _Comando;
            
            
            btnCancelar.BackColor = Sistema.obtenerConfiguracionColor("color_boton_cancelar");
            btnCancelar.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_boton_cancelar");

            panControlesAgregar.BackColor = Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            this.BackColor = Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            //panPrincipalAgregar.Paint += (object sender, PaintEventArgs e) => { ControlPaint.DrawBorder(e.Graphics, (sender as Panel).ClientRectangle, Sistema.obtenerConfiguracionColor("color_primario"), ButtonBorderStyle.Solid); };


            //iconColapsarMenu.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_primario");
        }

        public void crearControles()
        {
            this.Height = _Valores.Count * 25 + 160;

            string maxString = "";
            foreach (string nombreCampo in _Valores.Keys)
            {
                UIElements.CampoEstructura campo = _Valores[nombreCampo];
                maxString = campo.columna.Length > maxString.Length ? campo.columna : maxString;
            }
            foreach (string nombreCampo in _Valores.Keys)
            {
                UIElements.CampoEstructura campo = _Valores[nombreCampo];
                panControlesAgregar.Controls.Add(CrearControl(campo, maxString));
            }

        }

        public Panel CrearControl(UIElements.CampoEstructura campo,string maxString)
        {
            Panel nuevoCampo = new Panel();
            int anchoPanel = panControlesAgregar.Width-panControlesAgregar.Padding.Left-panControlesAgregar.Padding.Right;

            TextBox txtValor = new TextBox();
            txtValor.Text = "";
            txtValor.AutoSize = true;
            //labelValor.Dock = DockStyle.Fill;

            nuevoCampo.Height = txtValor.Height;
            nuevoCampo.AutoSize = true;
            nuevoCampo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nuevoCampo.MinimumSize = new Size(anchoPanel, txtValor.Height);
            nuevoCampo.MaximumSize = new Size(anchoPanel, 0);

            Label labelCampo = new Label();
            labelCampo.Text = campo.etiqueta;
            //labelCampo.AutoSize = true;
            labelCampo.Dock = DockStyle.Left;

            int anchoEtiqueta = (int)Math.Ceiling(labelCampo.CreateGraphics().MeasureString(maxString + "A", labelCampo.Font).Width);
            labelCampo.Width = anchoEtiqueta;

            

            txtValor.MaximumSize = new Size(anchoPanel - anchoEtiqueta, 0);
            txtValor.MinimumSize = new Size(anchoPanel - anchoEtiqueta, 0);
            txtValor.Location = new Point(anchoEtiqueta, 0);

            nuevoCampo.Controls.Add(labelCampo);
            nuevoCampo.Controls.Add(crearControlCampo(campo, anchoEtiqueta,nuevoCampo.Width));

            

            //nuevoCampo.Dock = DockStyle.Top;

            nuevoCampo.Visible = campo.buscable && !campo.clavePrimaria;
            return nuevoCampo;
        }

        public Control crearControlCampo(UIElements.CampoEstructura campo, int anchoEtiqueta, int anchoPanel)
        {
            try
            {
                
                switch ((UIElements.TipoElemento)campo.tipoElemento)
                {
                    case UIElements.TipoElemento.TextBox:
                        TextBox nuevoTextBox = new TextBox();
                        nuevoTextBox.Width = anchoPanel-anchoEtiqueta;
                        nuevoTextBox.PlaceholderText = campo.columna;
                        nuevoTextBox.Location = new Point(anchoEtiqueta, 0);
                        nuevoTextBox.MaxLength = campo.longitudMaxima;
                        if (campo.longitudMaxima > 0)
                            nuevoTextBox.MaxLength = campo.longitudMaxima;



                        nuevoTextBox.Name = "ctrl" + campo.columna;
                        return nuevoTextBox;
                    case UIElements.TipoElemento.ComboBox:
                        ComboBox nuevoCombo = new ComboBox();

                        List<UIElements.CampoEstructura.CampoComboBox> elementosCombo = JsonSerializer.Deserialize<List<UIElements.CampoEstructura.CampoComboBox>>(campo.jsonElementos);
                        
                        nuevoCombo.DisplayMember = "text";
                        nuevoCombo.ValueMember = "value";
                        nuevoCombo.DataSource = elementosCombo;
                        nuevoCombo.Width = anchoPanel - anchoEtiqueta;
                        nuevoCombo.Location = new Point(anchoEtiqueta, 0);
                        nuevoCombo.CreateControl();


                        nuevoCombo.Name = "ctrl" + campo.columna;
                        return nuevoCombo;
                    case UIElements.TipoElemento.CheckBox:
                        CheckBox nuevoCheck = new CheckBox();
                        nuevoCheck.Location = new Point(anchoEtiqueta, 0);
                        
                        if (campo.valor=="")
                        {
                            nuevoCheck.Checked = true;
                        }
                        else
                        {
                            nuevoCheck.Checked = Boolean.Parse(campo.valor);
                        }

                        nuevoCheck.Name = "ctrl" + campo.columna;
                        return nuevoCheck;

                    case UIElements.TipoElemento.Numero:
                        TextBox nuevoTextBoxNumeric = new TextBox();
                        nuevoTextBoxNumeric.Width = anchoPanel - anchoEtiqueta;
                        nuevoTextBoxNumeric.PlaceholderText = campo.columna;
                        nuevoTextBoxNumeric.Location = new Point(anchoEtiqueta, 0);
                        nuevoTextBoxNumeric.MaxLength = campo.longitudMaxima;
                        nuevoTextBoxNumeric.KeyPress += (object sender, KeyPressEventArgs e) =>
                         {
                             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                 (e.KeyChar != '.'))
                             {
                                 e.Handled = true;
                             }

                            // only allow one decimal point
                            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                             {
                                 e.Handled = true;
                             }
                         };

                        nuevoTextBoxNumeric.Name = "ctrl" + campo.columna;

                        return nuevoTextBoxNumeric;
                        
                    //case UIElements.TipoElemento.NumeroRango:
                    //    break;
                    //case UIElements.TipoElemento.Fecha:
                    //    break;
                    //case UIElements.TipoElemento.FechaRango:
                    //    break;
                    //case UIElements.TipoElemento.NumeroUpDown:
                    //    break;
                    //case UIElements.TipoElemento.GridView:
                    //    break;
                    //case UIElements.TipoElemento.CardVistaPrevia:
                    //    break;
                    //case UIElements.TipoElemento.BotonAgregar:
                    //    break;
                    //case UIElements.TipoElemento.BotonBuscar:
                    //    break;
                    default:
                        return null;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public string obtenerValorCampo(UIElements.CampoEstructura campo,bool agregarComillas)
        {
            Control controlCampo = panControlesAgregar.Controls.Find(("ctrl"+campo.columna),true)[0];
            string valor = "";
            switch (campo.tipoElemento)
            {
                case UIElements.TipoElemento.TextBox:
                    valor = (controlCampo as TextBox).Text;
                    break;
                case UIElements.TipoElemento.ComboBox:
                    valor = (controlCampo as ComboBox).SelectedValue.ToString();
                    break;
                case UIElements.TipoElemento.CheckBox:
                    valor = (controlCampo as CheckBox).Checked ? "1" : "0";
                    break;
                case UIElements.TipoElemento.NumeroUpDown:
                    valor = (controlCampo as NumericUpDown).Value.ToString();
                    break;
                case UIElements.TipoElemento.Numero:
                    valor = (controlCampo as TextBox).Text;
                    break;
                case UIElements.TipoElemento.NumeroRango:
                    break;
                case UIElements.TipoElemento.Fecha:
                    break;
                case UIElements.TipoElemento.FechaRango:
                    break;
                default:
                    break;
            }

            if (campo.tipoDato.Equals("varchar"))
            {
                valor = "'" + valor + "'";
            }

            return valor;
        }
        #region funcionamiento Ventana


        private int lx, ly;
        private int ancho_pantalla_default = 500, alto_pantalla_default = 500;

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            try
            {
                base.OnSizeChanged(e);
                var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
                sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
                region.Exclude(sizeGripRectangle);
                this.panPrincipalAgregar.Region = region;
                this.Invalidate();
            }
            catch (Exception exep)
            {

                Console.WriteLine(exep.Message);
            }
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }


        private void iconSalirAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconVentanaAgregar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(ancho_pantalla_default, alto_pantalla_default);
            this.Location = new Point(lx, ly);
            iconVentana.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void panSuperiorAgregar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSalirAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            string sql_comando="", sql_argumentos = "", sql_clausulas="",sql_principal="", clavePrimaria ="",valorID="";
            
            
            switch (_Comando)
            {
                case "Editar":
                    sql_comando = "UPDATE " + _Catalogo + " SET" ;
                    foreach (string clave in _Valores.Keys)
                    {
                        UIElements.CampoEstructura campo = _Valores[clave];
                        if (campo.tipoColumna.Equals("N/A") || campo.tipoColumna.Equals("FK"))
                        {
                            sql_argumentos += $@"   [{campo.columna}] = {obtenerValorCampo(campo,true)} ,";
                        }
                        else if (campo.tipoColumna.Equals("PK"))
                        {
                            clavePrimaria = campo.columna;
                        }

                    }
                    sql_argumentos = sql_argumentos.Substring(0, sql_argumentos.Length - 1);
                    valorID = _Valores[clavePrimaria].valor;
                    if (clavePrimaria.Length>0 && valorID.Length>0)
                    {
                        sql_clausulas = $@" WHERE {clavePrimaria}={valorID}";
                        sql_principal = sql_comando+ " " + sql_argumentos+" "+ sql_clausulas;

                        if (neg_Catalogo.editar(sql_principal))
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.No;
                        }
                    }

                    
                    break;
                case "Agregar":
                    sql_comando = $@"INSERT INTO {_Catalogo} ";
                    string columnas = "", valores = "";

                    foreach (string clave in _Valores.Keys)
                    {
                        UIElements.CampoEstructura campo = _Valores[clave];
                        if (campo.tipoColumna.Equals("N/A") || campo.tipoColumna.Equals("FK"))
                        {
                            columnas += $@"[{campo.columna}],";
                            valores += $@"{obtenerValorCampo(campo,true)},";

                        }
                        else if (campo.tipoColumna.Equals("PK"))
                        {
                            clavePrimaria = campo.columna;
                        }
                    }

                    columnas = columnas.Substring(0, columnas.Length - 1);
                    valores= valores.Substring(0, valores.Length - 1);

                    sql_argumentos = $@" ({columnas}) Values ({valores})";
                    sql_principal = sql_comando + sql_argumentos;
                    if (neg_Catalogo.agregar(sql_principal))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                    }

                    break;
                default:
                    break;
            }

            
        }


        

        private void iconMinimizarAgregar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconMaximizarAgregar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            ancho_pantalla_default = this.Size.Width;
            alto_pantalla_default = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconVentana.Visible = true;
            iconMaximizar.Visible = false;
        }

        #endregion

    }
}
