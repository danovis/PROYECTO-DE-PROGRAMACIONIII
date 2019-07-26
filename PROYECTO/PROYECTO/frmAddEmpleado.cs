using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PROYECTO
{
    public partial class frmAddEmpleado : Form
    {
        ServiceEmpleadoBD serviceEmpleado = new ServiceEmpleadoBD();
        public frmAddEmpleado()
        {
            InitializeComponent();
        }

        #region Dlls para poder hacer el movimiento del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado empleadoCreado = MapearEmpleado();


            var mensaje = serviceEmpleado.Guardar(empleadoCreado);

            MessageBox.Show(mensaje, "Confirmacion de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();


        }
        public Empleado MapearEmpleado()
        {
            Empleado empleado = new Empleado();
            var identificacion = txtId.Text;
            var nombre = txtNombre.Text;
            var telefono = txtTelefono.Text;
            var usuario = txtUsuario.Text;
            var contraseña = txtContraseña.Text;

            empleado.Id = identificacion;
            empleado.Nombre = nombre;
            empleado.Telefono = telefono;
            empleado.Usuario = usuario;
            empleado.Contraseña = contraseña;

            return empleado;

        }


        private void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var identificacion = txtId.Text;
            String mensaje;
            Empleado empleado = MapearEmpleado();
            serviceEmpleado.modificar(identificacion, empleado);
            MessageBox.Show("SE GUARDÓ CON EXITO ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();


        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void frmAddEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
