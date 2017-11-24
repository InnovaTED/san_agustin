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
    public partial class FrmProductosReg : Form
    {
        Funciones fn = new Funciones();
        bool load = false;
        public FrmProductosReg()
        {
            InitializeComponent();
        }

        private void FrmProductosReg_Load(object sender, EventArgs e)
        {
            load = true;
            mostrarCategoria();
            load = false;
        }

        private void mostrarCategoria()
        {
            fn.añadir_ddl("Condicion", "IDCondicion", "CondicionProducto", cbxCategoria);
        }
        private void mostrarSubCategoria()
        {
            if(load == false)
            {
                MessageBox.Show(cbxCategoria.SelectedValue.ToString());
                fn.añadir_ddl("Nombre", "IDProducto", "Productos where IDCondicion='" + cbxCategoria.SelectedValue + "'", cbxCategoria);
            }
            
        }
        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarSubCategoria();
        }
    }
}
