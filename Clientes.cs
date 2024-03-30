using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ISManager
{
    class Clientes
    {
        private String id_cliente;
        private String nome_cliente;
        private String data_entrada_cliente;
        private String necessidade_cliente;
        private String ism_responsavel_cliente;
        private String tipo_backup_cliente;
        private String status_implantacao_cliente;
        private String horas_utilizadas_cliente;
        private String data_fechamento_cliente;
        private String observacao_cliente;
        private Database database;
        public Clientes()
        {
            this.database = new Database();

        }

        public void CadastrarClientes()
        {
            this.database.NonQuery("INSERT INTO cliente " +
                "(id_cliente" +
                ", nome_cliente" +
                ", data_entrada_cliente" +
                ", necessidade_cliente" +
                ", ism_responsavel_cliente" +
                ", tipo_backup_cliente" +
                ", status_implantacao_cliente" +
                ", horas_utilizadas_cliente" +
                ", observacao_cliente) " +
                "VALUES ('" + this.Id_cliente + "'" +
                ", '" + this.Nome_cliente + "'" +
                ", '" + this.Data_entrada_cliente + "'" +
                ", '" + this.Necessidade_cliente + "'" +
                ", '" + this.Ism_responsavel_cliente + "'" +
                ", '" + this.Tipo_backup_cliente + "'" +
                ", '" + this.Status_implantacao_cliente + "'" +
                ", '" + this.Horas_utilizadas_cliente + "'" +
                ", '" + this.Observacao_cliente + "');");
        }

        public MySqlDataReader ListarClientes()
        {
            return this.database.Query(
                "SELECT id_cliente AS 'ID'" +
                ", nome_cliente AS 'Nome'" +
                ", data_entrada_cliente AS 'Data entrada'" +
                ", necessidade_cliente AS 'Necessidade'" +
                ", ism_responsavel_cliente AS 'ISM'" +
                ", status_implantacao_cliente AS 'Status'" +
                "FROM cliente ORDER BY nome_cliente ASC");
        }

        public MySqlDataReader ListarClientes(String campo, String filtro)
        {
            if (filtro == "")
            {
                return ListarClientes();
            }
            
            return this.database.Query(
                "SELECT id_cliente AS 'ID'" +
                ", nome_cliente AS 'Nome'" +
                ", data_entrada_cliente AS 'Data entrada'" +
                ", necessidade_cliente AS 'Necessidade'" +
                ", ism_responsavel_cliente AS 'ISM'" +
                ", status_implantacao_cliente AS 'Status'" +
                "FROM cliente WHERE " + campo + " = " + filtro + " ORDER BY nome_cliente ASC");
        }

        public MySqlDataReader ListarNumeroRegistro()
        {
            return this.database.Query(
                "SELECT COUNT(*) FROM cliente");
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
    }
}
