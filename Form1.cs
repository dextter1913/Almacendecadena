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

namespace AlmacenDeCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciarsesionem_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("DataSource=localhost;Database=negocio;Userid=root;Password=1234;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;

            codigo.CommandText = ("SELECT * FROM usuarios where usuario = '" + txtusuarioem.Text + "' and password='" + txtcontraseñaem.Text + "'");

            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                frmMenuPrincipal Menuprincipal = new frmMenuPrincipal();
                Menuprincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, usuario o contraseña incorrecta");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
