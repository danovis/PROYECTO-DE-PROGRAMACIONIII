using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
  public  class Cliente : Persona
    {
        public Cliente(string id, string nombre, string telefono, string direccion) : base(id, nombre, telefono, direccion)
        {
        }
        public Cliente()
        {

        }
    }
}
