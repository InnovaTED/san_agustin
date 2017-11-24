using SwJugueriaAgustin.Clases;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SwJugueriaAgustin.Formularios
{
    public partial class frmAlmacenProductos : Form
    {
        //Intancia a la clase
        Funciones fn = new Funciones();
        public frmAlmacenProductos()
        {
            InitializeComponent();
        }

        private void MostrarCombo()
        {
            fn.añadir_ddl("Almacen", "IDAlmacen", "Almacen", cbxAlmacen);
        }
        private void frmAlmacenProductos_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            MostrarCombo();
            cbxAlmacen.Focus();
        }

        private void cbxAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarGrid();
        }

        private void MostrarGrid()
        {
            fn.MostrarGri("pp.Producto,u.UniMedida,pp.PrecioCompra,ap.Stock,ap.StockMin,ap.StockMax",
                          "AlmacenProductos ap,ProductoPrimo pp,UnidadMedida u,Almacen a",
                          "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.IDUniMedida = u.IDUniMedida and a.Almacen = '" + cbxAlmacen.Text + "'", dgvProductoAlmacen, "AlmacenProductos");
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            fn.MostrarGri("Producto,UniMedida,PrecioCompra", "ProductoPrimo p,UnidadMedida u", "p.IDUniMedida=u.IDUniMedida and Producto like '%"+txtbuscar.Text+"%'", dgvProductosPrimos, "ProductoPrimo");
        }

        private void dgvProductosPrimos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    string producto = dgvProductosPrimos.CurrentRow.Cells[0].Value.ToString();
                    //Si el produto que queremos ingresar existe
                    if (fn.Existencia("pp.Producto,u.UniMedida,pp.PrecioCompra,ap.Stock,ap.StockMin,ap.StockMax", "AlmacenProductos ap,ProductoPrimo pp,UnidadMedida u,Almacen a", "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.IDUniMedida = u.IDUniMedida and a.Almacen = '" + cbxAlmacen.Text + "' and Producto = '" + producto + "'") == true)
                    {
                        MessageBox.Show("El Producto que Desea Agregar Ya Existe. Verificar", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtbuscar.Focus();
                    }
                    //caso que no exista registrara
                    else
                    {
                        DialogResult msj = MessageBox.Show("Desea Agregar este Producto al Almacen", "San Agustin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (msj == DialogResult.OK)
                        {
                            string cantidad = Interaction.InputBox("Ingrese la cantidad de Stock", "San Agustin", "0", 400, 300);
                            string stockMin = Interaction.InputBox("Ingrese el Stock Minimo", "San Agustin", "0", 400, 300);
                            string stockMax = Interaction.InputBox("Ingrese el Stock Maximo", "San Agustin", "0", 400, 300);
                            fn.Registrar("AlmacenProductos", "'" + cbxAlmacen.SelectedValue + "',(SELECT IDProductoPrimo from ProductoPrimo where Producto = '" + producto + "'),'" + cantidad + "','" + stockMin + "','" + stockMax + "'");
                            MessageBox.Show("Operacion Correcta", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarGrid();
                            txtbuscar.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dgvProductosPrimos.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult msj = MessageBox.Show("Desea quitar del " + cbxAlmacen.Text + " el producto seleccionado", "San Agustin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(msj == DialogResult.OK)
            {
                string producto = dgvProductoAlmacen.CurrentRow.Cells[0].Value.ToString();
                fn.Eliminar("AlmacenProductos", "IDAlmacen='" + cbxAlmacen.SelectedValue + "' and IDProductoPrimo=(SELECT IDProductoPrimo from ProductoPrimo where Producto='" + producto + "')");
                MostrarGrid();
                txtbuscar.Focus();
            }
        }

        private void cbxAlmacen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtbuscar.Focus();
            }
        }
    }
}
