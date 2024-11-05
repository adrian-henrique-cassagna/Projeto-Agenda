using MySql.Data.MySqlClient;
using Projetp___Agenda.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetp___Agenda.Categoria
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria, string nome, string telefone)
        {

            try
            {
                MySqlConnection conexao = Conexao.Cria_conexao();

                string sql = "INSERT INTO tb_categoria (categoria, nome, telefone) VALUES (@categori, @name, @phone);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@categori", categoria);
                comando.Parameters.AddWithValue("@name", nome);
                comando.Parameters.AddWithValue("@phone", telefone);

                int quantidade_linhas = comando.ExecuteNonQuery();

                conexao.Close();

                if (quantidade_linhas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro inesperado ao cadastrar a categoria");
                MessageBox.Show("Erro:"+erro.Message);
                return false;
            }

            
        }
    }
}
