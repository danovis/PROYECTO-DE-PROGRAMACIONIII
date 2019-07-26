using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado : Persona
    {

        public string Usuario { get; set; }
        public string Contraseña { get; set; }

  

        public Empleado(string id, string nombre, string telefono, string direccion, string usuario, string contraseña) : base(id, nombre, telefono, direccion)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }

        public Empleado()
        {
        }
    }
}
