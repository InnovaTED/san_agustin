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
    
    public partial class frmAddCantidad : Form
    {
        public bool Cancelado;
        public frmAddCantidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = txtCantidad.TextLength-1;
            string text = "";
            for (int i=0;i<c;i++)
            {
                text += txtCantidad.Text[i]; 
            }
            txtCantidad.Text = text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cancelado = false;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "7";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCantidad.Text += "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancelado = true;
            this.Close();
        }
    }
}
