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
   public class ServiceClienteBD
    {

        SqlConnection conexion;
        RepositoryClienteBD repositoryClienteBD;
        RepositoryCliente repositoryCliente = new RepositoryCliente();

        public ServiceClienteBD()
        {
            string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False";
            conexion = new SqlConnection(cadena);
            repositoryClienteBD = new RepositoryClienteBD(conexion);
        }

        public String Guardar(Cliente cliente)
        {
            try
            {
                conexion.Open();
                repositoryClienteBD.Guardar(cliente);
                conexion.Close();
                return "Se registro al Cliente:  " + cliente.Nombre;

            }
            catch (Exception e)
            {

                conexion.Close();
                return "Error de Base de Datos" + e;
            }


        }
        public Cliente BuscarCliente(string identificacion)
        {

            return repositoryCliente.Buscar(identificacion);
        }
        public String Buscar(string identificacion)
        {
            if (repositoryCliente.Buscar(identificacion) == null)
            {


                return $"No se encontro el Empleado con identificacion:  {identificacion}";
            }
            else
            {

                return repositoryCliente.Buscar(identificacion).ToString();


            }
        }
        public void modificar(string id, Cliente cliente)
        {
            conexion.Open();

            repositoryClienteBD.modificarBD(id, cliente);
            conexion.Close();
        }

        public string EliminarBD(string id)
        {
            try
            {
                conexion.Open();
                repositoryClienteBD.EliminarBD(id);
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
            if (repositoryCliente.Buscar(identificacion) == null)
            {
                return "Identificacion no encontrada";
            }
            else
            {
                repositoryCliente.Eliminar(identificacion);
                return $"La persona con identificacion {identificacion} fue eliminada";

            }
        }


        public IList<Cliente> ConsultarBD()
        {

            return repositoryClienteBD.ConsultarBD();

        }


        public String Modificar(String identificacion, Cliente cliente)
        {
            if (repositoryCliente.Buscar(identificacion) == null)
            {
                return "Identificacion no encontrada";
            }
            else
            {
                repositoryCliente.Modificar(identificacion, cliente);
                return "Los Datos fueron modificados con exito";

            }

        }


    }
}
