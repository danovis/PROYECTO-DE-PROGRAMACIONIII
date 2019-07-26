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
   public class RepositoryEmpleadoBD
    {
        SqlConnection conexion;
        private SqlDataReader reader;
        public RepositoryEmpleadoBD(SqlConnection conexion)
        {
            this.conexion = conexion;

        }

        List<Empleado> empleados = new List<Empleado>();

        public void Guardar(Empleado empleado)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Empleado(Id,Nombre, Telefono,Usuario,Contraseña)values" + "(@Id,@Nombre,@Telefono,@Usuario,@Contraseña)";
                Comando.Parameters.AddWithValue("@Id", empleado.Id);
                Comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                Comando.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                Comando.Parameters.AddWithValue("@Usuario", empleado.Usuario);
                Comando.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);


                Comando.ExecuteNonQuery();
            }

        }


        public void modificarBD(string id, Empleado empleado)
        {
            EliminarBD(id);
            Guardar(empleado);



        }
        public void EliminarBD(string id)
        {
            using (var Comando = conexion.CreateCommand())
            {

                Comando.CommandText = "delete from Empleado where Id= @Id";
                Comando.Parameters.AddWithValue("@Id", id);
                Comando.ExecuteNonQuery();
            }


        }
        public IList<Empleado> ConsultarBD()
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Empleado";
                conexion.Open();
                reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado = Map(reader);
                    empleados.Add(empleado);

                }
            }
            conexion.Close();
            return empleados;


        }
        public Empleado Map(SqlDataReader reader)
        {
            Empleado empleado = new Empleado();
            empleado.Id = (string)reader["Identificacion"];
            empleado.Nombre = (string)reader["Nombre"];
            empleado.Telefono = (string)reader["Telefono"];
            empleado.Usuario = (string)reader["Usuario"];
            empleado.Contraseña =(string)reader["Contraseña"];
            return empleado;

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
