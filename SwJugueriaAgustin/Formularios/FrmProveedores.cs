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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        //Yamado a funciones
        Clases.Funciones fn = new Clases.Funciones();
        bool Guardar = true;
        int IDProveedor;
        private void CargarGrid()
        {
            fn.MostrarGri("*", "Proveedor", "IDProveedor!=0", dgProveedor, "Proveedor");
        }
        private void Limpiar()
        {
            txtcontacto.Clear();
            txtdireccion.Clear();
            txtidentificacion.Clear();
            txtrazonsocial.Clear();
            txttelefono.Clear();
            error.Clear();
        }
        private bool Validar()
        {
            bool f = false;
            if(txtidentificacion.Text =="")
            {
                error.SetError(txtidentificacion, "Ingrese el número de RUC del proveedor");
                return f;
            }
            error.Clear();
            if(txttelefono.Text == "")
            {
                error.SetError(txttelefono, "Ingrese el número de teléfono");
                return f;
            }
            error.Clear();
            if (txtrazonsocial.Text =="")
            {
                error.SetError(txtrazonsocial, "Ingrese la razón social");
                return f;
            }
            error.Clear();
            return true;
        }
        private void Bloquear(bool b)
        {
            txtcontacto.Enabled = !b;
            txtdireccion.Enabled = !b;
            txtidentificacion.Enabled = !b;
            txtrazonsocial.Enabled = !b;
            txttelefono.Enabled = !b;

            btnNuevo.Enabled = b;
            btnGuardar.Enabled = !b;
            btnModificar.Enabled = b;
            btnCancelar.Enabled = !b;
            btnEliminar.Enabled = b;
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            fn.Maximizar(this);
            CargarGrid();
            Guardar = true;
            Bloquear(true);
        }
        private string Grid(string i)
        {
            string valor;
            return valor = dgProveedor.CurrentRow.Cells[i].Value.ToString();
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar()!=true)  {return;}
            
            if (Guardar)
            {
                fn.Registrar("Proveedor", "'" + txtidentificacion.Text + "','" + txtrazonsocial.Text + "','" + txttelefono.Text + "','" + txtdireccion.Text + "','" + txtcontacto.Text + "'");
            }
            else
            {
                fn.Modificar("Proveedor", "Numero='" + txtidentificacion.Text + "',RazonSocial='" + txtrazonsocial.Text + "',Telefono='" + txttelefono.Text + "',Direccion='" + txtdireccion.Text + "',Contacto='" + txtcontacto.Text + "'", "IDProveedor='" + IDProveedor + "'");
            }
            Limpiar();
            CargarGrid();
            Bloquear(true);
        }

        private bool Filas()
        {
            if(dgProveedor.Rows.Count ==0)
            {
                MessageBox.Show("No existen datos", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Filas() != true) { return; }

            IDProveedor = Convert.ToInt32(Grid("IDProveedor"));
            txtidentificacion.Text = Grid("Numero");
            txtrazonsocial.Text = Grid("RazonSocial");
            txttelefono.Text = Grid("Telefono");
            txtdireccion.Text = Grid("Direccion");
            txtcontacto.Text = Grid("Contacto");
            Guardar = false;
            Bloquear(false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Filas() != true) { return;}
            fn.Eliminar("Proveedor", "IDProveedor='" + dgProveedor.CurrentRow.Cells["IDProveedor"].Value.ToString() + "'");
            CargarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Guardar = true;
            Bloquear(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Bloquear(true);
        }
    }
}
