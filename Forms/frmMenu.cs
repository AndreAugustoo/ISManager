using FontAwesome.Sharp;
using ISManager.Class;
using ISManager.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace ISManager
{
    public partial class frmMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Database database;

        public frmMenu()
        {
            InitializeComponent();

            btnDashboard.Enabled = false;
            btnClientes.Enabled = false;
            btnMigracoes.Enabled = false;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color activeForeColor = Color.FromArgb(82, 67, 254); //82; 67; 254  azul
            public static Color btnBackColor = Color.FromArgb(255, 255, 255); //255; 255; 255  azul
            public static Color btnForeColor = Color.FromArgb(57, 57, 57); //57; 57; 57  azul
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.btnBackColor;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.btnBackColor;
                currentBtn.ForeColor = RGBColors.btnForeColor;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.btnForeColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            if (tgbChangeTheme.Checked == true) //Modo noturno
            {
                ThemeManager.ApplyDarkTheme(childForm);
            }
            else if (tgbChangeTheme.Checked == false) // Modo claro
            {

            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.btnBackColor;
            lblTitleChildForm.Text = "Home";
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Dashboard";
            OpenChildForm(new frmDashboard());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Implantações";
            OpenChildForm(new frmClientes());
        }

        private void btnMigracoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Migrações";
            OpenChildForm(new frmMigracoes());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Sair";
            OpenChildForm(new frmSair());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimaze_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
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
            btnDashboard.Enabled = true;
            btnClientes.Enabled = true;
            btnMigracoes.Enabled = true;

        }
        private void ApplyDarkTheme(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    // Altere as propriedades do TextBox
                    textBox.BackColor = Color.FromArgb(25, 25, 25);
                    textBox.ForeColor = Color.White;
                }
                else if (control is Panel)
                {
                    Panel panel = (Panel)control;
                    // Altere as propriedades do Panel
                    panel.BackColor = Color.FromArgb(25, 25, 25);
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    // Altere as propriedades do form
                    comboBox.BackColor = Color.FromArgb(25, 25, 25);
                    comboBox.ForeColor = Color.White;
                }
                else if (control is Button)
                {
                    Button button = (Button)control;
                    // Altere as propriedades do Button
                    button.ForeColor = Color.White;
                }
                else if (control is Label)
                {
                    Label label = (Label)control;
                    // Altere as propriedades do label
                    label.ForeColor = Color.White;
                    label.BackColor = Color.FromArgb(25, 25, 25);
                }
                else if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    // Altere as propriedades do label
                    groupBox.ForeColor = Color.White;
                }
                if (control.HasChildren)
                {
                    ApplyDarkTheme(control);
                }
            }
                //mudanças fora do control
                frmMenu FrmMenu_Vrb = new frmMenu();
                FrmMenu_Vrb.BackColor = Color.White;
                RGBColors.btnBackColor = Color.FromArgb(25, 25, 25);
                RGBColors.btnForeColor = Color.White;
                
                btnDashboard.ForeColor = Color.White;
                btnClientes.ForeColor = Color.White;
                btnMigracoes.ForeColor = Color.White;
                btnSair.ForeColor = Color.White;
                btnClose.ForeColor = Color.White;
                btnMaximaze.ForeColor = Color.White;
                btnMinimaze.ForeColor = Color.White;

                btnDashboard.IconColor = Color.White;
                btnClientes.IconColor = Color.White;
                btnMigracoes.IconColor = Color.White;
                btnSair.IconColor = Color.White;
                btnClose.IconColor = Color.White;
                btnMaximaze.IconColor = Color.White;
                btnMinimaze.IconColor = Color.White;
                btnConectar.ForeColor = Color.FromArgb(57, 57, 57);
                btnConectar.IconColor = Color.FromArgb(57, 57, 57);

        }
         private void ApplyLightTheme(Control parentControl)
         {
             foreach (Control control in parentControl.Controls)
             {
                 if (control is TextBox)
                 {
                     TextBox textBox = (TextBox)control;
                     // Altere as propriedades do TextBox
                     textBox.BackColor = Color.White;
                     textBox.ForeColor = Color.FromArgb(57, 57, 57);
                 }
                 else if (control is Panel)
                 {
                     Panel panel = (Panel)control;
                     // Altere as propriedades do Panel
                     panel.BackColor = Color.White;
                 }
                 else if (control is Button)
                 {
                     Button button = (Button)control;
                     // Altere as propriedades do Button
                     button.ForeColor = Color.FromArgb(57, 57, 57);
                 }
                 else if (control is Label)
                 {
                     Label label = (Label)control;
                     // Altere as propriedades do label
                     label.ForeColor = Color.FromArgb(57, 57, 57);
                     label.BackColor = Color.White;
                 }
                 else if (control is GroupBox)
                 {
                     GroupBox groupBox = (GroupBox)control;
                     // Altere as propriedades do label
                     groupBox.ForeColor = Color.FromArgb(57, 57, 57);
                 }
                if (control.HasChildren)
                {
                    ApplyLightTheme(control);
                }
            }
            //mudanças fora do control
            frmMenu FrmMenu_Vrb = new frmMenu();
            FrmMenu_Vrb.BackColor = Color.FromArgb(57, 57, 57);
            RGBColors.btnBackColor = Color.White;
            RGBColors.btnForeColor = Color.FromArgb(57, 57, 57);
            btnDashboard.IconColor = Color.FromArgb(57, 57, 57);
            btnClientes.IconColor = Color.FromArgb(57, 57, 57);
            btnMigracoes.IconColor = Color.FromArgb(57, 57, 57);
            btnSair.IconColor = Color.FromArgb(57, 57, 57);
            btnClose.IconColor = Color.FromArgb(57, 57, 57);
            btnMaximaze.IconColor = Color.FromArgb(57, 57, 57);
            btnMinimaze.IconColor = Color.FromArgb(57, 57, 57);
            btnConectar.ForeColor = Color.FromArgb(57, 57, 57);
            btnConectar.IconColor = Color.FromArgb(57, 57, 57);
        }
        private void tgbChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbChangeTheme.Checked == true) //Modo noturno
            {
                ApplyDarkTheme(this);
            }
            else if (tgbChangeTheme.Checked == false) // Modo claro
            {
                ApplyLightTheme(this);
            }
        }
    }
}
