using SwJugueriaAgustin.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwJugueriaAgustin.Formularios
{
    public partial class frmCompra : Form
    {
        Funciones fn = new Funciones();
        public frmCompra()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    txtNumero.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F2)
                {
                    txtProducto.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F3)
                {
                    txtSerie.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F4)
                {
                    Guardar();
                    return;
                }
                if (e.KeyCode == Keys.F5)
                {
                    lb1.Visible = true;
                    lb2.Visible = true;
                    lb3.Visible = true;
                    lb4.Visible = true;
                    return;
                }
                if (e.KeyCode == Keys.F6)
                {
                    lb1.Visible = false;
                    lb2.Visible = false;
                    lb3.Visible = false;
                    lb4.Visible = false;
                    return;
                }
            };
        }
        string codProducto, cantidad;
        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtProducto.Text == "")
                {
                    frmProductosPrimos frm = new frmProductosPrimos();
                    frm.ShowDialog();
                }
                else
                {
                    dgvProductos.Focus();
                }
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            MostrarGridProducto();
        }

        private void MostrarGridProducto()
        {
            fn.MostrarGri(/*SELECT*/"IDProductoPrimo as Cod,Producto,u.UniMedida,p.PrecioCompra",
                           /*FROM */"ProductoPrimo p, UnidadMedida u",
                           /*WHERE*/"p.IDUniMedida = u.IDUniMedida and Producto like '%" + txtProducto.Text + "%'", dgvProductos, "ProductoPrimoAlmacen");
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            float stock, stocktotal;
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string codProducto = dgvProductos.CurrentRow.Cells["cod"].Value.ToString();
                    string Producto = dgvProductos.CurrentRow.Cells["Producto"].Value.ToString();

                    try
                    {
                         stock = Convert.ToSingle(fn.select_one_value("Stock", "AlmacenProductos", "IDAlmacen = '" + cbAlmacen.SelectedValue + "' and IDProductoPrimo = '" + codProducto + "'", 0));
                         stocktotal = Convert.ToSingle(fn.select_one_value("sum(stock)", "AlmacenProductos", "IDProductoPrimo = '" + codProducto + "'", 0));
                    }
                    catch (Exception)
                    {
                        stock = 0;
                        stocktotal = 0;
                    }

                    float PrecioAntiguo = Convert.ToSingle(dgvProductos.CurrentRow.Cells["PrecioCompra"].Value.ToString());
                    float cosTotalAntiguo = stocktotal * PrecioAntiguo;

                    float cantidad = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad", "San Agustin", "0", 400, 200));
                    float PrecioNuevo = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Ingrese costo de compra: ", "San Agustin", "0.00", 400, 200));
                    float cosTotalNuevo = cantidad * PrecioNuevo;

                    float costoTotal = cosTotalAntiguo + cosTotalNuevo;
                    float cantidadTotal = stocktotal + cantidad;

                    float costoPromedio = costoTotal / cantidadTotal;

                    float subTotal = costoPromedio * cantidad;

                    dgvDeatalle.Rows.Add(codProducto, Producto, cantidad, Math.Round(costoPromedio, 2), Math.Round(subTotal, 2), "+", "x");

                    CalcularTotal();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
            fn.Maximizar(this);
            GenerarCodVenta();
            txtProducto.Focus();
            fn.añadir_ddl("Almacen", "IDAlmacen", "almacen", cbAlmacen);
        }


        private void GenerarCodVenta()
        {
            int codVenta = Convert.ToInt32(fn.select_one_value("IDAyuda", "Ayuda", "Descripcion='Compra'", 0));
            lblCodCompra.Text = (codVenta + 1).ToString();
        }

        private void CalcularTotal()
        {
            short Longitud = Convert.ToInt16(dgvDeatalle.RowCount);

            float Total = 0;
            float SubTotal = 0;
            float IGV = 0;

            for (int i = 0; i < Longitud; i++)
            {
                Total = Total + Convert.ToSingle(dgvDeatalle.Rows[i].Cells[4].Value);
            }

            SubTotal = Total / 1.18f;
            IGV = SubTotal * 0.18f;

            //MOSTRAOS LOS CALCULOS
            lblTotal.Text = Math.Round(Total, 2).ToString();
            lblSubTotal.Text = Math.Round(SubTotal, 2).ToString();
            lblIGV.Text = Math.Round(IGV, 2).ToString();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Guardar();
            
            
        }


        private void limpiar()
        {
            txtcontacto.Text = "";
            txtDireccion.Text = "";
            txtEfectivo.Text = "0.00";
            txtNombre.Text = "";
            txtnum.Text = "";
            txtNumero.Text = "";
            txtProducto.Text = "";
            txtTelefono.Text = "";
            txtSerie.Text = "";

            lblCambio.Text = "0.00";
            lblTotal.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblIGV.Text = "0.00";
        }

        private void Guardar()
        {
            string hora = DateTime.Now.ToLongTimeString();
            string idProveedor="";
            try
            {
                idProveedor = fn.select_one_value("IDProveedor", "Proveedor", "Numero='" + txtNumero.Text + "'", 0);
            }
            catch (Exception ex)
            {
                error.SetError(txtNumero, "Ingrese RUC de proveedor correctamente");
                return;
            }
            error.Clear();
            

            for (short i = 0; i < dgvDeatalle.RowCount; i++)
            {
                codProducto = dgvDeatalle.Rows[i].Cells[0].Value.ToString();
                string codPresentacion = dgvDeatalle.Rows[i].Cells[1].Value.ToString();
                cantidad = dgvDeatalle.Rows[i].Cells[2].Value.ToString();

                fn.Registrar("CompraDetalle", "'" + lblCodCompra.Text + "','" + codProducto + "','" + cantidad + "'");
            }


            fn.Registrar("Compra", "'" + lblCodCompra.Text + "','" + dtpFecha.Value.ToShortDateString() + "','" + hora + "','" + idProveedor + "','" + txtSerie.Text + "','" + txtnum.Text + "','" + lblTotal.Text + "','" + lblSubTotal.Text + "','" + lblIGV.Text + "'");
            AumentarCodCompra();
            GenerarCodVenta();
            RegistrarStockalmacen();

            AumentarStockProducto();
            MessageBox.Show("Compra Realizada. Operacion Correcta", ".::San Agustin::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDeatalle.Rows.Clear();
            limpiar();
        }

        private void RegistrarStockalmacen()
        {
            int ExisteProductoAlmacen;
            ExisteProductoAlmacen = Convert.ToInt32(fn.select_one_value("count(*)", "AlmacenProductos", "IDProductoPrimo = '"+codProducto+"' and IDAlmacen = '"+ cbAlmacen.SelectedValue +"'", 0));
            if(ExisteProductoAlmacen == 0)
            {
                fn.Registrar("AlmacenProductos", "'"+cbAlmacen.SelectedValue+"','"+ codProducto + "','"+ cantidad + "','0','0'");
            }
            else
            {
                fn.Modificar("AlmacenProductos", "Stock=Stock+" + Convert.ToDouble(cantidad), "IDAlmacen= '"+cbAlmacen.SelectedValue+"' and IDProductoPrimo='"+ codProducto + "'");
            }
        }

        private void AumentarCodCompra()
        {
            int codCompra = Convert.ToInt32(fn.select_one_value("IDAyuda", "Ayuda", "Descripcion='Compra'", 0)) + 1;
            fn.Modificar("Ayuda", "IDAyuda='" + codCompra + "'", "Descripcion='Compra'");
        }

        private void AumentarStockProducto()
        {
            string CodCompraRealizada = lblCodCompra.Text;
            
            for(int i = 0;i<dgvDeatalle.RowCount;i++)
            {
                string codProducto = dgvDeatalle.Rows[i].Cells[0].Value.ToString();
                float cantidad = Convert.ToSingle(dgvDeatalle.Rows[i].Cells[2].Value.ToString());
                float precio = Convert.ToSingle(dgvDeatalle.Rows[i].Cells[3].Value.ToString());
                fn.Modificar("ProductoPrimo", "PrecioCompra='"+Math.Round(precio,2)+"'", "IDProductoPrimo='" + codProducto + "'");
                
                if(fn.Existencia("top(1)saldo", "Kardex", "IDProductoPrimo = '" + codProducto + "' order by IDKardex desc") == true)
                {
                    float saldo = Convert.ToSingle(fn.select_one_value(" top(1)saldo", "Kardex", "IDProductoPrimo = '" + codProducto + "' order by IDKardex desc", 0)) + cantidad;
                    fn.Registrar("Kardex", "'" + DateTime.Now.ToShortDateString() + "','COMPRA','" + CodCompraRealizada + "','" + cantidad + "','0','" + saldo + "','" + codProducto + "','"+cbAlmacen.SelectedValue+"'");
                }
                else
                {
                    fn.Registrar("Kardex", "'" + DateTime.Now.ToShortDateString() + "','COMPRA','" + CodCompraRealizada + "','" + cantidad + "','0','" + cantidad + "','" + codProducto + "','" + cbAlmacen.SelectedValue + "'");
                }
                
            }
        }

        
        private void dgvDeatalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDeatalle.CurrentRow.Index;
            if (dgvDeatalle.Rows[i].Cells[5].Selected == true)
            {
                dgvDeatalle.Rows[i].Cells[2].Value = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[2].Value) + 1;
                float cantidad = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[2].Value);
                float Precio = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[3].Value);

                float SubTotal = cantidad * Precio;
                dgvDeatalle.Rows[i].Cells[4].Value = SubTotal;

                CalcularTotal();
            }

            if (dgvDeatalle.Rows[i].Cells[6].Selected == true)
            {
                DialogResult msj = MessageBox.Show("Desea Quitar el Producto", ".::SISTEMA::.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msj == DialogResult.OK)
                {
                    dgvDeatalle.Rows.Remove(dgvDeatalle.Rows[i]);
                    CalcularTotal();
                }
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float Total = Convert.ToSingle(lblTotal.Text);
                float efectivo = Convert.ToSingle(txtEfectivo.Text);

                float cambio = efectivo - Total;
                lblCambio.Text = Math.Round(cambio, 2).ToString();

            }
            catch (Exception ex)
            {
                if (txtEfectivo.Text != "")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNumero.Text == "")
                {
                    // frm = new FrmClientes();
                    //frm.ShowDialog(); //PROVEEDORES
                }
                else
                {
                    if (fn.Existencia("*", "Proveedor", "Numero='" + txtNumero.Text + "'") == true)
                    {
                        txtNombre.Text = fn.select_one_value("RazonSocial", "Proveedor", "Numero='" + txtNumero.Text + "'", 0);
                        txtTelefono.Text = fn.select_one_value("Telefono", "Proveedor", "Numero='" + txtNumero.Text + "'", 0);
                        txtDireccion.Text = fn.select_one_value("Direccion", "Proveedor", "Numero='" + txtNumero.Text + "'", 0);
                        txtcontacto.Text = fn.select_one_value("Contacto", "Proveedor", "Numero='" + txtNumero.Text + "'", 0);
                        txtSerie.Focus();
                    }
                    else
                    {
                        txtNombre.Focus();
                    }
                }

            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcontacto.Focus();
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (fn.Existencia("*", "Proveedor", "Numero='" + txtNumero.Text + "'") == false)
                {
                    DialogResult msj = MessageBox.Show("Debe Registrar al Proveedor. Por que no se encuentra en su Base de Datos", ".::San Agustin::.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (msj == DialogResult.OK)
                    {
                        fn.Registrar("Proveedor", "'" + txtNumero.Text + "','" + txtNombre.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "','"+txtcontacto.Text+"'");
                        MessageBox.Show("Proveedor Registrado", ".::San Agustin::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSerie.Focus();
                    }
                }
            }
        }

        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guardar();
            }
        }

        private void txtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtnum.Focus();
            }
        }

        private void txtnum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEfectivo.Focus();
            }
        }

        private void txtcontacto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDireccion.Focus();
            }
        }
    }
}
