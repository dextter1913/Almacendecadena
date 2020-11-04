using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeCadena
{
    class Insertar_clientes
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Insertar_clientes() { }
        public Insertar_clientes(string c_id, string c_nombre, string c_direccion, string c_telefono)
        {
            this.id = c_id;
            this.Nombre = c_nombre;
            this.direccion = c_direccion;
            this.telefono = c_telefono;

        }

    }
}
