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
    public partial class FrmGestion : Form
    {
        Funciones fn = new Funciones();
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            cbxAlmacenEmisor.Text = "";cbxAlmacenReceptor.Text = "";
            cbxAlmacenEmisor.Focus();
        }

        private void LlenarCombo()
        {
            fn.añadir_ddl("Almacen", "IDAlmacen", "Almacen", cbxAlmacenEmisor);
            fn.añadir_ddl("Almacen", "IDAlmacen", "Almacen", cbxAlmacenReceptor);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
                fn.MostrarGri(/*SELECT*/"pp.Producto,u.UniMedida,pp.PrecioCompra,ap.Stock,ap.StockMin,ap.StockMax",
                          /*FROM*/"AlmacenProductos ap,ProductoPrimo pp,UnidadMedida u",
                          /*WHERE*/"ap.IDProductoPrimo = pp.IDProductoPrimo and pp.IDUniMedida = u.IDUniMedida and ap.IDAlmacen = (select IDAlmacen from Almacen where Almacen = '" + cbxAlmacenEmisor.Text + "') and pp.Producto like '%" + txtBuscar.Text + "%'", dgvAlmacenEmisor, "AlmacenProductos");
         
            
        }

        private void dgvAlmacenEmisor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string StockMin, StockMax;
                string producto = dgvAlmacenEmisor.CurrentRow.Cells[0].Value.ToString();
                string uniMedida = dgvAlmacenEmisor.CurrentRow.Cells[1].Value.ToString();
                string cantidad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad a Trasladar", "San Agustin", "", 400, 400);

                if(Convert.ToSingle(cantidad) > Convert.ToSingle(dgvAlmacenEmisor.CurrentRow.Cells[3].Value.ToString()))
                {
                    MessageBox.Show("La cantidad a trasladar supera el stock del Almacen Principal", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (fn.Existencia("ap.*", "AlmacenProductos ap,ProductoPrimo pp,Almacen a", "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.Producto = '" + producto + "' and a.Almacen = '" + cbxAlmacenReceptor.Text + "'") == true)
                    {
                        StockMin = fn.select_one_value("ap.StockMin", "AlmacenProductos ap,ProductoPrimo pp,Almacen a", "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.Producto = '" + producto + "' and a.Almacen = '" + cbxAlmacenReceptor.Text + "'", 0);
                        StockMax = fn.select_one_value("ap.StockMax", "AlmacenProductos ap,ProductoPrimo pp,Almacen a", "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.Producto = '" + producto + "' and a.Almacen = '" + cbxAlmacenReceptor.Text + "'", 0);
                    }
                    else
                    {
                        StockMin = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Stock Minimo del Producto a tener en el Almacen Receptor", "San Agustin", "", 400, 300);
                        StockMax = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Stock Maximo del Producto a tener en el Almacen Receptor", "San Agustin", "", 400, 300);
                    }


                    dgvAlmacenReceptor.Rows.Add(producto, uniMedida, cantidad, StockMin, StockMax, "+", "x");
                }
                
            }
        }

        private void cbxAlmacenEmisor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrWhiteSpace(cbxAlmacenEmisor.Text) == false)
                { cbxAlmacenReceptor.Focus(); }
            }
        }

        private void cbxAlmacenReceptor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(cbxAlmacenEmisor.Text) == false)
                { txtBuscar.Focus(); }
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dgvAlmacenEmisor.Focus();   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo de almacenes
            string idAlmacenEmisor = fn.select_one_value("IDAlmacen", "Almacen", "Almacen='" + cbxAlmacenEmisor.Text + "'", 0);
            string idAlmacenReceptor = fn.select_one_value("IDAlmacen", "Almacen", "Almacen='" + cbxAlmacenReceptor.Text + "'", 0);

            //Fecha y hora
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToLongTimeString();

            //Registramos el Gestion de Almacen
            fn.Registrar("GestionAlmacen", "'" + idAlmacenEmisor + "','" + idAlmacenReceptor + "','" + fecha + "','" + hora + "','1'");

            //obtenemos el id de la gestion registrada
            string idGestion = fn.select_one_value("max(IDGestion)", "GestionAlmacen", "IDGestion>0", 0);

            



            
            
            for (short i=0;i<dgvAlmacenReceptor.RowCount;i++)
            {
                string producto = dgvAlmacenReceptor.Rows[i].Cells[0].Value.ToString();
                string idProducto = fn.select_one_value("IDProductoPrimo", "ProductoPrimo", "Producto='" + producto + "'", 0);

                string cantidad = dgvAlmacenReceptor.Rows[i].Cells[2].Value.ToString();
                string stockMin = dgvAlmacenReceptor.Rows[i].Cells[3].Value.ToString();
                string stockMax = dgvAlmacenReceptor.Rows[i].Cells[4].Value.ToString();

                //Verificamos si el producto exite para solo aumentarle su stock
                if (fn.Existencia("ap.*", "AlmacenProductos ap,ProductoPrimo pp,Almacen a", "ap.IDAlmacen = a.IDAlmacen and ap.IDProductoPrimo = pp.IDProductoPrimo and pp.Producto = '" + producto + "' and a.Almacen = '" + cbxAlmacenReceptor.Text + "'") == true)
                {
                    fn.Modificar("AlmacenProductos", "Stock=Stock+" + cantidad, "IDAlmacen='"+idAlmacenReceptor+"' and IDProductoPrimo='"+idProducto+"'");
                }
                //Caso que no exista lo registramos
                else
                {
                    fn.Registrar("AlmacenProductos", "'"+idAlmacenReceptor+"','"+idProducto+"','" + cantidad + "','" + stockMin + "','" + stockMax + "'");
                }

                //Disminuimos el stock del almacen emisor
                fn.Modificar("AlmacenProductos", "Stock=Stock-" + cantidad, "IDAlmacen='" + idAlmacenEmisor + "'");

                //Registramos el detalle de la gestion}
                fn.Registrar("DetalleGestion", "'" + idGestion + "','" + idProducto + "','" + cantidad + "'");
            }



            //Registramos el detalle de la gestion
            MessageBox.Show("Traslado Guardado", "San Agustin", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
