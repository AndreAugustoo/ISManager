using FontAwesome.Sharp;
using ISManager.Class;
using ISManager.Forms;
using ISManager.Properties;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ISManager
{
    public partial class frmMenu : Form
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

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Database database;

        public frmMenu()
        {
            InitializeComponent();

            /*Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));*/

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

            //aplica tema
            if (tgbChangeTheme.Checked == true) //Modo noturno
            {
                ThemeManager.ApplyDarkTheme(childForm);
                this.BackColor = Color.White;
            }

            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.ForeColor = RGBColors.activeForeColor;
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.activeForeColor;
            lblTitleChildForm.ForeColor = RGBColors.activeForeColor;
            lblTitleChildForm.Text = "Home";
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Dashboard";
            OpenChildForm(new frmDashboard());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Implantações";
            OpenChildForm(new frmClientes());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnMigracoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Migrações";
            OpenChildForm(new frmMigracoes());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Sair";
            OpenChildForm(new frmSair());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
            tgbChangeTheme.Visible = true;
            themeIcon.Visible = true;
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

        private void ApplyDarkTheme(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    // Altere as propriedades do TextBox
                    textBox.BackColor = Color.FromArgb(57, 57, 57);
                    textBox.ForeColor = Color.White;
                }
                else if (control is Panel)
                {
                    Panel panel = (Panel)control;
                    // Altere as propriedades do Panel
                    panel.BackColor = Color.FromArgb(57, 57, 57);
                }
                else if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    // Altere as propriedades do form
                    comboBox.BackColor = Color.FromArgb(57, 57, 57);
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
                    label.BackColor = Color.FromArgb(57, 57, 57);
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
            RGBColors.btnBackColor = Color.FromArgb(57, 57, 57);
            RGBColors.btnForeColor = Color.White;

            btnDashboard.ForeColor = Color.White;
            btnClientes.ForeColor = Color.White;
            btnMigracoes.ForeColor = Color.White;
            btnDocumentacao.ForeColor = Color.White;
            btnRetreinamento.ForeColor = Color.White;
            btnSair.ForeColor = Color.White;
            btnClose.ForeColor = Color.White;
            btnMaximaze.ForeColor = Color.White;
            btnMinimaze.ForeColor = Color.White;

            btnDashboard.IconColor = Color.White;
            btnDocumentacao.IconColor = Color.White;
            btnRetreinamento.IconColor = Color.White;
            btnClientes.IconColor = Color.White;
            btnMigracoes.IconColor = Color.White;
            btnSair.IconColor = Color.White;
            btnClose.IconColor = Color.White;
            btnMaximaze.IconColor = Color.White;
            btnMinimaze.IconColor = Color.White;
            iconCurrentChildForm.IconColor = RGBColors.activeForeColor;
            lblTitleChildForm.ForeColor = RGBColors.activeForeColor;

            btnDashboard.BackColor = Color.FromArgb(57, 57, 57);
            btnClientes.BackColor = Color.FromArgb(57, 57, 57);
            btnMigracoes.BackColor = Color.FromArgb(57, 57, 57);
            btnDocumentacao.BackColor = Color.FromArgb(57, 57, 57);
            btnRetreinamento.BackColor = Color.FromArgb(57, 57, 57);
            btnSair.BackColor = Color.FromArgb(57, 57, 57);

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
            btnDashboard.BackColor = Color.White;
            btnClientes.IconColor = Color.FromArgb(57, 57, 57);
            btnClientes.BackColor = Color.White;
            btnMigracoes.IconColor = Color.FromArgb(57, 57, 57);
            btnMigracoes.BackColor = Color.White;
            btnDocumentacao.BackColor = Color.White;
            btnRetreinamento.BackColor = Color.White;
            btnDocumentacao.IconColor = Color.FromArgb(57, 57, 57);
            btnRetreinamento.IconColor = Color.FromArgb(57, 57, 57);
            btnSair.IconColor = Color.FromArgb(57, 57, 57);
            btnSair.BackColor = Color.White;
            btnClose.IconColor = Color.FromArgb(57, 57, 57);
            btnMaximaze.IconColor = Color.FromArgb(57, 57, 57);
            btnMinimaze.IconColor = Color.FromArgb(57, 57, 57);
        }
        private void tgbChangeTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbChangeTheme.Checked == true) //Modo noturno
            {
                ApplyDarkTheme(this);
                themeIcon.Image = Resources.sunLight;
                Crud.Instance.darkTheme = true;
            }
            else if (tgbChangeTheme.Checked == false) // Modo claro
            {
                ApplyLightTheme(this);
                themeIcon.Image = Resources.sunDark;
                Crud.Instance.darkTheme = false;
            }
        }

        private void btnDocumentacao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Documentação";
            OpenChildForm(new frmDocumentacao());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnRetreinamento_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Retreinamento";
            OpenChildForm(new frmRetreinamento());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }

        private void btnReembolso_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.activeForeColor);
            lblTitleChildForm.Text = "Reembolso";
            OpenChildForm(new frmReembolso());
            tgbChangeTheme.Visible = false;
            themeIcon.Visible = false;
        }
    }
}
