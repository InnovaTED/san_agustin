using SwJugueriaAgustin.Clases;
using System;
using InputKey;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SwJugueriaAgustin.Formularios
{
    public partial class frmVenta : Form
    {
        Funciones fn = new Funciones();
        bool Delibery;
        string preconex = Clases.Funciones.preconex;

        public frmVenta()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.F5)
                {
                    lb1.Visible = true;
                    lb2.Visible = true;
                    lb3.Visible = true;
                    lb4.Visible = true;
                    lb5.Visible = true;
                    lb6.Visible = true;
                    return;
                }
                if (e.KeyCode == Keys.F6)
                {
                    lb1.Visible = false;
                    lb2.Visible = false;
                    lb3.Visible = false;
                    lb4.Visible = false;
                    lb5.Visible = false;
                    lb6.Visible = false;
                    return;
                }
                if (e.KeyCode == Keys.F1)
                {
                    txtProducto.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F2)
                {
                    txtTelefono.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F3)
                {
                    txtEfectivo.Focus();
                    return;
                }
                if (e.KeyCode == Keys.F4)
                {
                    Guardar();
                    return;
                }
                if (e.KeyCode == Keys.F7)
                {
                    cbTipo.SelectedIndex = 0;
                    return;
                }
                if (e.KeyCode == Keys.F8)
                {
                    cbTipo.SelectedIndex = 1;
                    return;
                }
            };
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            MostrarGridProducto();
        }


        private void MostrarGridProducto()
        {
            fn.MostrarGri(/*SELECT*/"P.IDProducto,PP.IDPresentacion,P.Nombre+' '+pp.Presentacion as PRODUCTO,C.Condicion AS CONDICION,PP.Precio",
                           /*FROM */"Productos P,Presentacion PP,CondicionProducto C",
                           /*WHERE*/"P.IDCondicion = c.IDCondicion AND PP.IDProducto = P.IDProducto AND P.Nombre+' '+pp.Presentacion LIKE '%"+txtProducto.Text+"%'", dgvProductos, "Productos");
        }

        private void dgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProductos.RowCount == 0)
                    {
                        DialogResult msj = MessageBox.Show("Seleccione un Producto", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {


                        //Fila Seleccionada
                        int select = dgvProductos.CurrentRow.Index;

                        string codProducto = dgvProductos.Rows[select].Cells[0].Value.ToString();
                        string codPresentacion = dgvProductos.Rows[select].Cells[1].Value.ToString();
                        string Producto = dgvProductos.Rows[select].Cells[2].Value.ToString();
                        float cantidad = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad", "San Agustin", "", 100, 100));//Convert.ToSingle(InputDialog.mostrar("Ingresa Cantidad"));

                        float Precio = Convert.ToSingle(dgvProductos.Rows[select].Cells[4].Value.ToString());
                        float subTotal = cantidad * Precio;

                        dgvDeatalle.Rows.Add(codProducto, codPresentacion, Producto, cantidad, Precio, subTotal, "+", "x");

                        CalcularTotal();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            cbTipo.Focus();
            fn.Maximizar(this);
            GenerarCodVenta();
            //CARGAR COMBO
            fn.añadir_ddl("IDProcesoTienda", "IDProcesoTienda", "ProcesoTienda", cbTipo);
            fn.añadir_ddl("Almacen","IDAlmacen", "almacen where PuedeVender = 1", cbAlmacen);
            cbTipo.SelectedIndex = 1;
        }


        private void GenerarCodVenta()
        {
            int codVenta = Convert.ToInt32(fn.select_one_value("IDAyuda", "Ayuda", "Descripcion='Venta'", 0));
            lblCodVenta.Text = (codVenta + 1).ToString();
        }


        private void CalcularTotal()
        {
            short Longitud = Convert.ToInt16(dgvDeatalle.RowCount);

            float Total = 0;
            float SubTotal = 0;
            float IGV = 0;

            for(int i=0;i<Longitud;i++)
            {
                Total = Total + Convert.ToSingle(dgvDeatalle.Rows[i].Cells[5].Value);
            }

            SubTotal = Total / 1.18f;
            IGV = SubTotal * 0.18f;

            //MOSTRAOS LOS CALCULOS
            lblTotal.Text = Math.Round(Total,2).ToString();
            lblSubTotal.Text = Math.Round(SubTotal, 2).ToString();
            lblIGV.Text = Math.Round(IGV, 2).ToString();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void DescontarStockProducto()
        {
            int CodVentaRealizada = Convert.ToInt32(lblCodVenta.Text);
            string IDProducto = "";
            string CantidadReceta = "";
            double CantidadVenta;
            //string UltimoSaldo
            foreach (DataGridViewRow row in dgvDeatalle.Rows)
            {
                SqlConnection conexion = new SqlConnection(preconex);
                string oncod = "select IDProductoPrimo as [ProductoPrimo],Cantidad from Receta where IDPresentacion = '" + row.Cells["cnCodPresen"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(oncod, conexion);
                conexion.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    IDProducto = lector["ProductoPrimo"].ToString();
                    CantidadReceta = lector["Cantidad"].ToString();
                    CantidadVenta = Convert.ToDouble(row.Cells["cnCantidad"].Value);

                    //REGISTRAR VENTA EN EL KARDEX
                    fn.Registrar("Kardex", "'"+DateTime.Now.ToShortDateString()+"','VENTA','"+ CodVentaRealizada + "','0','"+ Convert.ToDouble(CantidadReceta) * CantidadVenta + "',(select top(1)saldo from Kardex where IDProductoPrimo = '" +IDProducto+"' order by IDKardex desc)-("+ (Convert.ToDouble(CantidadReceta) * CantidadVenta) +"),'"+IDProducto+"','"+cbAlmacen.SelectedValue+"'");
                    fn.Modificar("AlmacenProductos", "Stock = stock - " + Convert.ToDouble(CantidadReceta)* CantidadVenta, "IDProductoPrimo='" + IDProducto + "' and IDAlmacen = '"+cbAlmacen.SelectedValue+"'");
                }
                conexion.Close();
            }
        }
        private void Guardar()
        {
            string hora = DateTime.Now.ToLongTimeString();

            if (cbTipo.Text == "VentaDelivery")
            {
                string idCliente = fn.select_one_value("IDCliente", "Cliente", "Numero='" + txtNumero.Text + "'", 0);
                fn.Registrar("Venta", "'" + lblCodVenta.Text + "','" + dateTimePicker1.Value + "','" + hora + "','" + lblIGV.Text + "','" + lblSubTotal.Text + "','" + lblTotal.Text + "','"+cbTipo.SelectedValue +"','False','" + idCliente + "'");
            }
            else
            {
                fn.Registrar("Venta", "'" + lblCodVenta.Text + "','" + dateTimePicker1.Value + "','" + hora + "','" + lblIGV.Text + "','" + lblSubTotal.Text + "','" + lblTotal.Text + "','" + cbTipo.SelectedValue + "','True','1'");
            }

            for (short i = 0; i < dgvDeatalle.RowCount; i++)
            {
                string codProducto = dgvDeatalle.Rows[i].Cells[0].Value.ToString();
                string codPresentacion = dgvDeatalle.Rows[i].Cells[1].Value.ToString();
                string cantidad = dgvDeatalle.Rows[i].Cells[3].Value.ToString();

                fn.Registrar("DetalleVenta", "'" + lblCodVenta.Text + "','" + codProducto + "','" + codPresentacion + "','" + cantidad + "'");
            }
            AumentarCodVenta();
            GenerarCodVenta();

            DescontarStockProducto();
            MessageBox.Show("Venta Realizada. Operacion Correcta", ".::San Agustin::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDeatalle.Rows.Clear();
            txtEfectivo.Clear();
        }

        private void AumentarCodVenta()
        {
            int codVenta = Convert.ToInt32(fn.select_one_value("IDAyuda", "Ayuda", "Descripcion='Venta'", 0)) + 1;
            fn.Modificar("Ayuda","IDAyuda='"+codVenta+"'", "Descripcion='Venta'");
        }

        private void dgvDeatalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDeatalle.CurrentRow.Index;
            if(dgvDeatalle.Rows[i].Cells[6].Selected == true)
            {
                dgvDeatalle.Rows[i].Cells[3].Value = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[3].Value) + 1;
                float cantidad = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[3].Value);
                float Precio = Convert.ToInt16(dgvDeatalle.Rows[i].Cells[4].Value);

                float SubTotal = cantidad * Precio;
                dgvDeatalle.Rows[i].Cells[5].Value = SubTotal;

                CalcularTotal();
            }

            if (dgvDeatalle.Rows[i].Cells[7].Selected == true)
            {
                DialogResult msj = MessageBox.Show("Desea Quitar el Producto", ".::SISTEMA::.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(msj == DialogResult.OK)
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
            catch(Exception ex)
            {
                if(txtEfectivo.Text != "")
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtNumero.Text == "")
                {
                    FrmClientes frm = new FrmClientes();
                    frm.ShowDialog();
                }
                else
                {
                    if (fn.Existencia("*", "Cliente", "Numero='" + txtNumero.Text + "'") == true)
                    {
                        txtNombre.Text = fn.select_one_value("Nombre", "Cliente", "Numero='" + txtNumero.Text + "'", 0);
                        txtTelefono.Text = fn.select_one_value("Telefono", "Cliente", "Numero='" + txtNumero.Text + "'", 0);
                        txtDireccion.Text = fn.select_one_value("Direccion", "Cliente", "Numero='" + txtNumero.Text + "'", 0);
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
                try
                {
                    if (fn.Existencia("*", "Cliente", "Telefono='" + txtTelefono.Text + "'") == true)
                    {
                        txtNumero.Text = fn.select_one_value("Numero", "Cliente", "Telefono='" + txtTelefono.Text + "'", 0);
                        txtNombre.Text = fn.select_one_value("Nombre", "Cliente", "Telefono='" + txtTelefono.Text + "'", 0);
                        txtDireccion.Text = fn.select_one_value("Direccion", "Cliente", "Telefono='" + txtTelefono.Text + "'", 0);
                        txtDireccion.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente existe", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                }
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult msj = MessageBox.Show("Debe Registrar al cliente. Por que no se encuentra en su Base de Datos", ".::San Agustin::.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(msj == DialogResult.OK)
                {
                    fn.Registrar("Cliente", "'" + txtNombre.Text + "','" + txtNumero.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "'");
                    MessageBox.Show("Cliente Registrado", ".::San Agustin::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEfectivo.Focus();
                }
                
            }
        }

        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Guardar();
            }
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipo.Text == "VentaDelivery")
            {
                gbxCliente.Visible = true;
                Delibery = true;
                txtNumero.Focus();
                lblcliente.Visible = true;
            }
            else
            {
                gbxCliente.Visible = false;
                Delibery = false;
                lblcliente.Visible = false;
            }
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvProductos.Focus();
            }
        }
    }
}
