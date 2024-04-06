using ISManager.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ISManager
{
    public partial class frmDashboard : Form
    {
        private Clientes clientes;
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.clientes = new Clientes();
            MySqlDataReader resultadoSelect = this.clientes.ListarNumeroRegistro();
            resultadoSelect.Read();
            int numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalImplantacoes.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalFechado();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalFechado.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalCancelado();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalCancelado.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalAberto();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalAberto.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalAndre();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalAndre.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalEdivania();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalEdivania.Text = numeroRegistros.ToString();

            panelTotalImplantacao.BackColor = Color.FromArgb(255, 128, 40);
            panelTotalAberto.BackColor = Color.FromArgb(0, 126, 249);
            panelTotalAbertoISM.BackColor = Color.FromArgb(0, 126, 249);
            panelTotalFinalizado.BackColor = Color.FromArgb(50, 226, 178);
            panelTotalCancelado.BackColor = Color.FromArgb(226, 50, 90);

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
          /*  this.pnlFormLoader.Controls.Clear();*/
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
         /*   this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);*/
            FrmDashboard_Vrb.Show();
        }
    }
}
