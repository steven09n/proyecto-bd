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


namespace loginAC
{
    public partial class Form1 : Form
    {

        conectar cone;
        new Menu Men;
        public Form1()
        {
            InitializeComponent();

        }





        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wparam, int lparam, int v);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textlogin_Enter(object sender, EventArgs e)
        {
            if (textlogin.Text == "USUARIO")
            {
                textlogin.Text = "";
                textlogin.ForeColor = Color.LightGray;
            }
        }

        private void textlogin_Leave(object sender, EventArgs e)
        {
            if (textlogin.Text == "")
            {
                textlogin.Text = "USUARIO";
                textlogin.ForeColor = Color.LightGray;
            }
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "CONTRASEÑA")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.LightGray;
                textpass.UseSystemPasswordChar = true;
            }
        }

        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.LightGray;
                textpass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cone = new conectar(textlogin.Text, textpass.Text);

            if (this.cone.connect.State == ConnectionState.Open)
            {
                Menu = new men();
                Menu.Show();

                this.Hide();
            }
        }

        private void textlogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




