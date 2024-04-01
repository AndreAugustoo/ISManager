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

namespace ISManager
{
    public partial class frmDashboard : Form
    {
        private Clientes clientes;
        public frmDashboard()
        {
            InitializeComponent();
            Exit.ConfigurarBotaoFechar(btnSair);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.clientes = new Clientes();
            MySqlDataReader resultadoSelect = this.clientes.ListarNumeroRegistro();
            resultadoSelect.Read();
            int numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalImplantacoes.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalAberto();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalAberto.Text = numeroRegistros.ToString();

            resultadoSelect = this.clientes.ListarTotalFechado();
            resultadoSelect.Read();
            numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblTotalFechado.Text = numeroRegistros.ToString();

        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
