using ISManager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISManager.Forms
{
    public partial class frmCrudMigracoes : Form
    {
        public int tipoCrud = Crud.Instance.TipoCrud;
        private Migracoes migracoes;
        public frmCrudMigracoes()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o ID do cliente!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (tipoCrud == 1)
            {
                // Cadastrar
                this.migracoes = new Migracoes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Versao_atual = txtVersao.Text,
                    Status = cbxStatus.Text,
                    Data_atualizacao = txtDataAtualizacao.Text,
                    Observacao_cliente = txtObservacao.Text,
                };

                this.migracoes.CadastrarMigracoes();
                MessageBox.Show("Cliente cadastrado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 3)
            {
                // Alterar
                this.migracoes = new Migracoes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Versao_atual = txtVersao.Text,
                    Status = cbxStatus.Text,
                    Data_atualizacao = txtDataAtualizacao.Text,
                    Observacao_cliente = txtObservacao.Text,
                };

                this.migracoes.AlterarMigracoes();
                MessageBox.Show("Cliente alterado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 4)
            {
                // Excluir
                this.migracoes = new Migracoes();
                this.migracoes = new Migracoes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Versao_atual = txtVersao.Text,
                    Status = cbxStatus.Text,
                    Data_atualizacao = txtDataAtualizacao.Text,
                    Observacao_cliente = txtObservacao.Text,
                };

                this.migracoes.ExcluirMigracoes();
                MessageBox.Show("Cliente excluído com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Voltar para frmMigracoes
            this.panelCrudMigracoes.Controls.Clear();
            frmMigracoes FrmMigracoes_Vrb = new frmMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelCrudMigracoes.Controls.Add(FrmMigracoes_Vrb);
            FrmMigracoes_Vrb.Show();
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Voltar para frmMigracoes
            this.panelCrudMigracoes.Controls.Clear();
            frmMigracoes FrmMigracoes_Vrb = new frmMigracoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmMigracoes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelCrudMigracoes.Controls.Add(FrmMigracoes_Vrb);
            FrmMigracoes_Vrb.Show();
        }

        private void frmCrudMigracoes_Load(object sender, EventArgs e)
        {
            //aplica tema
            if (Crud.Instance.darkTheme) //Modo noturno
            {
                ThemeManager.ApplyDarkTheme(this);
                txtDataAtualizacao.TextColor = Color.White;
                txtDataAtualizacao.BorderColor = Color.White;
                txtDataAtualizacao.SkinColor = Color.FromArgb(57, 57, 57);
                txtDataUltimaAtualizacao.TextColor = Color.White;
                txtDataUltimaAtualizacao.BorderColor = Color.White;
                txtDataUltimaAtualizacao.SkinColor = Color.FromArgb(57, 57, 57);
            }
        }
    }
}
