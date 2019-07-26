using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Factura
    {
        
        public Factura()
        {

        }

        public Factura(string id, string nombreCliente, string nombreEmpleado, string producto, string cantidad, string valor, string dateTime)
        {
            Id = id;
            NombreCliente = nombreCliente;
            NombreEmpleado = nombreEmpleado;
            Producto = producto;
            Cantidad = cantidad;
            Valor = valor;
            this.dateTime = dateTime;
        }

        public string Id { get; set; }
        public string NombreCliente { get; set; }
        public string NombreEmpleado { get; set; }
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public string Valor { get; set; }
        public string dateTime { get; set; }

    }
}
