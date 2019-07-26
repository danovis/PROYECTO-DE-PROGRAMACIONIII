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

namespace PROYECTO
{
    public partial class frmMenu : Form
    {
        public frmMenu()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnlcontenedor.Controls.Count > 0)
                this.pnlcontenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlcontenedor.Controls.Add(fh);
            this.pnlcontenedor.Tag = fh;
           fh.Show();

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {

            

        }

        private void btnServicios_Click_1(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmServicios());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnServicios_Click_2(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmServicios());
           
           
           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmEmpleados());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmClientes());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmCaja());
        }

        private void BtnSignOff_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fr = new frmLogin();
            fr.Visible = true;
        }

        private void pnlcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        private void frmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
