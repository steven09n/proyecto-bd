using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion.m
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            venta s = new venta();
            s.TopLevel = false;
            gunaPanel4.Controls.Add(s);
            s.BringToFront();
            s.Show();


        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
            Proveedores s = new Proveedores();
            s.TopLevel = false;
            gunaPanel4.Controls.Add(s);
            s.BringToFront();
            s.Show();

        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            usuario s = new usuario();
            s.TopLevel = false;
            gunaPanel4.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            inventario s = new inventario();
            s.TopLevel = false;
            gunaPanel4.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            ganancias s = new ganancias();
            s.TopLevel = false;
            gunaPanel4.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }
    }
}
