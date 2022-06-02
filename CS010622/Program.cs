using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CS010622
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;database=phpmysql;uid=root;password=;port=3308");
            try
            {
                conexao.Open();
            }
            catch(MySqlException e)
            {
                Console.WriteLine("e.Message");
                Console.WriteLine("Ocorreu um Erro");
                Environment.Exit(0);
            }
            string sql = "select * from login";
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                Console.WriteLine("Lista de Login");
            }else
            {
                Console.WriteLine("Sem Dados para exibição");
            }
            Console.ReadLine();
        }
    }
}
