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
    public partial class FrmVentaDirecta : Form
    {
        Funciones fn = new Funciones();
        public FrmVentaDirecta()
        {
            InitializeComponent();
        }
       
        string Cn = Clases.Funciones.preconex;
        private void CargarCategoria()
        {
            SqlConnection conexion = new SqlConnection(Cn);
            string oncod = "select UPPER(Condicion) AS [CATEGORIA],IDCondicion from CondicionProducto ";
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                Button btn = new Button();
                btn.Text = lector["CATEGORIA"].ToString();
                btn.Size = new System.Drawing.Size(140, 60);
                btn.ForeColor = Color.BlueViolet;
                btn.BackColor = Color.Gainsboro;
                btn.Tag = lector["IDCondicion"].ToString();
                btn.Click += btn_Click;
                flpCategorias.Controls.Add(btn);
            }
            return ;
        }
        private void CargarSubcategoria(int IDCategoria_)
        {
            flpSubcategoria.Controls.Clear();
            flpProductos.Controls.Clear();
            SqlConnection conexion = new SqlConnection(Cn);
            string oncod = "select UPPER(Nombre) AS [SUBCATEGORIA],IDProducto from Productos WHERE IDCondicion = '" + IDCategoria_ + "'";
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
               
                Button btn = new Button();
                btn.Text = lector["SUBCATEGORIA"].ToString();
                btn.Size = new System.Drawing.Size(160, 80);
                btn.ForeColor = Color.Blue;
                btn.BackColor = Color.Gainsboro;
                btn.Tag = lector["IDProducto"].ToString();
                btn.Click += btnproductos_Click;

                flpSubcategoria.Controls.Add(btn);
            }
            return;
        }
        private void CargarProductos(int IDProducto)
        {
            flpProductos.Controls.Clear();
            SqlConnection conexion = new SqlConnection(Cn);
            string oncod = "select UPPER(Presentacion) AS [PRODUCTO],IDPresentacion from Presentacion WHERE IDProducto = '"+ IDProducto + "'";
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
               
                Button btn = new Button();
                btn.Text = lector["PRODUCTO"].ToString();
                btn.Size = new System.Drawing.Size(160, 80);
                btn.ForeColor = Color.Green;
                btn.BackColor = Color.Gainsboro;
                btn.Tag = lector["IDPresentacion"].ToString();
                btn.Click += btnSelectProd_Click;

                flpProductos.Controls.Add(btn);
            }
            return;
        }

        void btnSelectProd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int IDPresentacion = Convert.ToInt32(btn.Tag);
            frmAddCantidad frm = new frmAddCantidad();
            frm.ShowDialog();

            if(frm.Cancelado == false)
            {
                //Agregar el producto al GridView
                string cantidad = frm.txtCantidad.Text;
                string nombre = fn.select_one_value("Presentacion", "Presentacion", "IDPresentacion='" + IDPresentacion + "'", 0);
                string precio = fn.select_one_value("Precio", "Presentacion", "IDPresentacion='" + IDPresentacion + "'", 0);
                string subTotal = (Convert.ToDouble(cantidad) * Convert.ToDouble(precio)).ToString();
                dgvDetalleVenta.Rows.Add(nombre, cantidad, precio, subTotal);
                CalcularVenta();
            }
        }
        private void CalcularVenta()
        {
            if (dgvDetalleVenta.Rows.Count >0)
            {
                float total = 0;
                for (short i = 0; i < dgvDetalleVenta.RowCount; i++)
                {
                    total = Convert.ToSingle(dgvDetalleVenta.Rows[i].Cells[3].Value.ToString());
                }
                lblTotal.Text = total.ToString("0.00"); 
            }
            else
            {
                lblTotal.Text = "0.00";
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int  IDCategoria = Convert.ToInt32(btn.Tag);
            CargarSubcategoria(IDCategoria);
        }
        void btnproductos_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int IDProducto = Convert.ToInt32(btn.Tag);
            CargarProductos(IDProducto);
        }
        private void FrmVentaDirecta_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            dtpFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IDVenta = (Convert.ToInt16(fn.select_one_value("IDAyuda", "Ayuda", "Descripcion='Venta'", 0))+1).ToString();
            string fecha = DateTime.Now.Date.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();

            float total = Convert.ToSingle(lblTotal.Text);
            float igv = total * 0.18f;
            float subTotal = total - igv;

            fn.Registrar("Venta", "'" + IDVenta + "','" + fecha + "','" + hora + "','" + igv + "','" + subTotal + "','" + lblTotal.Text + "','VentaDirecta','True','1'");

            for(short i=0;i<dgvDetalleVenta.RowCount;i++)
            {
                fn.Registrar("DetalleVenta", "'" + IDVenta + "',(SELECT IDPresentacion from Presentacion where Presentacion = '" + dgvDetalleVenta.Rows[i].Cells[0].Value.ToString() + "'),'" + dgvDetalleVenta.Rows[i].Cells[1].Value.ToString() + "'");
            }
            MessageBox.Show("Venta Registrada");
            dgvDetalleVenta.Rows.Clear();
            fn.Modificar("Ayuda","IDAyuda='"+IDVenta+"'","Descripcion='Venta'");
            lblTotal.Text = "0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDetalleVenta.Rows.Clear();
            lblTotal.Text = "0.00";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            dgvDetalleVenta.Rows.RemoveAt(dgvDetalleVenta.CurrentRow.Index);
            CalcularVenta();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int IDPresentacion = Convert.ToInt32(btn.Tag);
            frmAddCantidad frm = new frmAddCantidad();
            frm.ShowDialog();

            if (frm.Cancelado == false)
            {
                //Agregar el producto al GridView
                string cantidad = frm.txtCantidad.Text;
                string precio = fn.select_one_value("Precio", "Presentacion", "IDPresentacion= (SELECT IDPresentacion from Presentacion where Presentacion = '" + dgvDetalleVenta.CurrentRow.Cells[0].Value.ToString() + "')", 0);
                string subTotal = (Convert.ToDouble(cantidad) * Convert.ToDouble(precio)).ToString();

                dgvDetalleVenta.CurrentRow.Cells["CANTIDAD"].Value = cantidad;
                dgvDetalleVenta.CurrentRow.Cells["PreUni"].Value = precio;
                dgvDetalleVenta.CurrentRow.Cells["TOTAL"].Value = subTotal;

                CalcularVenta();
            }
        }
    }
}
