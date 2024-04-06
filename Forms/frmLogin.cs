using ISManager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISManager.Forms
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        private Database database;
        public frmLogin()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            Database.host = txtHost.Text;
            Database.porta = txtPort.Text;
            Database.nomeBanco = txtDatabase.Text;
            Database.usuario = txtUser.Text;
            Database.senha = txtPassword.Text;

            this.database = new Database();
            database.Conectar();
            MessageBox.Show("Conectado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMenu FrmMenu_Frb = new frmMenu();
            this.Hide();
            FrmMenu_Frb.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "ISManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            string gitHub = "https://github.com/AndreAugustoo";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = gitHub,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            string instagram = "https://www.instagram.com/andre.aaugusto/";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = instagram,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            string linkedin = "https://www.linkedin.com/in/andr%C3%A9-oliveira-76b1a61a2/";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = linkedin,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
