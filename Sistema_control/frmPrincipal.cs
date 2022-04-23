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


namespace Sistema_control
{
    public partial class frmPrincipal : Form
    {
        private int anchoMenu = 300;
        private int anchoPanelColapsado = 75;
        private int anchoPanelIzq;
        private int margenMenu = 10;
        private int tamañoIconoMenu = 55;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            anchoPanelIzq = anchoMenu + (margenMenu * 2);
            crearMenu();
        }

        private void crearMenu()
        {
            List<Configuracion> config = neg_Configuracion.buscar(new Configuracion(tipoParametro:"sistema"));
            Color colorPrimario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_primario").valor2);
            Color colorSecundario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_secundario").valor2);
            Color colorTexto = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_texto_primario").valor2);
            Color colorTextoSecundario = System.Drawing.ColorTranslator.FromHtml(config.Find(conf => conf.nombreParametro == "color_texto_secundario").valor2);
            int numeroBotones = 8;
            
            int heightBoton =(panMenu.Height / numeroBotones)-(margenMenu);
            int widthBoton = anchoPanelIzq;
            
            panMenu.BackColor = colorPrimario;
            panMenu.Width = anchoPanelIzq;
            panMenu.Location=new Point(0, panMenu.Location.Y);
            
            panLateralIzq.BackColor = colorPrimario;
            panLateralIzq.Width = anchoPanelIzq;

            int url =62119;

            for (int i = 0; i < numeroBotones; i++)
            {
                int posY = (heightBoton * i) + ((int)(margenMenu * (i + 0.5)));
                int posX = (int)(margenMenu * .5);
                panMenu.Controls.Add(createButtonMenu(new Point(posX,posY),heightBoton,widthBoton, colorPrimario,colorSecundario, colorTextoSecundario,url+i));
            }
        }

        private Button createButtonMenu(Point location, double height, int width, Color colorPrimario,Color colorSecundario,Color texto, int urlImagen)
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;


            StlButton nuevoBoton = new StlButton();
            nuevoBoton.BorderRadius = 0;
            nuevoBoton.ForeColor = texto;
            nuevoBoton.Text = "Nuevo Botón";
            nuevoBoton.Location = location;
            nuevoBoton.BackColor = colorPrimario;
            nuevoBoton.FlatStyle = FlatStyle.Flat;
            nuevoBoton.Width = width;
            nuevoBoton.Height = (int)height;
            
            
            nuevoBoton.IconChar = (FontAwesome.Sharp.IconChar) urlImagen;

            nuevoBoton.ImageAlign = ContentAlignment.MiddleLeft;
            nuevoBoton.IconSize = tamañoIconoMenu;
            nuevoBoton.IconColor = texto;

            nuevoBoton.Font = new Font(FontFamily.GenericSansSerif, 15);

            nuevoBoton.FlatAppearance.MouseOverBackColor = colorSecundario;
            nuevoBoton.MouseEnter += (object sender, EventArgs e) => { ((StlButton)sender).ForeColor = colorPrimario; ((StlButton)sender).IconColor = colorPrimario; };
            nuevoBoton.MouseLeave += (object sender, EventArgs e) => { ((StlButton)sender).ForeColor = texto; ((StlButton)sender).IconColor = texto; };

            return nuevoBoton;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panLateralIzq.Width == anchoPanelIzq)
            {
                panLateralIzq.Width = anchoPanelColapsado;
            }
            else
            {
                panLateralIzq.Width = anchoPanelIzq;
            }
        }
    }
}
