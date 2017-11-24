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
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
        }
        Clases.Funciones fn = new Clases.Funciones();
        bool Guardar;
        private void Grid()
        {
            fn.MostrarGri("*", "Almacen", "IDAlmacen != 0", dgAlmacen, "Almacen");
        }
        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            Grid();
            Bloquear(true);
            txtnombreAlmacen.Focus();
            btnNuevo.Select();
        }
        private bool Filas()
        {
            if(dgAlmacen.Rows.Count==0)
            {
                return false;
            }
            return true;
        }
        private void Bloquear(bool i)
        {
            txtnombreAlmacen.ReadOnly = i;
            chVender.Enabled = !i;
            dgAlmacen.Enabled = i;

            btnNuevo.Enabled = i;
            btnGuardar.Enabled = !i;
            btnEliminar.Enabled = i;
            btnModificar.Enabled = i;
            btnCancelar.Enabled = !i;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtnombreAlmacen.Text =="")
            {
                error.SetError(txtnombreAlmacen, "Debe ingresar el nombre de almacén");
                return;
            }
            error.Clear();
            if(Guardar)
            {
                fn.Registrar("Almacen", "'" + txtnombreAlmacen.Text + "','" + Convert.ToBoolean(chVender.CheckState) + "'");
            }
            else
            {
                fn.Modificar("Almacen", "Almacen = '"+txtnombreAlmacen.Text+"',PuedeVender='"+Convert.ToBoolean(chVender.Checked)+"'", "IDAlmacen='"+dgAlmacen.CurrentRow.Cells["IDAlmacen"].Value.ToString()+"'");
            }
            Limpiar();
            Grid();
            Bloquear(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Guardar = true;
            Bloquear(false);
            Limpiar();
        }
        private void Limpiar()
        {
            txtnombreAlmacen.Clear();
            chVender.Checked = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(Filas()!=true)
            {
                return;
            }

            txtnombreAlmacen.Text = dgAlmacen.CurrentRow.Cells["Almacen"].Value.ToString();
            chVender.Checked = Convert.ToBoolean(dgAlmacen.CurrentRow.Cells["PuedeVender"].Value.ToString());
            Guardar = false;
            Bloquear(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardar = true;
            Limpiar();
            Bloquear(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Filas() != true)
            {
                return;
            }
            fn.Eliminar("Almacen", "IDAlmacen='"+ dgAlmacen.CurrentRow.Cells["IDAlmacen"].Value.ToString() + "'");
            Grid();
            Bloquear(true);
        }
    }
}
