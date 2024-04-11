using ISManager.Class;
using ISManager.Forms;
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
    public partial class frmMigracoes : Form
    {
        private Migracoes migracoes;
        public frmMigracoes()
        {
            InitializeComponent();
        }

        private void frmMigracoes_Load(object sender, EventArgs e)
        {
            dtGridMigracoes.BackgroundColor = Color.White;
            this.migracoes = new Migracoes();
            MySqlDataReader temp = this.migracoes.ListarMigracoes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridMigracoes.DataSource = dt;


            MySqlDataReader resultadoSelect = this.migracoes.ListarNumeroRegistro();
            resultadoSelect.Read();
            int numeroRegistros = resultadoSelect.GetInt32(0);
            resultadoSelect.Close();
            lblNumeroRegistro.Text = "Número total de registros: " + numeroRegistros.ToString();

            if (numeroRegistros >= 100)
            {
                lblRegistroExibido.Text = "Número de registros exibidos: " + 100;
            }
            else
            {
                lblRegistroExibido.Text = "Número de registros exibidos: " + numeroRegistros.ToString();
            }


            ExibirFiltroData();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            String filtro = txtFiltro.Text;
            String filtro2 = "";
            String campo = cbxFiltro.Text;

            if (campo == "ID")
            {
                campo = "id_cliente";
            }
            else if (campo == "Nome")
            {
                campo = "nome_cliente";
            }
            else if (campo == "Status")
            {
                campo = "status";
            }
            else if (campo == "Data atualização")
            {
                campo = "data_atualizacao";
                filtro = dtpDataInicio.Text.ToString();
                filtro2 = dtpDataFim.Text.ToString();
            }
            else
            {
                MessageBox.Show("Erro");
            }

            MySqlDataReader temp = this.migracoes.ListarMigracoes(campo, filtro, filtro2);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridMigracoes.DataSource = dt;
            lblRegistroExibido.Text = "Número de registros exibidos: " + dt.Rows.Count.ToString();
        }

        private void dtGridMigracoes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Crud.Instance.TipoCrud = 3;
            CarregarDadosParaFrmCrud();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 1;
            this.pnlMigracoes.Controls.Clear();
            frmCrudMigracoes FrmCrudMigracoes_Vrb = new frmCrudMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMigracoes.Controls.Add(FrmCrudMigracoes_Vrb);
            FrmCrudMigracoes_Vrb.Show();

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 3;
            CarregarDadosParaFrmCrud();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Crud.Instance.TipoCrud = 4;

            this.pnlMigracoes.Controls.Clear();
            frmCrudMigracoes FrmCrudMigracoes_Vrb = new frmCrudMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMigracoes.Controls.Add(FrmCrudMigracoes_Vrb);
            FrmCrudMigracoes_Vrb.Show();

            DataGridViewRow linha = dtGridMigracoes.SelectedRows[0];
            FrmCrudMigracoes_Vrb.txtId.Text = linha.Cells["ID"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtNome.Text = linha.Cells["Nome"].Value.ToString();
            FrmCrudMigracoes_Vrb.cbxStatus.Text = linha.Cells["Status"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtVersao.Text = linha.Cells["Versão atual"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtDataAtualizacao.Text = linha.Cells["Data atualização"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtObservacao.Text = linha.Cells["Observação"].Value.ToString();

            FrmCrudMigracoes_Vrb.txtId.Enabled = false;
            FrmCrudMigracoes_Vrb.txtNome.Enabled = false;
            FrmCrudMigracoes_Vrb.cbxStatus.Enabled = false;
            FrmCrudMigracoes_Vrb.txtVersao.Enabled = false;
            FrmCrudMigracoes_Vrb.txtDataAtualizacao.Enabled = false;
            FrmCrudMigracoes_Vrb.txtObservacao.Enabled = false;

            FrmCrudMigracoes_Vrb.btnConfirmar.Text = "Excluir";
            FrmCrudMigracoes_Vrb.btnConfirmar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            FrmCrudMigracoes_Vrb.btnConfirmar.BackColor = Color.IndianRed;
            FrmCrudMigracoes_Vrb.btnCancelar.BackColor = Color.Silver;

        }

        private void cbxFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            ExibirFiltroData();
        }

        private void ExibirFiltroData()
        {
            if (cbxFiltro.Text == "Data atualização")
            {
                dtpDataInicio.Visible = true;
                dtpDataFim.Visible = true;
                lblDataInicio.Visible = true;
                lblDataFim.Visible = true;
                txtFiltro.Visible = false;
            }
            else
            {
                dtpDataInicio.Visible = false;
                dtpDataFim.Visible = false;
                lblDataInicio.Visible = false;
                lblDataFim.Visible = false;
                txtFiltro.Visible = true;
            }
        }
        public void CarregarDadosParaFrmCrud()
        {
            this.pnlMigracoes.Controls.Clear();
            frmCrudMigracoes FrmCrudMigracoes_Vrb = new frmCrudMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCrudMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlMigracoes.Controls.Add(FrmCrudMigracoes_Vrb);
            FrmCrudMigracoes_Vrb.Show();

            DataGridViewRow linha = dtGridMigracoes.SelectedRows[0];
            FrmCrudMigracoes_Vrb.txtId.Text = linha.Cells["ID"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtNome.Text = linha.Cells["Nome"].Value.ToString();
            FrmCrudMigracoes_Vrb.cbxStatus.Text = linha.Cells["Status"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtVersao.Text = linha.Cells["Versão atual"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtDataAtualizacao.Text = linha.Cells["Data atualização"].Value.ToString();
            FrmCrudMigracoes_Vrb.txtObservacao.Text = linha.Cells["Observação"].Value.ToString();

            FrmCrudMigracoes_Vrb.txtId.Enabled = false;
        }
    }
}
