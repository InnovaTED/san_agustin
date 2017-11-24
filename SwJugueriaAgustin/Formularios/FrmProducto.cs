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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        Clases.Funciones fn = new Clases.Funciones();
        bool Guardar=true;
        int IDProducto;
        int IDProductoPresentacion;
        int idPresentacion;
        private void CargarGrid()
        {
            fn.MostrarGri("*", "Productos", "IDProducto>0", dgProductos, "Productos order by IDProducto");
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            fn.Maximizar(this);
            CargarGrid();
            Desbloquear(false);
            //Cargar Combo
            fn.añadir_ddl("Condicion", "IDCondicion", "CondicionProducto", cbTipo);
        }
        private void Desbloquear(bool i)
        {
            txtnombre.Enabled = i;
            txtDescripcion.Enabled = i;
            cbTipo.Enabled = i;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Guardar == true)
            {
                fn.Registrar("Productos", "'" + txtnombre.Text + "','" + txtDescripcion.Text.TrimEnd() + "','" + cbTipo.SelectedValue + "'");
                if (dgPresentacion.Rows.Count == 0)
                { return; }

                string CodigoProducto = fn.select_one_value("max(IDProducto)", "Productos", "IDProducto!=0", 0);

                foreach (DataGridViewRow row in dgPresentacion.Rows)
                {
                    fn.Registrar("Presentacion", "'"+ CodigoProducto+"','"+ row.Cells["Nombre"].Value.ToString() + "','" + row.Cells["Costo"].Value.ToString() + "','" + row.Cells["Precio"].Value.ToString()+"'");
                }

            }
            else
            {
                fn.Modificar("Productos", "Nombre='"+txtnombre.Text.TrimEnd()+"',Descripcion='"+txtDescripcion.Text.TrimEnd()+"',IDCondicion='" + cbTipo.SelectedValue + "'", "IDProducto='"+ IDProducto + "'");
            }
            CargarGrid();
            Desbloquear(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgProductos.Rows.Count==0)
            {
                MessageBox.Show("No hay datos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            fn.Eliminar("Presentacion", "IDProducto = '" + dgProductos.CurrentRow.Cells[0].Value.ToString() + "'");
            fn.Eliminar("Productos", "IDProducto='" + dgProductos.CurrentRow.Cells[0].Value.ToString() + "'");
        }
        private string Grid(string i)
        {
            return dgProductos.CurrentRow.Cells[i].Value.ToString();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = Grid("Nombre");
            txtDescripcion.Text = Grid("Descripcion");
            cbTipo.SelectedValue = Convert.ToInt32(Grid("IDCondicion"));
            IDProducto = Convert.ToInt32(Grid("IDProducto"));
            Desbloquear(true);

            Guardar = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Desbloquear(true);
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            dgPresentacion.Rows.Add(txtNombrePresentacion.Text, txtCosto.Text, txtPrecio.Text);
            txtNombrePresentacion.Text = "";
            txtCosto.Text = "";
            txtPrecio.Text = "";
        }

        private void dgProductos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            foreach (DataGridViewRow row in dgProductos.SelectedRows)
            {
                fn.MostrarGri("*", "[Presentacion]", "IDProducto = '" + row.Cells["IDProducto"].Value.ToString() + "'", dgPresentaciones, "[Presentacion]"); 
            }
        }

        private void dgPresentaciones_DoubleClick(object sender, EventArgs e)
        {
            btnModificarPresentacion.Visible = true;
            IDProductoPresentacion = Convert.ToInt32(dgPresentaciones.CurrentRow.Cells["IDPresentacion"].Value);
            txtNombrePresentacion.Text = dgPresentaciones.CurrentRow.Cells["Presentacion"].Value.ToString();
            txtCosto.Text = dgPresentaciones.CurrentRow.Cells["Costo"].Value.ToString();
            txtPrecio.Text = dgPresentaciones.CurrentRow.Cells["Precio"].Value.ToString();
        }

        private void btnModificarPresentacion_Click(object sender, EventArgs e)
        {
            fn.Modificar("Presentacion", "Presentacion='" + txtNombrePresentacion.Text + "',Costo='" + txtCosto.Text + "',Precio='" + txtPrecio.Text + "'", "IDPresentacion='" + IDProductoPresentacion + "'");
            btnModificarPresentacion.Visible = false;
        }

        private void dgPresentaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                
                frmReceta frm = new frmReceta();
                //Mandamos los datos al formulario receta
                frm.lblProducto.Text = fn.select_one_value("Nombre", "Productos", "IDProducto='" + dgPresentaciones.CurrentRow.Cells[1].Value.ToString() + "'", 0);
                frm.lblPresentacion.Text = dgPresentaciones.CurrentRow.Cells[2].Value.ToString();
                frmReceta.IDPresentacion = dgPresentaciones.CurrentRow.Cells[0].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}
