using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace DAL
{
   public class RepositoryClienteBD
    {


        SqlConnection conexion;
        private SqlDataReader reader;
        public RepositoryClienteBD(SqlConnection conexion)
        {
            this.conexion = conexion;

        }

        List<Cliente> clientes = new List<Cliente>();

        public void Guardar(Cliente cliente)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Cliente(Id,Nombre, Telefono,Direccion)values" + "(@Id,@Nombre,@Telefono,@Direccion)";
                Comando.Parameters.AddWithValue("@Id", cliente.Id);
                Comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                Comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                Comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                


                Comando.ExecuteNonQuery();
            }

        }


        public void modificarBD(string id, Cliente cliente)
        {
            EliminarBD(id);
            Guardar(cliente);



        }
        public void EliminarBD(string id)
        {
            using (var Comando = conexion.CreateCommand())
            {

                Comando.CommandText = "delete from Cliente where Id= @Id";
                Comando.Parameters.AddWithValue("@Id", id);
                Comando.ExecuteNonQuery();
            }


        }
        public IList<Cliente> ConsultarBD()
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Cliente";
                conexion.Open();
                reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = Map(reader);
                    clientes.Add(cliente);

                }
            }
            conexion.Close();
            return clientes;


        }
        public Cliente Map(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Id = (string)reader["Identificacion"];
            cliente.Nombre = (string)reader["Nombre"];
            cliente.Telefono = (string)reader["Teléfono"];
            cliente.Direccion = (string)reader["Dirección"];
            
            return cliente;

        }

        //public Empleado Buscar(string identificacion)
        //{
        //    empleados = Consultar();
        //    foreach (var item in empleados)
        //    {
        //        if (identificacion.Equals(item.Id))
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}


    }
}
