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
using TPIndustrial;

namespace IndustrialTP2
{
    public partial class ABM : MetroForm
    {
        public ABM()
        {
            InitializeComponent();
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT distinct description_std FROM diseños ORDER BY description_std ASC", conectar);
            //MySqlCommand comando = new MySqlCommand("SELECT distinct Producto FROM carga ORDER BY Producto ASC", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();

            while (almacena.Read())
            {
                cboProductos.Refresh();
                cboProductos.Items.Add(almacena.GetValue(0).ToString());
            }
            conectar.Close();

            for (int i = 1; i < 53; i++)
            { cboSemana.Items.Add("Semana "+i); }

        }

        private void ABM_Load(object sender, EventArgs e)
        {

        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listaFinales = new List<string> { };
            int bandera = 0;
            string seleccionado = cboProductos.SelectedItem.ToString();


            MySqlConnection conectarFinales = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectarFinales.Open();

            MySqlCommand comandoFinales = new MySqlCommand("SELECT Description_std FROM diseños WHERE Tipo_id=0", conectarFinales);
            MySqlDataReader almacenaFinales = comandoFinales.ExecuteReader();

            while (almacenaFinales.Read())
            {
                listaFinales.Add(almacenaFinales.GetValue(0).ToString());
            }
            conectarFinales.Close();


            if (listaFinales.Contains(seleccionado))
            { bandera = 1; }

            if (bandera == 1)//seleccione un producto final, mostrame los intermedios buy make y bruto
            {
                MySqlConnection conectar2 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

                conectar2.Open();
                MySqlCommand comando2 = new MySqlCommand("SELECT distinct Description_std FROM diseños WHERE  Tipo_id = 1 OR Tipo_id = 2 OR Tipo_id = 3 OR Tipo_id = 4", conectar2);
                MySqlDataReader almacena2 = comando2.ExecuteReader();

                while (almacena2.Read())
                {
                    cboComponente.Refresh();
                    cboComponente.Items.Add(almacena2.GetValue(0).ToString());
                }
                conectar2.Close();
                bandera = 0;
            }
            else // no era producto final, era un intermedio make: mostrame los intermedios buy y bruto
            {
                MySqlConnection conectar3 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

                conectar3.Open();
                MySqlCommand comando3 = new MySqlCommand("SELECT distinct Description_std FROM diseños WHERE Tipo_id = 2 OR Tipo_id = 4", conectar3);
                MySqlDataReader almacena3 = comando3.ExecuteReader();

                while (almacena3.Read())
                {
                    cboComponente.Refresh();
                    cboComponente.Items.Add(almacena3.GetValue(0).ToString());
                }
                conectar3.Close();
                bandera = 0;
                
            }
            //listarTabla();
        }

        private void btnAgregarHijo_Click(object sender, EventArgs e)
        {
            string semanaSeleccionada = cboSemana.SelectedItem.ToString();
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            string componenteSeleccionado = cboComponente.SelectedItem.ToString();

            using (AgregarModificar frmAgregar = new AgregarModificar(productoSeleccionado,componenteSeleccionado,semanaSeleccionada))
            { frmAgregar.ShowDialog(); }
            listarTabla();
        }

        private void listarTabla()
        {
            treeViewABM.Nodes.Clear();

            string producto = cboProductos.SelectedItem.ToString();
            string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM carga WHERE Producto LIKE  '" + producto + "' GROUP BY id_carga ", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            TreeNode node = new TreeNode(dt.Rows[0]["Producto"].ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //if componente = leer hijo en 1 && hijo del componente no tiene hijo hago esto
                string variable = dt.Rows[i]["LeerHijo"].ToString();
                char var = variable[0];
                string esTambienPadre = dt.Rows[i]["Componente"].ToString();
                string hijo = "";

                string conString2 = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
                MySqlConnection con2 = new MySqlConnection(conString2);
                MySqlCommand cmd2 = new MySqlCommand("SELECT Componente FROM carga WHERE Producto LIKE  '" + esTambienPadre + "' AND LeerHijo = 1", con2);
                MySqlDataAdapter sda2 = new MySqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);

                if (dt2.Rows.Count !=0)
                {
                    hijo = dt2.Rows[0]["Componente"].ToString();


                    if (var == '1'/*tiene hijo*/ && hijo != "")
                    {
                        // treeNode = new TreeNode("Dot Net Perls", array);
                        TreeNode nodeHijo = new TreeNode(hijo);
                        TreeNode[] array = new TreeNode[] { nodeHijo };
                         node = new TreeNode(esTambienPadre, array);
                        
                    }
                }
                else
                {
                    node.Nodes.Add(dt.Rows[i]["Componente"].ToString());
                    
                    //if componente = leer hijo en 1 hijo del componente si existe
                    //asigno variable hijo al hijo y lo agrego al padre y sigo el ciclo
                }
              
            }

            treeViewABM.Nodes.Add(node);
            treeViewABM.ExpandAll();



            //string producto = cboProductos.SelectedItem.ToString();
            //string conString = @"Data Source=localhost;port=3306;Initial Catalog=industrial;User Id=root;password=root";
            //using (MySqlConnection con = new MySqlConnection(conString))
            //{
            //    using (MySqlCommand cmd = new MySqlCommand("SELECT Componente, Cantidad, Unidad FROM carga WHERE Producto LIKE  '" + producto + "'", con))
            //    {
            //        cmd.CommandType = CommandType.Text;
            //        {
            //            cmd.CommandType = CommandType.Text;
            //            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
            //            {
            //                using (DataTable dt = new DataTable())
            //                {
            //                    sda.Fill(dt);
            //                    dataGridViewABM.DataSource = dt;
            //                    dataGridViewABM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //                    // e.Row.Cells[0].Style.Add("padding-left", "16px");
            //                }
            //            }
            //        }
            //    }
            //}
            
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            using (NuevoProducto frmNuevo = new NuevoProducto(cboSemana.SelectedItem.ToString()))
                {frmNuevo.ShowDialog();}
           // this.Close();
        }

        private void btnAgregarAlternatia_Click(object sender, EventArgs e)
        {
            string componente = cboComponente.SelectedItem.ToString();
            string alternativa = cboAlternativa.SelectedItem.ToString();
            string semana = cboSemana.SelectedItem.ToString();
            string producto = cboProductos.SelectedItem.ToString();

            using (CargaAlternativa frmAlternativa = new CargaAlternativa(semana,producto,componente, alternativa))
            {
                frmAlternativa.ShowDialog();
            }

            //   MetroFramework.MetroMessageBox.Show(Owner, "Insercion correcta", "Alternativa Agregada Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProductos.SelectedItem.ToString();
            string componenteSeleccionado = cboComponente.SelectedItem.ToString();

            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT distinct description_std FROM diseños WHERE description_std <> '" + productoSeleccionado + "' AND description_std <> '" + componenteSeleccionado + "'  ORDER BY description_std ASC", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();

            while (almacena.Read())
            {
                cboAlternativa.Refresh();
                cboAlternativa.Items.Add(almacena.GetValue(0).ToString());
            }
            conectar.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
