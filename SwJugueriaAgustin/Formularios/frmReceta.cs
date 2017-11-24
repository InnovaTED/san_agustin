using SwJugueriaAgustin.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SwJugueriaAgustin.Formularios
{
    public partial class frmReceta : Form
    {
        public static string IDPresentacion;
        bool exite;
        Funciones fn = new Funciones();
        public frmReceta()
        {
            InitializeComponent();
            KeyUp += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    Guardar();
                }
            };
        }

        private void frmReceta_Load(object sender, EventArgs e)
        {
            fn.Maximizar(this);
            MostrarReceta();   
        }


        private void MostrarReceta()
        {
            if (fn.Existencia("*", "Receta", "IDPresentacion = '" + IDPresentacion + "'"))
            {
                exite = true;


                //Obtenemos los datos
                SqlConnection conexion = new SqlConnection(Funciones.preconex);
                string consulta = "SELECT p.IDProductoPrimo,p.Producto,r.Cantidad,u.UniMedida FROM ProductoPrimoAlmacen p,Receta r,UnidadMedida u where r.IDProductoPrimo = p.IDProductoPrimo and p.IDUniMedida = u.IDUniMedida and IDPresentacion = '"+IDPresentacion+"'";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                conexion.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                int p = 0;
                while (lector.Read())
                {
                    p = Convert.ToInt16(lector[0].ToString());
                    dgvRecetaProducto.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString() ,'X');
                }
                lector.Close();
                conexion.Close();
            }
            else
            {
                exite = false;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dgvProductoPrimo.Focus();
            }
        }

        private void dgvProductoPrimo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvProductoPrimo.RowCount > 0)
                {

                    e.SuppressKeyPress = true;
                    //Fila Seleccionada
                    int select = dgvProductoPrimo.CurrentRow.Index;
                    string codProducto = dgvProductoPrimo.Rows[select].Cells[0].Value.ToString();
                    string Producto = dgvProductoPrimo.Rows[select].Cells[1].Value.ToString();
                    float cantidad = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad", "San Agustin", "", 100, 100));//Convert.ToSingle(InputDialog.mostrar("Ingresa Cantidad"));
                    string uniMedia = dgvProductoPrimo.Rows[select].Cells[2].Value.ToString();

                    if (exite == true)
                    {
                        fn.Registrar("Receta", "'" + IDPresentacion + "','" + codProducto + "','" + cantidad + "'");

                        //Actuzalizom el grid de receta
                        dgvRecetaProducto.Rows.Clear();
                        MostrarReceta();
                    }
                    else
                    {
                        dgvRecetaProducto.Rows.Add(codProducto, Producto, cantidad,uniMedia, "X");
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(exite == false)
                {
                    for (short i = 0; i < dgvRecetaProducto.RowCount; i++)
                    {
                        string idProductoPrimo = dgvRecetaProducto.Rows[i].Cells[0].Value.ToString();
                        string Cantidad = dgvRecetaProducto.Rows[i].Cells[2].Value.ToString();
                        string uniMedida = dgvRecetaProducto.Rows[i].Cells[3].Value.ToString();
                        fn.Registrar("Receta", "'" + IDPresentacion + "','" + idProductoPrimo + "','" + Cantidad + "'");
                    }
                }
                MessageBox.Show("Receta Registrada", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Guardar()
        {

        }

        private void dgvRecetaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRecetaProducto.CurrentRow.Cells[4].Selected == true)
            {
                DialogResult msj = MessageBox.Show("Desea Quitarlo de la lista", "San Agustin", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(msj == DialogResult.OK)
                {
                    if(exite == true)
                    {
                        fn.Eliminar("Receta", "IDPresentacion='" + IDPresentacion + "' and IDProductoPrimo=(SELECT IDProductoPrimo from ProductoPrimoAlmacen where Producto='" + dgvRecetaProducto.CurrentRow.Cells[1].Value.ToString() + "')");

                        dgvRecetaProducto.Rows.Clear();
                        MostrarReceta();
                    }
                    else
                    {
                        dgvRecetaProducto.Rows.Remove(dgvRecetaProducto.CurrentRow);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            fn.MostrarGri("p.IDProductoPrimo as Codigo,p.Producto,u.UniMedida", "ProductoPrimo p,UnidadMedida u", "p.IDUniMedida = u.IDUniMedida and Producto LIKE '%" + txtBuscar.Text + "%'", dgvProductoPrimo, "ProductoPrimoAlmacen");
        }
    }
}
