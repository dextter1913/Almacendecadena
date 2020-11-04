using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeCadena
{
    class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection Conectando = new MySqlConnection("DataSource=localhost;Database=negocio;Userid=root;Password=1234;");


            Conectando.Open();
            return Conectando;
        }
            

    }
}
