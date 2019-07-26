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
   public class RepositoryFacturasBD
    {
        SqlConnection conexion;
        private SqlDataReader reader;
        public RepositoryFacturasBD(SqlConnection conexion)
        {
            this.conexion = conexion;

        }

        List<Factura> facturas = new List<Factura>();

        public void Guardar(Factura factura)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert Into Facturas(Id,NombreCliente,NombreEmpleado,Producto,Cantidad,Valor,Fecha)values" + "(@Id,@NombreCliente,@NombreEmpleado,@Producto,@Cantidad,@Valor,@Fecha)";
                Comando.Parameters.AddWithValue("@Id", factura.Id);
                Comando.Parameters.AddWithValue("@NombreCliente", factura.NombreCliente);
                Comando.Parameters.AddWithValue("@NombreEmpleado", factura.NombreEmpleado);
                Comando.Parameters.AddWithValue("@Producto", factura.Producto);
                Comando.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                Comando.Parameters.AddWithValue("@Valor", factura.Valor);
                Comando.Parameters.AddWithValue("@Fecha", factura.dateTime);


                Comando.ExecuteNonQuery();
            }

        }


        public void modificarBD(string id, Factura factura)
        {
            EliminarBD(id);
            Guardar(factura);



        }
        public void EliminarBD(string id)
        {
            using (var Comando = conexion.CreateCommand())
            {

                Comando.CommandText = "delete from Facturas where Id= @Id";
                Comando.Parameters.AddWithValue("@Id", id);
                Comando.ExecuteNonQuery();
            }


        }


        
        public IList<Factura> ConsultarBD()
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Facturas";
                conexion.Open();
                reader = Comando.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new Factura();
                    factura = Map(reader);
                    facturas.Add(factura);

                }
            }
            conexion.Close();
            return facturas;


        }
        public Factura Map(SqlDataReader reader)
        {
            Factura factura = new Factura();
            factura.Id = (string)reader["Identificacion"];
            factura.NombreCliente = (string)reader["Nombre Cliente"];
            factura.NombreEmpleado = (string)reader["Nombre Empleado"];
            factura.Producto = (string)reader["Producto"];
            factura.Cantidad = (string)reader["Cantidad"];
            factura.Valor = (string)reader["Valor"];
            factura.dateTime = (string)reader["Fecha"];

            return factura;

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
