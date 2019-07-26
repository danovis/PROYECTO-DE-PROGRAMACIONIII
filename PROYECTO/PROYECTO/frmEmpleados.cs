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
    public partial class frmEmpleados : Form
    {
        SqlConnection conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False");

        ServiceEmpleadoBD service;
        IReceptor frmReceptor;
        ServiceEmpleadoBD serviceEmpleado = new ServiceEmpleadoBD();

        public frmEmpleados()
        {
            InitializeComponent();

        }

        public frmEmpleados(IReceptor iReceptor)
        {
            InitializeComponent();
            service = new ServiceEmpleadoBD();
            frmReceptor = iReceptor;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            frmAddEmpleado fr = new frmAddEmpleado();
            fr.btnEditar.Visible = false;
            fr.btnGuardar.Visible = true;
            fr.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

       private void Actualizar()
        {
            SqlCommand comando = new SqlCommand("Select *FROM Empleado ", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtgvEmpleados.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgvEmpleados.SelectedRows.Count > 0)
            {
                var identificacion = dtgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                var mensaje = serviceEmpleado.EliminarBD(identificacion);
                MessageBox.Show(mensaje, "Confirmacion de ELiminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddEmpleado fr = new frmAddEmpleado();
             
            if (dtgvEmpleados.SelectedRows.Count > 0)
            {
                fr.btnEditar.Visible = true;
                fr.btnGuardar.Visible = false;
                fr.txtId.Text = dtgvEmpleados.CurrentRow.Cells["Id"].Value.ToString();
                fr.txtNombre.Text = dtgvEmpleados.CurrentRow.Cells["Nombre"].Value.ToString();
                fr.txtTelefono.Text = dtgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                fr.txtUsuario.Text = dtgvEmpleados.CurrentRow.Cells["Usuario"].Value.ToString();
                fr.txtContraseña.Text = dtgvEmpleados.CurrentRow.Cells["Contraseña"].Value.ToString();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltar_TextChanged(object sender, EventArgs e)
        {
            
            {

                string query = "SELECT * FROM Empleado WHERE Id LIKE @param + '%'";


                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@param", txtFiltar.Text);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                dtgvEmpleados.DataSource = dt;

            }

        }

        private void dtgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }
    }
    }
    

