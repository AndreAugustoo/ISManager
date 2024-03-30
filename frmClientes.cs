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
    public partial class frmClientes : Form
    {
        private Clientes clientes;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.clientes = new Clientes();
            MySqlDataReader temp = this.clientes.ListarClientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtGridClientes.DataSource = dt;


            MySqlDataReader temp2 = this.clientes.ListarNumeroRegistro();
            DataTable dt2 = new DataTable();
            dt2.Load(temp2);
            lblNumeroRegistro.Text = "Numero de registros encontrado: " + temp2.ToString();

        }

        private void dtGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void dtGridClientes_DoubleClick(object sender, EventHandler e)
        {
        }

        private void dtGridClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dtGridClientes.Rows[e.RowIndex];
            string id = linha.Cells["ID"].Value.ToString();
            string nome = linha.Cells["Nome"].Value.ToString();
            string dataEntrada = linha.Cells["Data entrada"].Value.ToString();
            string necessidade = linha.Cells["Necessidade"].Value.ToString();
            string ism = linha.Cells["ISM"].Value.ToString();
            string status = linha.Cells["Status"].Value.ToString();

            MessageBox.Show(id + nome + dataEntrada + necessidade + ism + status);
        }
    }
}