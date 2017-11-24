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
    public partial class frmPrincipalOfi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPrincipalOfi()
        {
            InitializeComponent();
        }
        private void Formulario(Form Formulario)
        {
            Formulario.MdiParent = this;
            Formulario.Show();
            Formulario.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }
        private void frmPrincipalOfi_Load(object sender, EventArgs e)
        {

        }

        private void MAGRAlmacen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAlmacen fa = new FrmAlmacen();
            Formulario(fa);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlmacenProductos f = new frmAlmacenProductos();
            Formulario(f);
        }

        private void MAGTraslado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGestion f = new FrmGestion();
            Formulario(f);
        }

        private void mbtnVENTAS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmVentaDirecta f = new FrmVentaDirecta();
            Formulario(f);
        }

        private void mbtnCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCompra f = new frmCompra();
            Formulario(f);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmClientes f = new FrmClientes();
            Formulario(f);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProveedores f = new FrmProveedores();
            Formulario(f);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmProducto f = new FrmProducto();
            Formulario(f);
        }
    }
}
