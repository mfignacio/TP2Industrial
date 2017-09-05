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
    public partial class AgregarModificar : MetroForm
    {
        public AgregarModificar(string productoSeleccionado, string componenteSeleccionado, string semanaSeleccionada)
        {
            InitializeComponent();
            txtSemana.Text = semanaSeleccionada;
            txtProducto.Text = productoSeleccionado;
            txtComponente.Text = componenteSeleccionado;
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT Unidad FROM diseño_medida WHERE description_std LIKE  '" + componenteSeleccionado + "'", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
           

            while (almacena.Read())
            {
                cboUnidadesDisponibles.Refresh();
                cboUnidadesDisponibles.Items.Add(almacena.GetValue(0).ToString());

            }
            conectar.Close();
        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            string componente = txtComponente.Text;
            string producto = txtProducto.Text;
            string unidad = cboUnidadesDisponibles.SelectedItem.ToString();
            float cantidad = float.Parse(txtCantidad.Text);
            string semana = txtSemana.Text;
            int leerHijo = 1;
         
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO carga (Producto, Componente, Unidad, Cantidad, Semana, LeerHijo) VALUES ('" + producto + "'  , '" + componente + "', '" + unidad + "', '" + cantidad + "', '" + semana + "', '" + leerHijo + "')", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
            conectar.Close();
            
            List<string> listaNulos = new List<string> { };
            MySqlConnection conectarNulos = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectarNulos.Open();
            MySqlCommand comandoNulos = new MySqlCommand("SELECT id_carga FROM carga WHERE Componente IS NULL", conectarNulos);
            MySqlDataReader almacenaNulos = comandoNulos.ExecuteReader();
            
            while (almacenaNulos.Read())
            {
                listaNulos.Add(almacenaNulos.GetValue(0).ToString());
            }
            conectarNulos.Close();

            if (listaNulos.Count()>=1)
            {
                conectar.Open();
                MySqlCommand comandoListaNulos = new MySqlCommand("DELETE FROM carga WHERE Componente IS NULL", conectar);
                MySqlDataReader almacenaListaNulos = comandoListaNulos.ExecuteReader();
                conectar.Close();
            }

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarModificar_Load(object sender, EventArgs e)
        {

        }

        private void cboUnidadesDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
