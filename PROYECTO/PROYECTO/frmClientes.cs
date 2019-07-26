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

namespace PROYECTO
{


    public partial class frmClientes : Form
    {
        ServiceClienteBD serviceCliente = new ServiceClienteBD();
        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False");
        ServiceClienteBD service;
        IReceptorCliente frmReceptor;


        public frmClientes()
        {
            InitializeComponent();
          
        }

        public frmClientes(IReceptorCliente iReceptor)
        {
            InitializeComponent();
            service = new ServiceClienteBD();
            frmReceptor = iReceptor;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmAddCliente fr = new frmAddCliente();
            fr.btnEditar.Visible = false;
            fr.btnGuardar.Visible = true;
            fr.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvClientes.SelectedRows.Count > 0)
            {
                var identificacion = dtgvClientes.CurrentRow.Cells["Id"].Value.ToString();
                var mensaje = serviceCliente.EliminarBD(identificacion);
                MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Actualizar()
        {
            SqlCommand comando = new SqlCommand("Select *FROM Cliente ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgvClientes.DataSource = tabla;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Actualizar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAddCliente fr = new frmAddCliente();

            if (dtgvClientes.SelectedRows.Count > 0)
            {
                fr.btnEditar.Visible = true;
                fr.btnGuardar.Visible = false;
                fr.txtId.Text = dtgvClientes.CurrentRow.Cells["Id"].Value.ToString();
                fr.txtNombre.Text = dtgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                fr.txtTelefono.Text = dtgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            {

                string query = "SELECT * FROM Cliente WHERE Id LIKE @param + '%'";


                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@param", txtFiltro.Text);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dtgvClientes.DataSource = dt;

            }
        }

        private void dtgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmReceptor != null)
            {
                Cliente cliente = (Cliente)dtgvClientes.CurrentRow.DataBoundItem;
                frmReceptor.Recibir(cliente);
                this.Hide();

            }

        }
    }
}
