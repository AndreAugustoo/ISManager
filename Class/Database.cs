using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISManager.Class
{
    internal class Database
    {

        private string host = "localhost";
        private string port = "3306";
        private string nomeBanco = "ismanager";
        private string usuario = "root";
        private string senha = "061127";
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
            string stringCon = "Server=" + host + ";Database=" + nomeBanco + ";Uid=" + usuario + ";Pwd=" + senha;
            con = new MySqlConnection(stringCon);
            cmd = con.CreateCommand();
            con.Open();
        }
        public void NonQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public MySqlDataReader Query(string sql)
        {
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }
    }
}
