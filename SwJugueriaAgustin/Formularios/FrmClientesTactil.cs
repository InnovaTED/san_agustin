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
    public partial class FrmClientesTactil : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
       
        public FrmClientesTactil()
        {
            InitializeComponent();
        }
       

        private void FrmClientesTactil_Load(object sender, EventArgs e)
        {

        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("Q");
        }
    }
}
