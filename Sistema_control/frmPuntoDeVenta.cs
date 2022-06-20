using ly_modelo;
using ly_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Sistema_control
{
    public partial class frmPuntoDeVenta : Form
    {

        public List<Producto> listaProductos;
        private Orden ordenEnCurso = null;
       

        public frmPuntoDeVenta()
        {
            InitializeComponent();
            personalizarVentana();
            this.listaProductos = neg_UIElements.obtenerProductos();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            foreach (Producto producto in listaProductos)
            {
                autoComplete.Add(producto.codigo + " - " + producto.producto);
            }
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBuscarProducto.AutoCompleteCustomSource = autoComplete;
            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        private void frmPuntoDeVenta_Load(object sender, EventArgs e)
        {
            
            
        }


        private void personalizarVentana()
        {

            btnPagar.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnBajarArticulo.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnDescuento.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnEliminarArticulo.BackColor = Sistema.obtenerConfiguracionColor("color_primario");
            btnSubirArticulo.BackColor = Sistema.obtenerConfiguracionColor("color_primario");

            btnCancelarCompra.BackColor = Sistema.obtenerConfiguracionColor("color_texto_boton_cancelar");


            dgv_Articulos.BackgroundColor= Sistema.obtenerConfiguracionColor("color_primario");

            dgv_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Articulos.DefaultCellStyle.SelectionBackColor = Sistema.obtenerConfiguracionColor("color_primario");
            dgv_Articulos.DefaultCellStyle.SelectionForeColor = Sistema.obtenerConfiguracionColor("color_texto_secundario");

            dgv_Articulos.BackgroundColor = Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            dgv_Articulos.DefaultCellStyle.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_primario");
            dgv_Articulos.GridColor = Sistema.obtenerConfiguracionColor("color_fondo_sistema");
            dgv_Articulos.EnableHeadersVisualStyles = false;
            dgv_Articulos.ColumnHeadersDefaultCellStyle.BackColor = Sistema.obtenerConfiguracionColor("color_barra_superior");
            dgv_Articulos.ColumnHeadersDefaultCellStyle.ForeColor = Sistema.obtenerConfiguracionColor("color_texto_barra_superior");
            dgv_Articulos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Sistema.obtenerConfiguracionColor("color_primario");
            dgv_Articulos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Articulos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_Articulos.ColumnHeadersHeight = 30;
            dgv_Articulos.RowHeadersVisible = false;

            dgv_Articulos.MultiSelect = false;
            dgv_Articulos.AllowUserToAddRows = false;
            dgv_Articulos.AllowUserToDeleteRows = false;
            

            dgv_Articulos.BorderStyle = BorderStyle.None;


        }


        private void btnCerrarCatalogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {


        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {

                if (txtBuscarProducto.Text.Length > 0)
                {
                    string codigoProducto = txtBuscarProducto.Text.Split("-")[0].Trim();
                    bool yaAgregado = false;
                    int index = -1;
                    if (dgv_Articulos.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow articulo in dgv_Articulos.Rows)
                        {
                            if (articulo.Cells[0].Value!= null && articulo.Cells[0].Value.ToString() == codigoProducto)
                            {
                                yaAgregado = true;
                                index = articulo.Index;
                            }
                        }
                    }
                    if (yaAgregado)
                    {
                        dgv_Articulos.Rows[index].Cells["Cantidad"].Value = int.Parse(dgv_Articulos.Rows[index].Cells["Cantidad"].Value.ToString()) + 1;
                        txtBuscarProducto.Text = "";
                    }
                    else
                    {
                        Producto producto = listaProductos.FirstOrDefault(producto => producto.codigo == codigoProducto);
                        if (producto !=null)
                        {
                            dgv_Articulos.Rows.Add(producto.idProducto,producto.codigo, producto.producto, producto.precio, producto.precio, 1, producto.precio,"Activo");
                            txtBuscarProducto.Text = "";
                            dgv_Articulos.Rows[dgv_Articulos.Rows.Count - 1].Selected=true;
                        }
                    }
                }

            }
        }

        private void dgv_Articulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            if (dgv_Articulos.SelectedRows.Count>0)
            {
                if (dgv_Articulos.SelectedRows[0].Cells["Estatus"].Value.ToString().Equals("Activo"))
                {
                    dgv_Articulos.Rows[dgv_Articulos.SelectedRows[0].Index].Cells["Estatus"].Value = "Eliminado";
                    btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Rev;
                    calcularTotales();

                }
                else if (dgv_Articulos.SelectedRows[0].Cells["Estatus"].Value.ToString().Equals("Eliminado"))
                {
                    dgv_Articulos.Rows[dgv_Articulos.SelectedRows[0].Index].Cells["Estatus"].Value = "Activo";
                    btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Minus;
                    calcularTotales();
                }

            }
        }

        private void dgv_Articulos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            calcularTotales();
        }

        public void calcularTotales()
        {
            if (dgv_Articulos.Rows.Count > 0)
            {
                double totalTotal = 0, decuentoTotal = 0, totalSinDescuentoVenta = 0;
                foreach (DataGridViewRow articulo in dgv_Articulos.Rows)
                {
                    if (articulo.Cells["Estatus"].Value.ToString().Equals("Activo"))
                    {
                        double precioCatalogo = double.Parse(articulo.Cells["PrecioCatalogo"].Value.ToString());
                        double precioVenta = double.Parse(articulo.Cells["PrecioVenta"].Value.ToString());
                        double cantidad = double.Parse(articulo.Cells["Cantidad"].Value.ToString());

                        double totalVentaArticulo = precioVenta * cantidad;
                        double totalSinDescuentosArticulo = precioCatalogo * cantidad;
                        double descuentoArticulo = (precioCatalogo - precioVenta) * cantidad;

                        totalTotal += totalVentaArticulo;
                        decuentoTotal += descuentoArticulo;
                        totalSinDescuentoVenta += totalSinDescuentosArticulo;

                        articulo.Cells["Total"].Value = totalVentaArticulo.ToString();
                    }


                }
                lblTotalCompra.Text = totalTotal.ToString();
                lblDescuentoCompra.Text = decuentoTotal.ToString();
                lblSubTotalCompra.Text = totalSinDescuentoVenta.ToString();
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            bool listoParaPago = true;
            if (this.ordenEnCurso==null)
            {
                this.ordenEnCurso = neg_Ordenes.agregar(Sistema.usuarioSesion.idUsuario);
            }

            if (dgv_Articulos.Rows.Count >0 && ordenEnCurso!=null)
            {
                foreach (DataGridViewRow articulo in dgv_Articulos.Rows)
                {
                    if (!neg_Ordenes.agregarProductoAOrden(int.Parse(articulo.Cells["idPRoducto"].Value.ToString()),int.Parse(articulo.Cells["Cantidad"].Value.ToString()),double.Parse(articulo.Cells["PrecioVenta"].Value.ToString()),articulo.Cells["Estatus"].Value.ToString(),this.ordenEnCurso))
                    {
                        MessageBox.Show("Ocurrió un error al agregar producto a orden");
                        break;
                        listoParaPago = false;
                    }

                }
            }
            else
            {

                if (ordenEnCurso == null)
                {
                    MessageBox.Show("Ocurrió un problema con la orden");
                }
                else
                {
                    MessageBox.Show("No hay articulos en la orden");

                }
                listoParaPago = false;
            }

            if (listoParaPago)
            {
                frmPagar nuevoForm = new frmPagar(ordenEnCurso,double.Parse(lblTotalCompra.Text));
                if (nuevoForm.ShowDialog() == DialogResult.OK)
                {
                    limpiar();
                }
            }


        }

        private void limpiar()
        {
            dgv_Articulos.Rows.Clear();
            lblDescuentoCompra.Text = "0.00";
            lblSubTotalCompra.Text = "0.00";
            lblTotalCompra.Text = "0.00";
            this.ordenEnCurso = null;
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Articulos.Rows.Count>0 && dgv_Articulos.SelectedRows.Count>0)
            {
                if (dgv_Articulos.SelectedRows[0].Cells["Estatus"].Value.ToString().Equals("Activo"))
                {
                    btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Minus;
                }
                else if (dgv_Articulos.SelectedRows[0].Cells["Estatus"].Value.ToString().Equals("Eliminado"))
                {
                    btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Rev;
                }
            }
            else
            {
                btnEliminarArticulo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            if (this.ordenEnCurso!=null)
            {
                if (MessageBox.Show("Cancelar orden","¿Desea cancelar la orden "+ ordenEnCurso.orden +"?",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    if (neg_Ordenes.cancelarOrden(this.ordenEnCurso))
                    {
                        limpiar();
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Cancelar orden", "¿Desea cancelar la orden?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                        limpiar();
                }
            }
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            if (dgv_Articulos.Rows.Count>0 && dgv_Articulos.SelectedRows.Count>0)
            {
                frmDescuento fDescuento = new frmDescuento();
                if (fDescuento.ShowDialog()==DialogResult.OK)
                {
                    double precio = double.Parse(dgv_Articulos.SelectedRows[0].Cells["PrecioCatalogo"].Value.ToString());
                    decimal descuento = fDescuento.descuento;
                    dgv_Articulos.SelectedRows[0].Cells["PrecioVenta"].Value = (((100 - (int)descuento) * precio) / 100).ToString();
                }
            }
        }
    }
}
