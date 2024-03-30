using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISManager
{
    internal class Database
    {
        private String host = "localhost";
        private String nomeBanco = "ismanager";
        private String usuario = "root";
        private String senha = "061127";
        private MySqlConnection con;
        private MySqlCommand cmd;
        public Database() 
        {
            try
            {
                Conectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão com MySQL: " + ex.Message);
            }
        }
        public void Conectar()
        {
            String stringCon = "Server=" + this.host + ";Database=" + this.nomeBanco + ";Uid=" + this.usuario + ";Pwd=" + this.senha;
            this.con = new MySqlConnection(stringCon);
            this.cmd = this.con.CreateCommand();
            this.con.Open();
        }
        public void NonQuery(String sql)
        {
            this.cmd.CommandText = sql;
            this.cmd.ExecuteNonQuery();
        }
       public MySqlDataReader Query(String sql) 
        {
            this.cmd.CommandText = sql;
            return this.cmd.ExecuteReader();
        }
    }
}
