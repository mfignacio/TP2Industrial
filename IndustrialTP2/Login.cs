using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using Industrial2;
using IndustrialTP2;

namespace WindowsFormsApplication8
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar.Open();  //conectar es la variable que establece la conexión con la BD

            MySqlCommand consulta = new MySqlCommand();
            MySqlConnection conexion = new MySqlConnection(); 
            consulta.Connection = conectar;

            consulta.CommandText=("SELECT * FROM users WHERE User_id = '"+txtnombre.Text+"'and Password= '"+txtpassword.Text+"' ");

            MySqlDataReader leer = consulta.ExecuteReader();  //consulta refiere al codigo de la consulta SQL
            if(leer.Read())
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Login Correcto", "¡Bienvenido!",  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Hide();
                using (Form1 frmBOM = new Form1())
                    frmBOM.ShowDialog();
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Usuario o contraseña incorrectos", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conectar.Close();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
