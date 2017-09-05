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

namespace IndustrialTP2
{
    public partial class Implosion : MetroForm
    {
        public Implosion()
        {
            InitializeComponent();
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT distinct Componente FROM carga ORDER BY Componente ASC", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();

            while (almacena.Read())
            {
                cboComponente.Refresh();
                cboComponente.Items.Add(almacena.GetValue(0).ToString());
            }
            conectar.Close();

            for (int i = 1; i < 53; i++)
            { cboSemana.Items.Add("Semana " + i); }
        }

        private void Implosion_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            using (ImplosionarProducto frmImplosionarProducto = new ImplosionarProducto())
            {
                frmImplosionarProducto.ShowDialog();
            }
        }
    }
}
