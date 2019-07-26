using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class RepositoryFactura
    {
        List<Factura> facturas = new List<Factura>();

        public void Guardar(Factura factura)
        {
            facturas.Add(factura);


        }

        public void GuardarArchivo(Factura factura)
        {
            FileStream sourceStream = new FileStream("hola.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(sourceStream);
            writer.WriteLine(factura.GetType() + ";" + factura.Id + ";" + factura.NombreCliente + ";" + factura.NombreEmpleado + ";" + factura.Producto + ";" + factura.Cantidad + ";" + factura.Valor + ";" + factura.dateTime);
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

        public List<Factura> Consultar()
        {
            facturas.Clear();

            FileStream sourceStream = new FileStream("hola.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                char delimiter = ';';
                string[] matrizFactura = linea.Split(delimiter);
                Factura factura = new Factura();
                factura.Id = matrizFactura[0];
                factura.NombreCliente = matrizFactura[1];
                factura.NombreEmpleado = matrizFactura[2];
                factura.Producto = matrizFactura[3];
                factura.Cantidad = matrizFactura[4];
                factura.Valor = matrizFactura[5];
                factura.dateTime = matrizFactura[6];
                facturas.Add(factura);


            }
            reader.Close();
            sourceStream.Close();

            return facturas;



        }

        public void Eliminar(string identificacion)
        {
            facturas = Consultar();
            CrearArchivoVacio();

            foreach (var item in facturas)
            {
                if (item.Id != identificacion)
                {
                    GuardarArchivo(item);


                }
            }
        }


        public void Modificar(string identificacion, Factura nuevaFactura)
        {

            facturas = Consultar();

            foreach (var item in facturas.ToArray())
            {
                if (identificacion.Equals(item.Id))
                {
                    CrearArchivoVacio();
                    facturas.Remove(item);
                    facturas.Add(nuevaFactura);

                }
            }
            foreach (var item in facturas)
            {
                GuardarArchivo(item);
            }

        }
        public Factura Buscar(string identificacion)
        {
            facturas = Consultar();
            foreach (var item in facturas)
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
