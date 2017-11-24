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
    public partial class FrmDetalleKardex : Form
    {
        public FrmDetalleKardex()
        {
            InitializeComponent();
        }
        Clases.Funciones fn = new Clases.Funciones();
        private void btnDetalleKardex_Click(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            fn.MostrarGri("K.IDProductoPrimo AS [ID],UPPER(pp.producto) as [PRODUCTO],UPPER(um.UniMedida) as 'UM',sum(Entrada) AS [ENTRADA],SUM(Salida) AS[SALIDA],sum(Entrada)- SUM(Salida) AS [SALDO]", "KARDEX k INNER JOIN ProductoPrimo pp on k.IDProductoPrimo = pp.IDProductoPrimo inner join UnidadMedida um on um.IDUniMedida = pp.IDUniMedida", "FECHA BETWEEN '" + dtpinicio.Value.ToShortDateString() + "' AND '" + dtpfinal.Value.ToShortDateString() + "' group by K.IDProductoPrimo,pp.producto,um.UniMedida", dgKardex, "KARDEX");
        }
        private void dgKardex_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgKardex.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgKardex.SelectedRows)
                {
                    fn.MostrarGri("IDKardex as [ID],Fecha as [FECHA],UPPER(al.Almacen) as[ALMACÉN],Proceso as [PROCESO],CodProceso as [ID PROCESO], Entrada AS [ENTRADA],Salida AS [SALIDA],Saldo AS [SALDO],UPPER(PP.Producto) AS [PRODUCTO] ", "KARDEX k INNER JOIN ProductoPrimo pp on k.IDProductoPrimo = pp.IDProductoPrimo INNER JOIN Almacen al on k.IDAlmacen = al.IDAlmacen ", "Fecha BETWEEN '" + dtpinicio.Value.ToShortDateString() + "' AND '" + dtpfinal.Value.ToShortDateString() + "' and k.IDProductoPrimo = '" + row.Cells["ID"].Value.ToString() + "'", dgDetalle, "KARDEX");
                }
            }
        }

        private void FrmDetalleKardex_Load(object sender, EventArgs e)
        {
            Grid();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
    }
}
