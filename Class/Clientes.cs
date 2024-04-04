using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ISManager.Class
{
    class Clientes
    {
        private string id_cliente;
        private string nome_cliente;
        private string data_entrada_cliente;
        private string necessidade_cliente;
        private string ism_responsavel_cliente;
        private string tipo_backup_cliente;
        private string status_implantacao_cliente;
        private string horas_utilizadas_cliente;
        private string data_fechamento_cliente;
        private string observacao_cliente;
        private int documentacao_cliente;
        private int zendesk_cliente;
        private int pesquisa_cliente;

        private Database database;
        public Clientes()
        {
            database = new Database();

        }
        public void ExcluirClientes()
        {
            this.database.NonQuery("DELETE FROM cliente WHERE id_cliente = '" + this.id_cliente + "';");
        }
        public void AlterarClientes()
        {
            database.NonQuery("UPDATE cliente SET" +
                " id_cliente = '" + this.id_cliente + "'" +
                ", nome_cliente = '" + this.nome_cliente + "'" +
                ", data_entrada_cliente = '" + this.data_entrada_cliente + "'" +
                ", necessidade_cliente = '" + this.necessidade_cliente + "'" +
                ", ism_responsavel_cliente = '" + this.ism_responsavel_cliente + "'" +
                ", tipo_backup_cliente = '" + this.tipo_backup_cliente + "'" +
                ", status_implantacao_cliente = '" + this.status_implantacao_cliente + "'" +
                ", horas_utilizadas_cliente = '" + this.horas_utilizadas_cliente + "'" +
                ", data_fechamento_cliente = '" + this.data_fechamento_cliente + "'" +
                ", observacao_cliente = '" + this.observacao_cliente + "'" +
                ", documentacao_cliente = '" + this.documentacao_cliente + "'" +
                ", zendesk_cliente = '" + this.zendesk_cliente + "'" +
                ", pesquisa_cliente = '" + this.pesquisa_cliente + "'" +
                " WHERE id_cliente = '" + this.id_cliente + "';");
        }

        public void CadastrarClientes()
        {
            database.NonQuery("INSERT INTO cliente " +
                "(id_cliente" +
                ", nome_cliente" +
                ", data_entrada_cliente" +
                ", necessidade_cliente" +
                ", ism_responsavel_cliente" +
                ", tipo_backup_cliente" +
                ", status_implantacao_cliente" +
                ", horas_utilizadas_cliente" +
                ", data_fechamento_cliente" +
                ", observacao_cliente " +
                ", documentacao_cliente" +
                ", zendesk_cliente" +
                ", pesquisa_cliente) " +
                "VALUES ('" + this.id_cliente + "'" +
                ", '" + this.nome_cliente + "'" +
                ", '" + this.data_entrada_cliente + "'" +
                ", '" + this.necessidade_cliente + "'" +
                ", '" + this.ism_responsavel_cliente + "'" +
                ", '" + this.tipo_backup_cliente + "'" +
                ", '" + this.status_implantacao_cliente + "'" +
                ", '" + this.horas_utilizadas_cliente + "'" +
                ", '" + this.data_fechamento_cliente + "'" +
                ", '" + this.observacao_cliente + "'" +
                ", '" + this.documentacao_cliente + "'" +
                ", '" + this.zendesk_cliente + "'" +
                ", '" + this.pesquisa_cliente + "');");
        }

        public MySqlDataReader ListarClientes()
        {
            return database.Query(
                "SELECT id_cliente AS 'ID'" +
                ", nome_cliente AS 'Nome'" +
                ", data_entrada_cliente AS 'Data entrada'" +
                ", necessidade_cliente AS 'Necessidade'" +
                ", ism_responsavel_cliente AS 'ISM'" +
                ", status_implantacao_cliente AS 'Status'" +
                ", tipo_backup_cliente AS 'Backup'" +
                ", horas_utilizadas_cliente AS 'Horas'" +
                ", data_fechamento_cliente AS 'Data fechamento'" + 
                ", documentacao_cliente AS 'Documentação'" +
                ", zendesk_cliente AS 'Zendesk'" +
                ", pesquisa_cliente AS 'Pesquisa'" +
                ", observacao_cliente AS 'Observação'" +
                "FROM cliente ORDER BY data_entrada_cliente ASC LIMIT 100");
        }

        public MySqlDataReader ListarClientes(string campo, string filtro, string filtro2 = "")
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            else if ((campo == "data_entrada_cliente") || (campo == "data_fechamento_cliente"))
            {
                return database.Query(
                    "SELECT id_cliente AS 'ID'" +
                    ", nome_cliente AS 'Nome'" +
                    ", data_entrada_cliente AS 'Data entrada'" +
                    ", necessidade_cliente AS 'Necessidade'" +
                    ", ism_responsavel_cliente AS 'ISM'" +
                    ", status_implantacao_cliente AS 'Status'" +
                    ", tipo_backup_cliente AS 'Backup'" +
                    ", horas_utilizadas_cliente AS 'Horas'" +
                    ", data_fechamento_cliente AS 'Data fechamento'" +
                    ", documentacao_cliente AS 'Documentação'" +
                    ", zendesk_cliente AS 'Zendesk'" +
                    ", pesquisa_cliente AS 'Pesquisa'" +
                    ", observacao_cliente AS 'Observação'" +
                    "FROM cliente WHERE " + campo + " BETWEEN '" + filtro + "' AND '"+ filtro2 + "' ORDER BY data_entrada_cliente ASC LIMIT 100");
            }
            else
            {

                    return database.Query(
                    "SELECT id_cliente AS 'ID'" +
                    ", nome_cliente AS 'Nome'" +
                    ", data_entrada_cliente AS 'Data entrada'" +
                    ", necessidade_cliente AS 'Necessidade'" +
                    ", ism_responsavel_cliente AS 'ISM'" +
                    ", status_implantacao_cliente AS 'Status'" +
                    ", tipo_backup_cliente AS 'Backup'" +
                    ", horas_utilizadas_cliente AS 'Horas'" +
                    ", data_fechamento_cliente AS 'Data fechamento'" +
                    ", documentacao_cliente AS 'Documentação'" +
                    ", zendesk_cliente AS 'Zendesk'" +
                    ", pesquisa_cliente AS 'Pesquisa'" +
                    ", observacao_cliente AS 'Observação'" +
                    "FROM cliente WHERE " + campo + " LIKE '%" + filtro + "%' ORDER BY data_entrada_cliente ASC LIMIT 100");
            }
        }

        public MySqlDataReader ListarNumeroRegistro()
        {
            return database.Query(
                "SELECT COUNT(*) FROM cliente");
        }

        public MySqlDataReader ListarTotalAberto()
        {
            return database.Query(
                "SELECT COUNT(*) FROM cliente WHERE status_implantacao_cliente IN ('Em andamento', 'Parada')");
        }

        public MySqlDataReader ListarTotalFechado()
        {
            return database.Query(
                "SELECT COUNT(*) FROM cliente WHERE status_implantacao_cliente IN ('Finalizada')");
        }

        public MySqlDataReader ListarTotalCancelado()
        {
            return database.Query(
                "SELECT COUNT(*) FROM cliente WHERE status_implantacao_cliente IN ('Cancelada')");
        }

        public string? Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string? Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string? Data_entrada_cliente { get => data_entrada_cliente; set => data_entrada_cliente = value; }
        public string? Necessidade_cliente { get => necessidade_cliente; set => necessidade_cliente = value; }
        public string? Ism_responsavel_cliente { get => ism_responsavel_cliente; set => ism_responsavel_cliente = value; }
        public string? Tipo_backup_cliente { get => tipo_backup_cliente; set => tipo_backup_cliente = value; }
        public string? Status_implantacao_cliente { get => status_implantacao_cliente; set => status_implantacao_cliente = value; }
        public string? Horas_utilizadas_cliente { get => horas_utilizadas_cliente; set => horas_utilizadas_cliente = value; }
        public string? Data_fechamento_cliente { get => data_fechamento_cliente; set => data_fechamento_cliente = value; }
        public string? Observacao_cliente { get => observacao_cliente; set => observacao_cliente = value; }
        public int Documentacao_cliente { get => documentacao_cliente; set => documentacao_cliente = value; }
        public int Zendesk_cliente { get => zendesk_cliente; set => zendesk_cliente = value; }
        public int Pesquisa_cliente { get => pesquisa_cliente; set => pesquisa_cliente = value; }

    }
}
