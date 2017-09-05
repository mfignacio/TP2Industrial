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
    public partial class CargaAlternativa : MetroForm
    {
        public CargaAlternativa(string semanaSeleccionada, string productoSeleccionado, string componenteSeleccionado, string alternativaSeleccionada)
        {
            InitializeComponent();
            txtSemana.Text = semanaSeleccionada;
            txtProducto.Text = productoSeleccionado;
            txtComponente.Text = componenteSeleccionado;
            txtAlternativa.Text = alternativaSeleccionada;
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");

            conectar.Open();
            MySqlCommand comando = new MySqlCommand("SELECT Unidad FROM diseño_medida WHERE description_std LIKE  '" + componenteSeleccionado + "'", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();


            while (almacena.Read())
            {
                cboUnidadesMedida.Refresh();
                cboUnidadesMedida.Items.Add(almacena.GetValue(0).ToString());

            }
            conectar.Close();
        }

        private void btnAgregarAlternativa_Click(object sender, EventArgs e)
        {
            string semanaSeleccionada = txtSemana.Text;
            string productoSeleccionado = txtProducto.Text;
            string componenteSeleccionado = txtComponente.Text;
            string alternativaSeleccionada = txtAlternativa.Text;
            float cantidad = float.Parse(txtCantidad.Text);
            string unidad = cboUnidadesMedida.SelectedItem.ToString();


            MySqlConnection conectar = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO alternativos (Original, Alternativo, Semana) VALUES ('" + componenteSeleccionado + "'  , '" + alternativaSeleccionada + "', '" + semanaSeleccionada + "')  ", conectar);
            MySqlDataReader almacena = comando.ExecuteReader();
            conectar.Close();

            MySqlConnection conectar1 = new MySqlConnection("server=localhost; database=industrial;Uid=root;pwd=root;");
            conectar1.Open();
            MySqlCommand comando1 = new MySqlCommand("SELECT id_carga,  Producto, Componente, Unidad, Cantidad, Semana FROM carga WHERE Producto LIKE '" + productoSeleccionado + "' AND Componente LIKE '" + componenteSeleccionado + "'", conectar1);
            List<string> lista = new List<string> { };

            MySqlDataReader almacenaLista = comando1.ExecuteReader();
            while (almacenaLista.Read())
            {
                //lista.Add(almacenaLista.GetValue(0).ToString());
                lista.Add(almacenaLista.GetString(0));

            }
            conectar1.Close();

            //UPDATE table_name
            //SET column1 = value1, column2 = value2, ...
            //WHERE condition;

            string idLista = lista[0];
           // string productoLista = lista[1];
            //string componenteLista = lista[2];
            //string unidadLista = lista[3];
            //string cantidadLista = lista[4];
            //string semanaLista = lista[5];

            conectar1.Open();
            //MySqlCommand comando2 = new MySqlCommand("UPDATE carga SET id_carga='"+idLista+ "',  Producto='" + productoLista + "', Componente='" + componenteLista + "', Unidad='" + unidadLista + "', Cantidad='" + cantidadLista + "', Semana='" + semanaLista + "', Alternativa = '" + alternativaSeleccionada + "' , UnidadAlternativa='" + unidad + "', CantidadAlternativa = '" + cantidad + "' WHERE id_carga LIKE '"+idLista+"' AND Producto LIKE '" + productoSeleccionado + "' AND Componente LIKE '" + componenteSeleccionado + "'", conectar1);

            MySqlCommand comando2 = new MySqlCommand("UPDATE carga SET Alternativa = '" + alternativaSeleccionada + "' , UnidadAlternativa='" + unidad + "', CantidadAlternativa = '" + cantidad + "' WHERE id_carga LIKE '" + idLista + "'", conectar1);
            MySqlDataReader almacena2 = comando2.ExecuteReader();
            conectar1.Close();
            this.Close();
            //select todo lo del producto que estoy modificando y agrego los campos extras, despues borro el registro original.
        }
    }
}
