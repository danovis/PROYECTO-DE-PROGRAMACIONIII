using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
using DAL;
using iTextSharp.text;
 using iTextSharp.text.pdf;
 using System.IO;

namespace PROYECTO
{
    public partial class frmCaja : Form
    {
        ServiceFacturaBD service;
        IReceptor frmReceptor;
        ServiceFacturaBD serviceFactura = new ServiceFacturaBD();
        RepositoryFacturasBD repositoryFacturasBD;
        public frmCaja()
        {
            InitializeComponent();
        }

        public frmCaja(IReceptor iReceptor)
        {
            InitializeComponent();
            service = new ServiceFacturaBD();
            frmReceptor = iReceptor;
        }



        private void frmCaja_Load(object sender, EventArgs e)
        {
            Actualizar();

        }

        private void Actualizar()
        {

            using (SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False"))
            {
                SqlCommand comando = new SqlCommand("Select *FROM Facturas ", cnx);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dtgvFacturas.DataSource = tabla;

            }
            cbxFiltro.Text = "SELECCIONE";


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmAddServicio fr = new frmAddServicio();

            fr.btnEditar.Visible = false;
            fr.btnGuardar.Visible = true;
            fr.Show();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False");
            if (cbxFiltro.Text == "ID")
            {

                string query = "SELECT * FROM Facturas WHERE Id LIKE @param + '%'";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@param", txtFiltro.Text);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dtgvFacturas.DataSource = dt;

            }
            else if (cbxFiltro.Text == "CLIENTE")
            {
                string query = "SELECT * FROM Facturas WHERE NombreCliente LIKE @param + '%'";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@param", txtFiltro.Text);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dtgvFacturas.DataSource = dt;
            }
            else if (cbxFiltro.Text == "EMPLEADO")
            {
                string query = "SELECT * FROM Facturas WHERE NombreEmpleado LIKE @param + '%'";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@param", txtFiltro.Text);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dtgvFacturas.DataSource = dt;
            }
            else
            {
                MessageBox.Show("SELECCIONE FILTRO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTFiltro_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnx = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False"))
            {

                string query = "SELECT * FROM Facturas WHERE Fecha LIKE @param + '%'";


                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@param", DTFiltro.Text);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dtgvFacturas.DataSource = dt;

            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgvFacturas.SelectedRows.Count > 0)
            {
                var identificacion = dtgvFacturas.CurrentRow.Cells["Id"].Value.ToString();
                var mensaje = serviceFactura.EliminarBD(identificacion);
                MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione una Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Exportar_pdf()
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dtgvFacturas.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //Add header
            foreach (DataGridViewColumn column in dtgvFacturas.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dtgvFacturas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                   pdfPTable.AddCell(new Phrase(cell.Value.ToString()));

                }
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdfPTable);
                    pdfdoc.Close();
                    stream.Close();
                }
            }




        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Exportar_pdf();
            //string ruta = @"C:\Users\coron\Desktop\PDF\CIGNUS.pdf";
            //service.GuardarPdf(dtgvFacturas,ruta);
        }

        private void dtgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmReceptor != null)
            {
                Factura factura = (Factura)dtgvFacturas.CurrentRow.DataBoundItem;
                frmReceptor.Recibir(factura);
                this.Hide();

            }

        }

        //private void PedirRuta()
        //{
            
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = @"C:\Users\coron\Desktop\PDF";
        //    saveFileDialog.Title = "Guardar Reporte";
        //    saveFileDialog.DefaultExt = "pdf";
        //    saveFileDialog.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
        //    saveFileDialog.FilterIndex = 2;
        //    saveFileDialog.RestoreDirectory = true;
        //    string filename = @"C:\Users\coron\Desktop\PDF";
        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        filename = saveFileDialog.FileName;
        //    }
        //    if (filename.Trim() != "")
        //    {
        //        string mensage = service.GuardarPdf(filename,ruta);
        //       MessageBox.Show(mensage, "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
                
        //    }
        //}
    }
}
