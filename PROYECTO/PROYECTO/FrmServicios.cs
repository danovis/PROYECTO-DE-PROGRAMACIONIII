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
using Entity;
using DAL;
using BLL;
namespace PROYECTO
{
    public partial class FrmServicios : Form
    {
        ServiceFacturaBD serviceFactura = new ServiceFacturaBD();
        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False");

        public FrmServicios()
        {
            
            InitializeComponent();
        }

        private void dtgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            cbEmpleado.DataSource = LlenarComboboxEmpleado();
            cbEmpleado.DisplayMember = "Nombre";
            cbEmpleado.ValueMember = "Id";


            cbCliente.DataSource = LlenarComboboxCliente();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "Id";
            Actualizar();
        }
        

        public void Actualizar()
        {
            SqlCommand comando = new SqlCommand("Select *FROM Facturas ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgvFacturas.DataSource = tabla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Factura FacturaCreada = MapearFactura();


            var mensaje = serviceFactura.Guardar(FacturaCreada);

            MessageBox.Show(mensaje, "Confirmacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();


        }
        public Factura MapearFactura()
        {
            Factura factura = new Factura();
            var identificacion = txtId.Text;
            var cliente = cbCliente.Text;
            var empleado = cbEmpleado.Text;
            var producto = txtProducto.Text;
            var cantidad = txtCantidad.Text;
            var valor = txtValor.Text;
            var fecha = dateTime.Text;

            factura.Id = identificacion;
            factura.NombreCliente = cliente;
            factura.NombreEmpleado = empleado;
            factura.Producto = producto;
            factura.Cantidad = cantidad;
            factura.Valor = valor;
            factura.dateTime = fecha;

            return factura;

        }

        public void Limpiar()
        {
            txtCantidad.Text = "";
            
            txtId.Text = "";
            txtProducto.Text = "";
            txtTotal.Text = "";
            txtValor.Text = "";
            cbCliente.Text = "";
            cbEmpleado.Text = "";
                
                
    }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            Total();

        }

        public void Total()
        {
            double total = 0;

            foreach (DataGridViewRow row in dtgvFacturas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Valor"].Value);
            }

            txtTotal.Text = Convert.ToString(total);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total;
            total = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtValorUnitario.Text);
            txtValor.Text = Convert.ToString(total);
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

        public DataTable LlenarComboboxEmpleado()
        {
            SqlCommand cmd = new SqlCommand("SELECT Id,Nombre FROM Empleado ", conexion);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;

        }

        public DataTable LlenarComboboxCliente()
        {
            SqlCommand cmd = new SqlCommand("SELECT Id,Nombre FROM Cliente ", conexion);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            return dt;

        }




        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

