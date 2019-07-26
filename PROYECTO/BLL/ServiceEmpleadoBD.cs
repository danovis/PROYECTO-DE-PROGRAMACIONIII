using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;

namespace BLL
{
   public class ServiceEmpleadoBD
    {
        SqlConnection conexion;
        RepositoryEmpleadoBD repositoryEmpleadoBD;
        RepositoryEmpleado repositoryEmpleado = new RepositoryEmpleado();

        public ServiceEmpleadoBD()
        {
            string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False";
            conexion = new SqlConnection(cadena);
            repositoryEmpleadoBD = new RepositoryEmpleadoBD(conexion);
        }

        public String Guardar(Empleado empleado)
        {
            try
            {
                conexion.Open();
                repositoryEmpleadoBD.Guardar(empleado);
                conexion.Close();
                return "Se registro al empleado" + empleado.Nombre;

            }
            catch (Exception e)
            {

                conexion.Close();
                return "Error de Base de Datos" + e;
            }


        }
        public Empleado BuscarEmpleado(string identificacion)
        {

            return repositoryEmpleado.Buscar(identificacion);
        }
        public String Buscar(string identificacion)
        {
            if (repositoryEmpleado.Buscar(identificacion) == null)
            {


                return $"No se encontro el Empleado con identificacion {identificacion}";
            }
            else
            {

                return repositoryEmpleado.Buscar(identificacion).ToString();


            }
        }
        public void modificar(string id, Empleado empleado)
        {
            conexion.Open();

            repositoryEmpleadoBD.modificarBD(id, empleado);
            conexion.Close();
        }

        public string EliminarBD(string id)
        {
            try
            {
                conexion.Open();
                repositoryEmpleadoBD.EliminarBD(id);
                conexion.Close();
                return "Eliminado";
            }
            catch (Exception e)
            {

                return e.ToString();

            }



        }

        public String Eliminar(String identificacion)
        {
            if (repositoryEmpleado.Buscar(identificacion) == null)
            {
                return "Identificacion no encontrada";
            }
            else
            {
                repositoryEmpleado.Eliminar(identificacion);
                return $"La persona con identificacion {identificacion} fue eliminada";

            }
        }
       

        public IList<Empleado> ConsultarBD()
        {

            return repositoryEmpleadoBD.ConsultarBD();

        }
      

        public String Modificar(String identificacion, Empleado empleado)
        {
            if (repositoryEmpleado.Buscar(identificacion) == null)
            {
                return "Identificacion no encontrada";
            }
            else
            {
                repositoryEmpleado.Modificar(identificacion, empleado);
                return "Los Datos fueron modificados con exito";

            }

        }
        
    }
}
