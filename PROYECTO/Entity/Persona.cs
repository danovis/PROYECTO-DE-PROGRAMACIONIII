using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
 public   class Persona
    {
      

        public string Id { get; set; }
        public  string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {

        }

        public Persona(string id, string nombre, string telefono, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
