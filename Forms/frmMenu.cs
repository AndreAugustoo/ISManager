using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;


                /* COLORS
                formBackColor: 46; 51; 73
                Primary: 24; 30; 54
                Secundary: 0; 126; 249
                txt: 158; 161; 176
                */

namespace ISManager
{
    public partial class frmMenu : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmMenu()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubNome_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
            btnClientes.BackColor = Color.FromArgb(24, 30, 54);
            btnMigracoes.BackColor = Color.FromArgb(24, 30, 54);
            btnSair.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnClientes.Height;
            pnlNav.Top = btnClientes.Top;
            btnClientes.BackColor = Color.FromArgb(46, 51, 73);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            btnMigracoes.BackColor = Color.FromArgb(24, 30, 54);
            btnSair.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlFormLoader.Controls.Clear();
            frmClientes FrmClientes_Vrb = new frmClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmClientes_Vrb);
            FrmClientes_Vrb.Show();
        }

        private void btnMigracoes_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMigracoes.Height;
            pnlNav.Top = btnMigracoes.Top;
            btnMigracoes.BackColor = Color.FromArgb(46, 51, 73);
            btnClientes.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
            btnSair.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlFormLoader.Controls.Clear();
            frmMigracoes FrmMigracoes_Vrb = new frmMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmMigracoes_Vrb);
            FrmMigracoes_Vrb.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSair.Height;
            pnlNav.Top = btnSair.Top;
            btnSair.BackColor = Color.FromArgb(46, 51, 73);
            btnClientes.BackColor = Color.FromArgb(24, 30, 54);
            btnMigracoes.BackColor = Color.FromArgb(24, 30, 54);
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);

            this.pnlFormLoader.Controls.Clear();
            frmSair FrmSair_Vrb = new frmSair() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSair_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSair_Vrb);
            FrmSair_Vrb.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClientes_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMigracoes_Leave(object sender, EventArgs e)
        {
            btnMigracoes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSair_Leave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
