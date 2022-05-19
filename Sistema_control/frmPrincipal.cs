using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ly_modelo;
using ly_negocio;
using System.Runtime.InteropServices;
using System.Linq;

namespace Sistema_control
{
    public partial class frmPrincipal : Form
    {
        private int ancho_menu = 250;
        private int ancho_panel_colapsado = 250/5;
        private int ancho_panel_izquierdo=250;
        private int margen_x_menu = 0;
        private int margen_y_Menu = 5;
        private int escala_icono_menu = 32;
        private int alto_boton_menu = 50;

        private int lx,ly;
        private int ancho_pantalla_default=1300, alto_pantalla_default = 650;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
            panPrincipalVentana.MinimumSize = new Size(30, 30);
            
            crearMenu();
        }

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
                this.panPrincipalVentana.Region = region;
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

        private void AbrirFormulario<MiForm>(string tipo,string nombre) where MiForm : Form, new()
        {
            Form formulario;
            formulario = (Form)panContenedorPrincipal.Controls.OfType<MiForm>().FirstOrDefault(frm => frm.Text== tipo+nombre);
            

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.Text = tipo + nombre;
                ((frmCatalogo)formulario).titulo = nombre;
                ((frmCatalogo)formulario).tipoForm = nombre;
                ((frmCatalogo)formulario).datosIniciales();

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panContenedorPrincipal.Controls.Add(formulario);
                panContenedorPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void crearMenu()
        {
            //List<Configuracion> config = neg_Configuracion.obtenerTodos(idEmpresa:1);
            //Color colorPrimario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_primario").valor);
            //Color colorSecundario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_secundario").valor);
            //Color colorTexto = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_texto_primario").valor);
            //Color colorTextoSecundario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_texto_secundario").valor);
            //Color colorBarraSuperior = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_barra_superior").valor);
            //Color colorTextoBarraSuperior = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_texto_barra_superior").valor);

            List<Catalogo> listaCatalogos = neg_Catalogo.obtenerTodos();


            
            
            //int heightBoton =(panMenu.Height / listaCatalogos.Count)-(margenYMenu);
             
            int widthBoton = ancho_panel_izquierdo;
            
            panMenu.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            
            //panMenu.Width = anchoPanelIzq;
            //panMenu.Location=new Point(0, panMenu.Location.Y);

            panLateralIzq.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            panLateralIzq.Width = Sistema.obtenerConfiguracionInt("ancho_panel_izquierdo");

            panSuperior.BackColor = Sistema.obtenerConfiguracionColor("color_barra_superior");
            iconSalir.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            iconMaximizar.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            iconMinimizar.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            iconVentana.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            iconColapsarMenu.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_primario");
            



            for (int i = 0; i < listaCatalogos.Count; i++)
            {
                int posY = (alto_boton_menu * i) + ((int)(margen_y_Menu * (i + 0.5)));
                int posX = (int)(margen_x_menu * .5);
                panMenu.Controls.Add(createButtonMenu(new Point(posX, posY), alto_boton_menu, widthBoton, listaCatalogos[i].iconoMenuFA, listaCatalogos[i].nombre));
            }
        }

        private Button createButtonMenu(Point location, double height, int width, int urlImagen,string textoBoton)
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            StlButton nuevoBoton = new StlButton();
            nuevoBoton.BorderRadius = 0;
            nuevoBoton.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_secundario");
            nuevoBoton.Text = textoBoton;
            nuevoBoton.Location = location;
            nuevoBoton.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            nuevoBoton.FlatStyle = FlatStyle.Flat;
            nuevoBoton.Width = width;
            nuevoBoton.Height = (int)height;
            
            
            nuevoBoton.IconChar = (FontAwesome.Sharp.IconChar) urlImagen;

            nuevoBoton.ImageAlign = ContentAlignment.MiddleLeft;
            nuevoBoton.IconSize = escala_icono_menu;
            nuevoBoton.IconColor = Sistema.obtenerConfiguracionColor("color_texto_secundario");

            nuevoBoton.Font = new Font(FontFamily.GenericSansSerif, 15);

            nuevoBoton.FlatAppearance.MouseOverBackColor = Sistema.obtenerConfiguracionColor("color_secundario");
            nuevoBoton.MouseEnter += (object sender, EventArgs e) => { ((StlButton)sender).ForeColor = Sistema.obtenerConfiguracionColor("color_primario"); ((StlButton)sender).IconColor = Sistema.obtenerConfiguracionColor("color_primario"); };
            nuevoBoton.MouseLeave += (object sender, EventArgs e) => { ((StlButton)sender).ForeColor = Sistema.obtenerConfiguracionColor("color_texto_secundario"); ((StlButton)sender).IconColor = Sistema.obtenerConfiguracionColor("color_texto_secundario"); };

            nuevoBoton.Click += (object sender, EventArgs e) => { AbrirFormulario<frmCatalogo>("Catalogo",textoBoton); };

            return nuevoBoton;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panLateralIzq.Width == ancho_panel_izquierdo)
            {
                panLateralIzq.Width = ancho_panel_colapsado;
            }
            else
            {
                panLateralIzq.Width = ancho_panel_izquierdo;
            }
        }

        private void panMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
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

        private void iconVentana_Click(object sender, EventArgs e)
        {
            this.Size = new Size(ancho_pantalla_default,alto_pantalla_default);
            this.Location = new Point(lx,ly);
            iconVentana.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
