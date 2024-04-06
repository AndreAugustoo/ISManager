using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISManager.Class
{
    class Migracoes
    {
        private string id_cliente;
        private string nome_cliente;
        private string versao_atual;
        private string status;
        private string data_atualizacao;
        private string observacao_cliente;

        private Database database;
        public Migracoes()
        {
            database = new Database();

        }
        public void ExcluirMigracoes()
        {
            this.database.NonQuery("DELETE FROM migracao WHERE id_cliente = '" + this.id_cliente + "';");
        }
        public void AlterarMigracoes()
        {
            database.NonQuery("UPDATE migracao SET" +
                " id_cliente = '" + this.id_cliente + "'" +
                ", nome_cliente = '" + this.nome_cliente + "'" +
                ", versao_atual = '" + this.versao_atual + "'" +
                ", status = '" + this.status + "'" +
                ", data_atualizacao = '" + this.data_atualizacao + "'" +
                ", observacao_cliente = '" + this.observacao_cliente + "'" +
                " WHERE id_cliente = '" + this.id_cliente + "';");
        }

        public void CadastrarMigracoes()
        {
            database.NonQuery("INSERT INTO migracao " +
                "(id_cliente" +
                ", nome_cliente" +
                ", versao_atual" +
                ", status" +
                ", data_atualizacao" +
                ", observacao_cliente) " +
                "VALUES ('" + this.id_cliente + "'" +
                ", '" + this.nome_cliente + "'" +
                ", '" + this.versao_atual + "'" +
                ", '" + this.status + "'" +
                ", '" + this.data_atualizacao + "'" +
                ", '" + this.observacao_cliente + "');");
        }

        public MySqlDataReader ListarMigracoes()
        {
            return database.Query(
                "SELECT id_cliente AS 'ID'" +
                ", nome_cliente AS 'Nome'" +
                ", versao_atual AS 'Versão atual'" +
                ", status AS 'Status'" +
                ", data_atualizacao AS 'Data atualização'" +
                ", observacao_cliente AS 'Observação'" +
                "FROM migracao ORDER BY nome_cliente ASC LIMIT 100");
        }

        public MySqlDataReader ListarMigracoes(string campo, string filtro, string filtro2 = "")
        {
            if (filtro == "")
            {
                return ListarMigracoes();
            }
            else if (campo == "data_atualizacao")
            {
                return database.Query(
                    "SELECT id_cliente AS 'ID'" +
                    ", nome_cliente AS 'Nome'" +
                    ", versao_atual AS 'Versão atual'" +
                    ", status AS 'Status'" +
                    ", data_atualizacao AS 'Data atualização'" +
                    ", observacao_cliente AS 'Observação'" +
                    "FROM migracao WHERE " + campo + " BETWEEN '" + filtro + "' AND '" + filtro2 + "' ORDER BY nome_cliente ASC LIMIT 100");
            }
            else
            {

                return database.Query(
                "SELECT id_cliente AS 'ID'" +
                ", nome_cliente AS 'Nome'" +
                ", versao_atual AS 'Versão atual'" +
                ", status AS 'Status'" +
                ", data_atualizacao AS 'Data atualização'" +
                ", observacao_cliente AS 'Observação'" +
                "FROM migracao WHERE " + campo + " LIKE '%" + filtro + "%' ORDER BY nome_cliente ASC LIMIT 100");
            }
        }

        public MySqlDataReader ListarNumeroRegistro()
        {
            return database.Query(
                "SELECT COUNT(*) FROM migracao");
        }

        public MySqlDataReader ListarTotalAberto()
        {
            return database.Query(
                "SELECT COUNT(*) FROM migracao WHERE status IN ('Em andamento', 'Atualizar')");
        }

        public MySqlDataReader ListarTotalFechado()
        {
            return database.Query(
                "SELECT COUNT(*) FROM migracao WHERE status IN ('Atualizado')");
        }

        public MySqlDataReader ListarTotalCancelado()
        {
            return database.Query(
                "SELECT COUNT(*) FROM migracao WHERE status IN ('Não atualizar')");
        }

        public string? Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string? Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string? Versao_atual { get => versao_atual; set => versao_atual = value; }
        public string? Status { get => status; set => status = value; }
        public string? Data_atualizacao { get => data_atualizacao; set => data_atualizacao = value; }
        public string? Observacao_cliente { get => observacao_cliente; set => observacao_cliente = value; }

    }
}
