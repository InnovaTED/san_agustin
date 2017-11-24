using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SwJugueriaAgustin.Clases
{
    class Funciones
    {
        public static string preconex = "Data Source=192.168.0.22; Initial catalog=DBSanAgustin;Uid=AGUSTIN;Pwd=123";
        //public static string preconex = "Data Source=190.117.128.134;Initial Catalog='BASE_EXCEL';Uid=INNOVATED;Pwd=123!";

        public void Maximizar(Form frm)
        {
            frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        public void IniciarSesion()
        {

        }
        public void Registrar(string table, string datos)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(preconex);
                string reg = "INSERT INTO " + table + " VALUES (" + datos + ")";
                SqlCommand cmdReg = new SqlCommand(reg, conexion);
                conexion.Open();
                int registro = cmdReg.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ".::SISTEMA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        



        public void Eliminar(string table, string condicion)
        {
            SqlConnection conexion = new SqlConnection(preconex);
                string reg = "DELETE " + table + " WHERE " + condicion;
                SqlCommand cmdReg = new SqlCommand(reg, conexion);
                conexion.Open();
                int registro = cmdReg.ExecuteNonQuery();
                MessageBox.Show("EXITO . DATOS ELIMINADOS", ".::SISTEMA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
        }

        public void Modificar(string table, string modificados, string condicion)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string upd = "update " + table + " set " + modificados + " where " + condicion;
            SqlCommand cmdUpd = new SqlCommand(upd, conexion);
            conexion.Open();
            int registro = cmdUpd.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarGri(string campos, string tabla, string condicion, DataGridView Grid, string TablaPrincipal)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(preconex);
                conexion.Open();
                string consulta = "select " + campos + " from " + tabla + " where " + condicion;
                SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds, TablaPrincipal);
                Grid.DataSource = ds;
                Grid.DataMember = TablaPrincipal;
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public string Cantidad(string campos, string tabla, string condicion)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string oncod = "SELECT  count(" + campos + ") FROM " + tabla + " WHERE " + condicion;
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            return lector[0].ToString();
            conexion.Close();
        }

        public bool Existencia(string campos, string tabla, string condicion)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string oncod = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion;
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            if (lector.HasRows == true)
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }
            conexion.Close();

        }

        public int UltimaFila(string tabla)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string consulta = "SELECT * FROM " + tabla;
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            int p = 0;
            while (lector.Read())
            {
                p = Convert.ToInt16(lector[0].ToString());
            }
            lector.Close();
            return p;
            conexion.Close();

        }


        public void añadir_ddl(string campo, string Value, string tabla, ComboBox combo)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string consulta = "SELECT " + Value + "," + campo + " FROM " + tabla;
            SqlDataAdapter dap = new SqlDataAdapter(consulta, conexion);

            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = campo;
            combo.ValueMember = Value;
        }

        public string select_one_value(string campos, string tabla, string condicion, int indice)
        {
            SqlConnection conexion = new SqlConnection(preconex);
            string oncod = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion;
            SqlCommand cmd = new SqlCommand(oncod, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            return lector[indice].ToString();

        }


        public void añadir_ddl_CONDICION(string campos, string tabla, string condicion, int indice, ComboBox combo)
        {

            SqlConnection conexion = new SqlConnection(preconex);
            string consulta = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion;
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader lector = cmd.ExecuteReader();
            while (lector.Read())
            {
                combo.Items.Add(lector[indice].ToString());
            }

            lector.Close();
        }




    }
}
