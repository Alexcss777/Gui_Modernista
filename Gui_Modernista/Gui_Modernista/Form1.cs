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

namespace Gui_Modernista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void Btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void Btnreporte_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }
        private void Btnrptventa_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void Btnrptcompra_Click(object sender, EventArgs e)
        {
           SubmenuReportes.Visible = false;
        }

        private void Btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void SubmenuReportes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
