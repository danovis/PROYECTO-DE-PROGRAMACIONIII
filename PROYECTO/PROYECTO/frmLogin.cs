using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using DAL;

namespace PROYECTO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtUsuario);
            sList.Add("USUARIO");

            tList.Add(txtPasword);
            sList.Add("CONTRASEÑA");
            SetCueBanner(ref tList, sList);
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProyectoCignus;Integrated Security=True;Pooling=False");

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

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


        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();

        }

        public void Login()
        {
            try
            {
                frmMenu menu = new frmMenu();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Usuario,Contraseña FROM Empleado WHERE Usuario ='" + txtUsuario.Text + "' AND Contraseña ='" + txtPasword.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Visible = false;
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            w = this.Width;
            h = this.Height;
        }

        public void Logear(string Usuario, string Contraseña)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ");
        }
    }
}
