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
    public partial class frmCrudClientes : Form
    {
        // TipoCrud ao abrir o formulário
        public int tipoCrud = Crud.Instance.TipoCrud;
        private Clientes clientes;
        public frmCrudClientes()
        {
            InitializeComponent();
            Exit.ConfigurarBotaoFechar(btnSair);
        }

        private void frmCrudClientes_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Obrigatório preencher o ID do cliente!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            } else if (tipoCrud == 1)
            {
                // Cadastrar
                lblTitle.Text = "Novo cadastro";
                this.clientes = new Clientes();
                this.clientes.Id_cliente = txtId.Text;
                this.clientes.Nome_cliente = txtNome.Text;
                this.clientes.Data_entrada_cliente = txtDataEntrada.Text;
                this.clientes.Necessidade_cliente = cbxNecessidade.Text;
                this.clientes.Ism_responsavel_cliente = cbxIsm.Text;
                this.clientes.Status_implantacao_cliente = cbxStatus.Text;
                this.clientes.Tipo_backup_cliente = cbxBackup.Text;
                this.clientes.Horas_utilizadas_cliente = txtHoras.Text;
                this.clientes.Data_fechamento_cliente = txtDataFechamento.Text;
                this.clientes.Observacao_cliente = txtObservacao.Text;
                this.clientes.CadastrarClientes();
                MessageBox.Show("Cliente cadastrado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 3)
            {
                // Alterar
                lblTitle.Text = "Alteração de cadastro";
                this.clientes = new Clientes();
                this.clientes.Id_cliente = txtId.Text;
                this.clientes.Nome_cliente = txtNome.Text;
                this.clientes.Data_entrada_cliente = txtDataEntrada.Text;
                this.clientes.Necessidade_cliente = cbxNecessidade.Text;
                this.clientes.Ism_responsavel_cliente = cbxIsm.Text;
                this.clientes.Status_implantacao_cliente = cbxStatus.Text;
                this.clientes.Tipo_backup_cliente = cbxBackup.Text;
                this.clientes.Horas_utilizadas_cliente = txtHoras.Text;
                this.clientes.Data_fechamento_cliente = txtDataFechamento.Text;
                this.clientes.Observacao_cliente = txtObservacao.Text;
                this.clientes.AlterarClientes();
                MessageBox.Show("Cliente alterado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 4)
            {
                // Excluir
                lblTitle.Text = "Exclusão de cadastro";
                this.clientes = new Clientes();
                this.clientes.Id_cliente = txtId.Text;
                this.clientes.Nome_cliente = txtNome.Text;
                this.clientes.Data_entrada_cliente = txtDataEntrada.Text;
                this.clientes.Necessidade_cliente = cbxNecessidade.Text;
                this.clientes.Ism_responsavel_cliente = cbxIsm.Text;
                this.clientes.Status_implantacao_cliente = cbxStatus.Text;
                this.clientes.Tipo_backup_cliente = cbxBackup.Text;
                this.clientes.Horas_utilizadas_cliente = txtHoras.Text;
                this.clientes.Data_fechamento_cliente = txtDataFechamento.Text;
                this.clientes.Observacao_cliente = txtObservacao.Text;
                this.clientes.ExcluirClientes();
                MessageBox.Show("Cliente excluído com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Voltar para frmClientes
            this.pnlFormLoader.Controls.Clear();
            frmClientes FrmClientes_Vrb = new frmClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmClientes_Vrb);
            FrmClientes_Vrb.Show();
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Voltar para frmClientes
            this.pnlFormLoader.Controls.Clear();
            frmClientes FrmClientes_Vrb = new frmClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmClientes_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmClientes_Vrb);
            FrmClientes_Vrb.Show();
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkCheckedCh(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                chk.Image = Properties.Resources._checked;
            }
            else
            {
                chk.Image = Properties.Resources._unchecked;
            }
        }
    }
}
