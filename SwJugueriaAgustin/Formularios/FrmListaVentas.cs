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
    public partial class FrmListaVentas : Form
    {
        public FrmListaVentas()
        {
            InitializeComponent();
        }
        Clases.Funciones fn = new Clases.Funciones();
        public static string CodigoVenta;
        private void CargarGrid()
        {
            fn.MostrarGri("v.IDVenta as [COD VENTA],v.Fecha AS [FECHA], v.Hora as [HORA],v.Igv as [IGV],v.SubTotal as [SUBTOTAL], v.Total AS [TOTAL],a.Descripcion as [TIPO],Pagado AS [ESTÁ PAGADO]", "Venta v inner join ProcesoTienda a on v.IDProcesoTienda = a.IDProcesoTienda", "IDVenta !=0 and v.Fecha between '" + dtpFecha.Value.ToShortDateString() + "' and '" + dtpFecha2.Value.ToShortDateString() + "'", dgVentas, "Venta");
        }
        private void txtCodVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtCodVenta.Text =="")
                {
                    CargarGrid();
                }
                else
                {
                    fn.MostrarGri("v.IDVenta as [COD VENTA],v.Fecha AS [FECHA], v.Hora as [HORA],v.Igv as [IGV],v.SubTotal as [SUBTOTAL], v.Total AS [TOTAL],a.Descripcion as [TIPO],Pagado AS [ESTÁ PAGADO]", "Venta v inner join ProcesoTienda a on v.IDProcesoTienda = a.IDProcesoTienda", "IDVenta = '"+txtCodVenta.Text + "'", dgVentas, "Venta");
                }
            }
        }

        private void dtpventa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                fn.MostrarGri("v.IDVenta as [COD VENTA],v.Fecha AS [FECHA], v.Hora as [HORA],v.Igv as [IGV],v.SubTotal as [SUBTOTAL], v.Total AS [TOTAL],a.Descripcion as [TIPO],Pagado AS [ESTÁ PAGADO]", "Venta v inner join ProcesoTienda a on v.IDProcesoTienda = a.IDProcesoTienda", "v.Fecha between '" + dtpFecha.Value.ToShortDateString() + "' and '" + dtpFecha2.Value.ToShortDateString() + "' and a.IDProcesoTienda = '" + cbTipo.SelectedValue + "' and v.pagado = '" + Convert.ToBoolean(chPagada.CheckState) + "'", dgVentas, "Venta");
            }
        }
        
        private void dtpFecha2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fn.MostrarGri("v.IDVenta as [COD VENTA],v.Fecha AS [FECHA], v.Hora as [HORA],v.Igv as [IGV],v.SubTotal as [SUBTOTAL], v.Total AS [TOTAL],a.Descripcion as [TIPO],Pagado AS [ESTÁ PAGADO]", "Venta v inner join ProcesoTienda a on v.IDProcesoTienda = a.IDProcesoTienda", "v.Fecha between '" + dtpFecha.Value.ToShortDateString() + "' and '" + dtpFecha2.Value.ToShortDateString() + "' and a.IDProcesoTienda = '" + cbTipo.SelectedValue + "' and v.pagado = '" + Convert.ToBoolean(chPagada.CheckState)+"' ", dgVentas, "Venta");
            }
        }

        private void dgVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                CodigoVenta = dgVentas.CurrentRow.Cells[0].Value.ToString();

                FrmDetalleVenta dv = new FrmDetalleVenta();
                dv.ShowDialog(this);
            }
        }
        
        private void FrmListaVentas_Load(object sender, EventArgs e)
        {
            fn.Maximizar(this);
            //Cargar Combo
            fn.añadir_ddl("IDProcesoTienda", "IDProcesoTienda", "ProcesoTienda", cbTipo);
            cbTipo.SelectedIndex = 1;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+ dgVentas.CurrentRow.Cells["ESTÁ PAGADO"].Value.ToString());return;
            if (dgVentas.Rows.Count ==0)
            {
                MessageBox.Show("No existen datos",".: AVISO DEL SITEMA :.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            //v.IDVenta as [COD VENTA],v.Fecha AS [FECHA], v.Hora as [HORA],v.Igv as [IGV],v.SubTotal as [SUBTOTAL], v.Total AS [TOTAL],a.Descripcion as [TIPO],Pagado AS [ESTÁ PAGADO]
            if (Convert.ToBoolean(dgVentas.CurrentRow.Cells["ESTÁ PAGADO"].Value)== false)
            {
                fn.Modificar("venta", "pagado = '1'", "IDVenta = '" + dgVentas.CurrentRow.Cells["COD VENTA"].Value.ToString() + "'");
                MessageBox.Show("Exito: proceso de pago finalizado", ".: AVISO DEL SISTEMA :.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La venta ya fue cancelada", ".: AVISO DEL SISTEMA :.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CargarGrid();

        }
    }
}
