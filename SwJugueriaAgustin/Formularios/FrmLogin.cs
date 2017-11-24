using SwJugueriaAgustin.Clases;
using SwJugueriaAgustin.Formularios;
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

namespace SwJugueriaAgustin
{
    public partial class FrmLogin : Form
    {
        Funciones fn = new Funciones();
        string CodUser;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fn.añadir_ddl("Usuario", "IDUsuario", "Usuario", cbxUsuario);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void ingresar()
        {
            bool bandera = false;
            //string preconex = "Data Source=192.168.0.9; Initial catalog=DBSanAgustin;Uid=AGUSTIN;Pwd=123";
            string preconex = Clases.Funciones.preconex;
            SqlConnection conexion = new SqlConnection(preconex);
            try
            {
                string consul = "SELECT * FROM USUARIO";
                SqlCommand cmd = new SqlCommand(consul, conexion);
                conexion.Open();
                SqlDataReader datos = cmd.ExecuteReader();
                while (datos.Read())
                {
                    if ((cbxUsuario.Text == datos[2].ToString()) && (txtPass.Text == datos[3].ToString()))
                    {
                        string usuario = datos[1].ToString();
                        CodUser = datos[0].ToString(); //ID_usuario
                        MessageBox.Show("Bienvenido al sistema " + usuario, ".:: JUGUERIAS SAN AGUSTÍN::.");
                        frmPrincipalOfi principal = new frmPrincipalOfi();
                        //FrmPrincipalPruebas principal = new FrmPrincipalPruebas();

                        //FrmPrincipalPruebas principal = new FrmPrincipalPruebas();
                        principal.Show();
                        bandera = true;
                        this.Hide();
                        break;
                    }
                }
                if (bandera == false)
                {
                    MessageBox.Show("Error De inicio de Sesión, Verifique Usuario o Contraseña", ".::SISTEMA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ingresar();
            }
        }
    }
}
