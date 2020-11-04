using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeCadena
{
    class Movimientos
    {
        public static int Agregar(Insertar_clientes wcliente)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into clientes(id, Nombre, direccion, telefono) values('{0}','{1}','{2}','{3}')", wcliente.id, wcliente.Nombre, wcliente.direccion, wcliente.telefono), Conexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
