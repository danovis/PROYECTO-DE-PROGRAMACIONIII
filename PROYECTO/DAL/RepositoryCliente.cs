using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
   public class RepositoryCliente
    {
        List<Cliente> clientes = new List<Cliente>();

        public void Guardar(Cliente cliente)
        {
            clientes.Add(cliente);


        }

        public void GuardarArchivo(Cliente cliente)
        {
            FileStream sourceStream = new FileStream("hola.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(sourceStream);
            writer.WriteLine(cliente.GetType() + ";" + cliente.Id + ";" + cliente.Nombre + ";" + cliente.Telefono + ";" + cliente.Direccion);
            writer.Close();
            sourceStream.Close();




        }
        //public List<Empleado> filtrar(string tipo)
        //{
        //    empleados.Clear();
        //    foreach (var item in Consultar().ToArray())
        //    {
        //        if (item.Equals("ENTITY.EmpleadoConHorasDoble"))
        //        {
        //            empleados.Add(item);

        //        }
        //        else if (item.Equals("ENTITY.EmpleadoConHorasTriples"))
        //        {
        //            empleados.Add(item);
        //        }
        //        else if (item.Equals("ENTITY.EmpleadoSinHorasExtra"))
        //        {
        //            empleados.Add(item);
        //        }
        //    }
        //    return empleados;


        //}
        //public double CalcularTotal(string tipo)
        //{
        //    double total = 0;

        //    foreach (var item in Consultar().ToArray())
        //    {
        //        if (item.TipoEmpleado.Equals("ENTITY.EmpleadoConHorasDoble"))
        //        {
        //            total = total + item.Salario;

        //        }
        //        else if (item.TipoEmpleado.Equals("ENTITY.EmpleadoConHorasTriples"))
        //        {
        //            total = total + item.Salario;
        //        }
        //        else if (item.TipoEmpleado.Equals("ENTITY.EmpleadoSinHorasExtra"))
        //        {
        //            total = total + item.Salario;
        //        }
        //    }
        //    return total;


        //}


        public void CrearArchivoVacio()
        {
            FileStream sourceStream = new FileStream("hola.txt", FileMode.Create);

            sourceStream.Close();






        }

        public List<Cliente> Consultar()
        {
            clientes.Clear();

            FileStream sourceStream = new FileStream("hola.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                char delimiter = ';';
                string[] matrizCliente = linea.Split(delimiter);
                Cliente cliente = new Cliente();
                cliente.Id = matrizCliente[0];
                cliente.Nombre = matrizCliente[1];
                cliente.Telefono = matrizCliente[2];
                cliente.Direccion = matrizCliente[3];
                
                clientes.Add(cliente);


            }
            reader.Close();
            sourceStream.Close();

            return clientes;



        }

        public void Eliminar(string identificacion)
        {
            clientes = Consultar();
            CrearArchivoVacio();

            foreach (var item in clientes)
            {
                if (item.Id != identificacion)
                {
                    GuardarArchivo(item);


                }
            }
        }


        public void Modificar(string identificacion, Cliente nuevoCliente)
        {

            clientes = Consultar();

            foreach (var item in clientes.ToArray())
            {
                if (identificacion.Equals(item.Id))
                {
                    CrearArchivoVacio();
                    clientes.Remove(item);
                    clientes.Add(nuevoCliente);

                }
            }
            foreach (var item in clientes)
            {
                GuardarArchivo(item);
            }

        }
        public Cliente Buscar(string identificacion)
        {
            clientes = Consultar();
            foreach (var item in clientes)
            {
                if (identificacion.Equals(item.Id))
                {
                    return item;
                }
            }
            return null;
        }




    }
}
