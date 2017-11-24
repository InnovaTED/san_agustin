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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        Clases.Funciones fn = new Clases.Funciones();
        bool Guardar = true;
        int IDCliente;
        private void CargarGrid()
        {
            fn.MostrarGri("*", "Cliente", "IDCliente!=0", dgCliente, "Cliente");
        }
        private void Bloquear(bool i)
        {
            txtnombre.ReadOnly = i;
            txtdireccion.ReadOnly = i;
            txtnumero.ReadOnly = i;
            txttelefono.ReadOnly = i;

            btnNuevo.Enabled = i;
            btnGuardar.Enabled = !i;
            btnEliminar.Enabled = i;
            btnModificar.Enabled = i;
            btnCancelar.Enabled = !i;
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            fn.Maximizar(this);
            CargarGrid();
            Guardar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Guardar ==true)
            {
                fn.Registrar("Cliente", "'" + txtnombre.Text + "','" + txtnumero.Text + "','" + txttelefono.Text + "','" + txtdireccion.Text + "'");
                Limpiar();
            }
            else
            {
                fn.Modificar("cliente", "nombre = '" + txtnombre.Text + "',numero ='" + txtnumero.Text + "',Telefono ='" + txttelefono.Text + "',Direccion ='" + txtdireccion.Text+"'","IDCliente ='"+IDCliente+"'");
                Limpiar();
            }
            CargarGrid();
            Guardar = true;
        }


        private void Limpiar()
        {
            txtdireccion.Text = "";
            txtnombre.Text = "";
            txtnumero.Text = "";
            txttelefono.Text = "";
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            IDCliente = Convert.ToInt32(dgCliente.CurrentRow.Cells["IDCliente"].Value);
            txtnombre.Text = dgCliente.CurrentRow.Cells["Nombre"].Value.ToString();
            txtnumero.Text = dgCliente.CurrentRow.Cells["Numero"].Value.ToString();
            txttelefono.Text = dgCliente.CurrentRow.Cells["Telefono"].Value.ToString();
            txtdireccion.Text = dgCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            Guardar = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Guardar = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Guardar = true;
            FrmClientesTactil f = new FrmClientesTactil();
            f.Show();
        }
    }
}
