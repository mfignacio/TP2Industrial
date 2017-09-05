using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIndustrial
{
    public partial class NuevoProducto : MetroForm
    {
        public NuevoProducto(string semanaSeleccionada)
        {
            InitializeComponent();
            //comboBox.Items.Add(new { Text = "report A", Value = "reportA" });
            cboTipo.DisplayMember = "Text";
            cboTipo.ValueMember = "Value";
            cboTipo.Items.Add(new { Text = "Producto Final", Value = "Producto Final" });
            cboTipo.Items.Add(new { Text = "Intermedio Make", Value = "Intermedio Make" });
            txtSemana.Text = semanaSeleccionada;

        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string nuevoProducto = txtNuevoProducto.Text;
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO carga (Producto) VALUES ('" + nuevoProducto + "')", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
            conectar.Close();


            //--------------------------------------------------------------------------
            List<string> Design_id = new List<string> { };
            List<string> Description_id = new List<string> { };
            string nombre = "NACHO";
            int tipo = 0;
            //string final = "Producto Final";
            //string intermedio = "Intermedio Make";
            if (cboTipo.SelectedItem.ToString() == "Producto Final")
                { tipo = 1; }
            else if (cboTipo.SelectedItem.ToString() == "Intermedio Make")
                { tipo = 3; }
            string inicio = "2006-01-01";
            string fechaActual = DateTime.Now.Date.ToString("yyyy-MM-dd");
            //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // string fechita = fechaActual.ToString();


            MySqlConnection conectar3 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar3.Open();
            MySqlCommand comando3 = new MySqlCommand("SELECT Design_id FROM diseños", conectar3);
            MySqlDataReader almacena3 = comando3.ExecuteReader();
            while (almacena3.Read())
            {
                Design_id.Add(almacena3.GetValue(0).ToString());
            };

            int idDesign = int.Parse(Design_id.Last());
            idDesign++;
            conectar3.Close();
            conectar3.Open();

            MySqlCommand comando4 = new MySqlCommand("SELECT Description_id FROM diseños", conectar3);
            MySqlDataReader almacena4 = comando4.ExecuteReader();
            while (almacena4.Read())
            {
                Description_id.Add(almacena4.GetValue(0).ToString());
            };

            int idDescription = int.Parse(Description_id.Last());
            idDescription++;
            conectar3.Close();

            MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar2.Open();
            MySqlCommand comando2 = new MySqlCommand("INSERT INTO diseños (Design_id, Description_id, Description_std, Tipo_id, Start_date, Last_upd, User_upd) VALUES ('" + idDesign + "', '" + idDescription + "', '" + nuevoProducto + "', '" + tipo + "', '" + inicio + "' , '" + fechaActual + "', '" + nombre + "')", conectar2);
            MySqlDataReader almacena2 = comando2.ExecuteReader();
            conectar2.Close();


            this.Close();
            
        }
    }
}
