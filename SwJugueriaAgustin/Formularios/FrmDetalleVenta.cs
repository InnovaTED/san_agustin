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
    public partial class FrmDetalleVenta : Form
    {
        public FrmDetalleVenta()
        {
            InitializeComponent();
        }
        string Cod = FrmListaVentas.CodigoVenta;
        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            Clases.Funciones fn = new Clases.Funciones();
            fn.MostrarGri("p.Presentacion,pr.Nombre,d.Cantidad", "DetalleVenta d inner join Presentacion p on d.IDPresentacion = p.IDPresentacion inner join Productos pr on d.IDProducto = pr.IDProducto", "IDVenta = '"+ Cod + "'", dgVentas, "DetalleVenta");
        }
    }
}
