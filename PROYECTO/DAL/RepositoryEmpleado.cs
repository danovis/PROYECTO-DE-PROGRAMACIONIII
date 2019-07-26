using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class RepositoryEmpleado
    {

        List<Empleado> empleados = new List<Empleado>();

        public void Guardar(Empleado empleado)
        {
            empleados.Add(empleado);


        }

        public void GuardarArchivo(Empleado empleado)
        {
            FileStream sourceStream = new FileStream("hola.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(sourceStream);
            writer.WriteLine(empleado.GetType() + ";" + empleado.Id + ";" + empleado.Nombre + ";" + empleado.Telefono + ";" + empleado.Usuario + ";" + empleado.Contraseña);
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

        public List<Empleado> Consultar()
        {
            empleados.Clear();

            FileStream sourceStream = new FileStream("hola.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(sourceStream);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {

                char delimiter = ';';
                string[] matrizEmpleado = linea.Split(delimiter);
                Empleado empleado = new Empleado();
                empleado.Id= matrizEmpleado[0];
                empleado.Nombre = matrizEmpleado[1];
                empleado.Telefono = matrizEmpleado[2];
                empleado.Usuario = matrizEmpleado[3];
                empleado.Contraseña = matrizEmpleado[4];
                empleados.Add(empleado);


            }
            reader.Close();
            sourceStream.Close();

            return empleados;



        }
        
        public void Eliminar(string identificacion)
        {
            empleados = Consultar();
            CrearArchivoVacio();

            foreach (var item in empleados)
            {
                if (item.Id != identificacion)
                {
                    GuardarArchivo(item);


                }
            }
        }

       
        public void Modificar(string identificacion, Empleado nuevoEmpleado)
        {

            empleados = Consultar();

            foreach (var item in empleados.ToArray())
            {
                if (identificacion.Equals(item.Id))
                {
                    CrearArchivoVacio();
                    empleados.Remove(item);
                    empleados.Add(nuevoEmpleado);

                }
            }
            foreach (var item in empleados)
            {
                GuardarArchivo(item);
            }

        }
        public Empleado Buscar(string identificacion)
        {
            empleados = Consultar();
            foreach (var item in empleados)
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
