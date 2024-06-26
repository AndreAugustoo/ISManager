﻿using ISManager.Class;
using ISManager.Properties;
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
        }

        private void frmCrudClientes_Load(object sender, EventArgs e)
        {
            //aplica tema
            if (Crud.Instance.darkTheme) //Modo noturno
            {
                ThemeManager.ApplyDarkTheme(this);
                txtDataEntrada.TextColor = Color.White;
                txtDataEntrada.BorderColor = Color.White;
                txtDataEntrada.SkinColor = Color.FromArgb(57, 57, 57);
                txtDataFechamento.TextColor = Color.White;
                txtDataFechamento.BorderColor = Color.White;
                txtDataFechamento.SkinColor = Color.FromArgb(57, 57, 57);
                chkDocumentacao.Image = Resources.uncheckedLight;
                chkZendesk.Image = Resources.uncheckedLight;
                chkPesquisa.Image = Resources.uncheckedLight;
                chkOpcao1.Image = Resources.uncheckedLight;
                chkOpcao2.Image = Resources.uncheckedLight;
                chkOpcao3.Image = Resources.uncheckedLight;
            }
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
                this.clientes = new Clientes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Data_entrada_cliente = txtDataEntrada.Text,
                    Necessidade_cliente = cbxNecessidade.Text,
                    Ism_responsavel_cliente = cbxIsm.Text,
                    Status_implantacao_cliente = cbxStatus.Text,
                    Tipo_backup_cliente = cbxBackup.Text,
                    Horas_utilizadas_cliente = txtHoras.Text,
                    Data_fechamento_cliente = txtDataFechamento.Text,
                    Observacao_cliente = txtObservacao.Text,
                    Documentacao_cliente = chkDocumentacao.Checked ? 1 : 0,
                    Zendesk_cliente = chkZendesk.Checked ? 1 : 0,
                    Pesquisa_cliente = chkPesquisa.Checked ? 1 : 0
                };

                this.clientes.CadastrarClientes();
                MessageBox.Show("Cliente cadastrado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 3)
            {
                // Alterar
                this.clientes = new Clientes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Data_entrada_cliente = txtDataEntrada.Text,
                    Necessidade_cliente = cbxNecessidade.Text,
                    Ism_responsavel_cliente = cbxIsm.Text,
                    Status_implantacao_cliente = cbxStatus.Text,
                    Tipo_backup_cliente = cbxBackup.Text,
                    Horas_utilizadas_cliente = txtHoras.Text,
                    Data_fechamento_cliente = txtDataFechamento.Text,
                    Observacao_cliente = txtObservacao.Text,
                    Documentacao_cliente = chkDocumentacao.Checked ? 1 : 0,
                    Zendesk_cliente = chkZendesk.Checked ? 1 : 0,
                    Pesquisa_cliente = chkPesquisa.Checked ? 1 : 0
                };

                this.clientes.AlterarClientes();
                MessageBox.Show("Cliente alterado com sucesso!", "ISManager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tipoCrud == 4)
            {
                // Excluir
                this.clientes = new Clientes();
                this.clientes = new Clientes()
                {
                    Id_cliente = txtId.Text,
                    Nome_cliente = txtNome.Text,
                    Data_entrada_cliente = txtDataEntrada.Text,
                    Necessidade_cliente = cbxNecessidade.Text,
                    Ism_responsavel_cliente = cbxIsm.Text,
                    Status_implantacao_cliente = cbxStatus.Text,
                    Tipo_backup_cliente = cbxBackup.Text,
                    Horas_utilizadas_cliente = txtHoras.Text,
                    Data_fechamento_cliente = txtDataFechamento.Text,
                    Observacao_cliente = txtObservacao.Text,
                    Documentacao_cliente = chkDocumentacao.Checked ? 1 : 0,
                    Zendesk_cliente = chkZendesk.Checked ? 1 : 0,
                    Pesquisa_cliente = chkPesquisa.Checked ? 1 : 0
                };

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
        private void chkCheckedCh(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                if(Crud.Instance.darkTheme == true)
                {
                    chk.Image = Resources.checkedLight;
                }
                else
                {
                    chk.Image = Resources._checked;
                }
            }
            else
            {
                if (Crud.Instance.darkTheme == true)
                {
                    chk.Image = Resources.uncheckedLight;
                }
                else
                {
                    chk.Image = Resources._unchecked;
                }
            }
        }
    }
}
