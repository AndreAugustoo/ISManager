using ISManager.Class;
using ISManager.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISManager
{
    public partial class frmClientes : Form
    {
        private Clientes clientes;
        private Crud crud;

        public frmClientes()
        {
            InitializeComponent();
            Exit.ConfigurarBotaoFechar(btnSair);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dtGridClientes.BackgroundColor = Color.White;
            this.clientes = new Clientes();
            MySqlDataReader temp = this.clientes.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridClientes.DataSource = dt;


            MySqlDataReader resultadoSelect = this.clientes.ListarNumeroRegistro();
            resultadoSelect.Read();
            int numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblNumeroRegistro.Text = "Número de registros encontrados: " + numeroRegistros.ToString();

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String filtro = txtFiltro.Text;
            String campo = cbxFiltro.Text;
            if (campo == "ID")
            {
                campo = "id_cliente";
            }
            else if (campo == "Nome")
            {
                campo = "nome_cliente";
            }
            else if (campo == "ISM")
            {
                campo = "ism_responsavel_cliente";
            }
            else if (campo == "Status")
            {
                campo = "status_implantacao_cliente";
            }
            else
            {
                MessageBox.Show("Erro");
            }

            MySqlDataReader temp = this.clientes.ListarClientes(campo, filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridClientes.DataSource = dt;
        }

        private void dtGridClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Crud.Instance.TipoCrud = 3;

            this.pnlClientes.Controls.Clear();
            frmCrudClientes FrmCrudClientes_Vrb = new frmCrudClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlClientes.Controls.Add(FrmCrudClientes_Vrb);
            FrmCrudClientes_Vrb.Show();

            DataGridViewRow linha = dtGridClientes.Rows[e.RowIndex];
            FrmCrudClientes_Vrb.txtId.Text = linha.Cells["ID"].Value.ToString();
            FrmCrudClientes_Vrb.txtNome.Text = linha.Cells["Nome"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataEntrada.Text = linha.Cells["Data entrada"].Value.ToString();
            FrmCrudClientes_Vrb.cbxNecessidade.Text = linha.Cells["Necessidade"].Value.ToString();
            FrmCrudClientes_Vrb.cbxIsm.Text = linha.Cells["ISM"].Value.ToString();
            FrmCrudClientes_Vrb.cbxStatus.Text = linha.Cells["Status"].Value.ToString();
            FrmCrudClientes_Vrb.cbxBackup.Text = linha.Cells["Backup"].Value.ToString();
            FrmCrudClientes_Vrb.txtHoras.Text = linha.Cells["Horas"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataFechamento.Text = linha.Cells["Data fechamento"].Value.ToString();
            FrmCrudClientes_Vrb.txtObservacao.Text = linha.Cells["Observação"].Value.ToString();
            FrmCrudClientes_Vrb.txtId.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 1;

            this.pnlClientes.Controls.Clear();
            frmCrudClientes FrmCrudClientes_Vrb = new frmCrudClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlClientes.Controls.Add(FrmCrudClientes_Vrb);
            FrmCrudClientes_Vrb.Show();

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 3;

            this.pnlClientes.Controls.Clear();
            frmCrudClientes FrmCrudClientes_Vrb = new frmCrudClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlClientes.Controls.Add(FrmCrudClientes_Vrb);
            FrmCrudClientes_Vrb.Show();

            DataGridViewRow linha = dtGridClientes.SelectedRows[0];
            FrmCrudClientes_Vrb.txtId.Text = linha.Cells["ID"].Value.ToString();
            FrmCrudClientes_Vrb.txtNome.Text = linha.Cells["Nome"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataEntrada.Text = linha.Cells["Data entrada"].Value.ToString();
            FrmCrudClientes_Vrb.cbxNecessidade.Text = linha.Cells["Necessidade"].Value.ToString();
            FrmCrudClientes_Vrb.cbxIsm.Text = linha.Cells["ISM"].Value.ToString();
            FrmCrudClientes_Vrb.cbxStatus.Text = linha.Cells["Status"].Value.ToString();
            FrmCrudClientes_Vrb.cbxBackup.Text = linha.Cells["Backup"].Value.ToString();
            FrmCrudClientes_Vrb.txtHoras.Text = linha.Cells["Horas"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataFechamento.Text = linha.Cells["Data fechamento"].Value.ToString();
            FrmCrudClientes_Vrb.txtObservacao.Text = linha.Cells["Observação"].Value.ToString();
            FrmCrudClientes_Vrb.txtId.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 4;

            this.pnlClientes.Controls.Clear();
            frmCrudClientes FrmCrudClientes_Vrb = new frmCrudClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlClientes.Controls.Add(FrmCrudClientes_Vrb);
            FrmCrudClientes_Vrb.Show();

            DataGridViewRow linha = dtGridClientes.SelectedRows[0];
            FrmCrudClientes_Vrb.txtId.Text = linha.Cells["ID"].Value.ToString();
            FrmCrudClientes_Vrb.txtNome.Text = linha.Cells["Nome"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataEntrada.Text = linha.Cells["Data entrada"].Value.ToString();
            FrmCrudClientes_Vrb.cbxNecessidade.Text = linha.Cells["Necessidade"].Value.ToString();
            FrmCrudClientes_Vrb.cbxIsm.Text = linha.Cells["ISM"].Value.ToString();
            FrmCrudClientes_Vrb.cbxStatus.Text = linha.Cells["Status"].Value.ToString();
            FrmCrudClientes_Vrb.txtHoras.Text = linha.Cells["Horas"].Value.ToString();
            FrmCrudClientes_Vrb.cbxBackup.Text = linha.Cells["Backup"].Value.ToString();
            FrmCrudClientes_Vrb.txtDataFechamento.Text = linha.Cells["Data fechamento"].Value.ToString();
            FrmCrudClientes_Vrb.txtObservacao.Text = linha.Cells["Observação"].Value.ToString();

            FrmCrudClientes_Vrb.txtId.Enabled = false;
            FrmCrudClientes_Vrb.txtNome.Enabled = false;
            FrmCrudClientes_Vrb.txtDataEntrada.Enabled = false;
            FrmCrudClientes_Vrb.cbxNecessidade.Enabled = false;
            FrmCrudClientes_Vrb.cbxIsm.Enabled = false;
            FrmCrudClientes_Vrb.cbxStatus.Enabled = false;
            FrmCrudClientes_Vrb.txtHoras.Enabled = false;
            FrmCrudClientes_Vrb.cbxBackup.Enabled = false;
            FrmCrudClientes_Vrb.txtDataFechamento.Enabled = false;
            FrmCrudClientes_Vrb.txtObservacao.Enabled = false;

            FrmCrudClientes_Vrb.btnConfirmar.Text = "Excluir";
            FrmCrudClientes_Vrb.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            FrmCrudClientes_Vrb.btnConfirmar.BackColor = Color.IndianRed;
            FrmCrudClientes_Vrb.btnCancelar.BackColor = Color.Silver;

        }

        private void pnlClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}