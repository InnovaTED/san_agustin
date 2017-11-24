using SwJugueriaAgustin.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwJugueriaAgustin.Formularios
{
    public partial class frmProductosPrimos : Form
    {
        Funciones fn = new Funciones();
        string codProducto;
        bool editar;

        public frmProductosPrimos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (editar == true)
                {
                    fn.Modificar("ProductoPrimo", "Producto='" + txtProducto.Text + "',IDUniMedida='" + cbxuniMedida.SelectedValue + "',PrecioCompra='" + txtPreCompra.Text + "'", "IDProductoPrimo='"+codProducto+"'");
                    editar = false;
                }
                else
                {
                    int Existe = Convert.ToInt32(fn.select_one_value("count(*)", "ProductoPrimo", "Producto = '" + txtProducto.Text + "'", 0));
                    if (Existe > 0)
                    {
                        error.SetError(txtProducto, "Producto ya registrado");
                        return;
                    }
                    error.Clear();
                    fn.Registrar("ProductoPrimo", "'" + txtProducto.Text + "','" + cbxuniMedida.SelectedValue + "','" + txtPreCompra.Text + "'");
                }
                limpiar();
                mostrarGrid();
                MessageBox.Show("Operacion Correcta","San Agustin",MessageBoxButtons.OK,MessageBoxIcon.Information);
                bloqueo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void frmProductosPrimos_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            bloqueo();
            mostrarGrid();
            fn.añadir_ddl("UniMedida", "IDUniMedida", "UnidadMedida", cbxuniMedida);
        }


        private void limpiar()
        {
            txtPreCompra.Text = "";
            txtProducto.Text = "";
            
            cbxuniMedida.Text = "";
            error.Clear();
        }

        private void mostrarGrid()
        {
            fn.MostrarGri("p.Producto,u.UniMedida,p.PrecioCompra", "ProductoPrimo p, UnidadMedida u", "p.IDUniMedida=u.IDUniMedida", dataGridView1, "ProductoPrimo");
        }



        private void bloqueo()
        {
            gbxDatos.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnNuevo.Select();
            
            txtPreCompra.Text = "0";
        }

        private void desbloqueo()
        {
            gbxDatos.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            txtProducto.Focus();
            txtPreCompra.Text = "0";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            desbloqueo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            codProducto = fn.select_one_value("IDProductoPrimo", "ProductoPrimo", "Producto='" + txtProducto.Text + "'", 0);            
            cbxuniMedida.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPreCompra.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            editar = true;
            desbloqueo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bloqueo();
            limpiar();
        }
    }
}
