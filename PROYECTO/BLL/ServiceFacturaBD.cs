using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace BLL
{
   public  class ServiceFacturaBD
    {
        SqlConnection conexion;
        RepositoryFacturasBD repositoryFacturasBD;
        RepositoryFactura repositoryFactura = new RepositoryFactura();

        public ServiceFacturaBD()
        {
            string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False";
            conexion = new SqlConnection(cadena);
            repositoryFacturasBD = new RepositoryFacturasBD(conexion);
        }


        public PdfPTable LlenarTabla(List<Factura> facturas)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("ID"));
            tabla.AddCell(new Paragraph("Nombre Cliente"));
            tabla.AddCell(new Paragraph("Nombre Empleado"));
            tabla.AddCell(new Paragraph("Producto"));
            tabla.AddCell(new Paragraph("Cantidad"));
            tabla.AddCell(new Paragraph("Valor"));
            tabla.AddCell(new Paragraph("Fecha"));

            foreach (var item in facturas)
            {
                tabla.AddCell(item.Id);
                tabla.AddCell(item.NombreCliente);
                tabla.AddCell(item.NombreEmpleado);
                tabla.AddCell(item.Producto);
                tabla.AddCell(item.Cantidad);
                tabla.AddCell(item.Valor);
                tabla.AddCell(item.dateTime);
            }
            return tabla;
        }

        public void  GuardarPdf(List<Factura> facturas, string ruta)
        {
            
            ruta = @"C:\Users\coron\Desktop\PDF\CIGNUS.pdf";
            FileStream fs = new FileStream(ruta, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter pw = PdfWriter.GetInstance(document, fs);
            document.AddTitle("FACTURAS");

            document.Open();
            document.Add(new Paragraph("Lista Facturas"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(facturas));
            document.Close();


        }


        public String Guardar(Factura factura)
        {
            try
            {
                conexion.Open();
                repositoryFacturasBD.Guardar(factura);
                conexion.Close();
                return "Se registro la factura  " + factura.Id;

            }
            catch (Exception e)
            {

                conexion.Close();
                return "Error de Base de Datos" + e;
            }


        }
        public Factura BuscarFactura(string identificacion)
        {

            return repositoryFactura.Buscar(identificacion);
        }
        public String Buscar(string identificacion)
        {
            if (repositoryFactura.Buscar(identificacion) == null)
            {


                return $"No se encontro la Factura  con identificacion {identificacion}";
            }
            else
            {

                return repositoryFactura.Buscar(identificacion).ToString();


            }
        }
        public void modificar(string id, Factura factura)
        {
            conexion.Open();

            repositoryFacturasBD.modificarBD(id, factura);
            conexion.Close();
        }

        public string EliminarBD(string id)
        {
            try
            {
                conexion.Open();
                repositoryFacturasBD.EliminarBD(id);
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
            if (repositoryFactura.Buscar(identificacion) == null)
            {
                return "Identificacion no encontrada";
            }
            else
            {
                repositoryFactura.Eliminar(identificacion);
                return $"La persona con identificacion {identificacion} fue eliminada";

            }
        }


        public IList<Factura> ConsultarBD()
        {

            return repositoryFacturasBD.ConsultarBD();

        }


        public String Modificar(String identificacion, Factura factura)
        {
            if (repositoryFactura.Buscar(identificacion) == null)
            {
                return "Factura no encontrada";
            }
            else
            {
                repositoryFactura.Modificar(identificacion, factura);
                return "Los Datos fueron modificados con exito";

            }

        }

    }
}
