using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetp___Agenda.data
{
    static internal class Conexao
    {
        static public MySqlConnection Cria_conexao()
        {
            //informação para a conexão com o banco de daos SQL
            string stringConexão = "Server=localhost ;Database=db_agenda; User ID=root; Password=root";

            //conectando com o banco de dados SQL
            MySqlConnection conexão = new MySqlConnection(stringConexão);

            return conexão
        }
    }
}
