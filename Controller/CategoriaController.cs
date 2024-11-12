using MySql.Data.MySqlClient;
using Projetp___Agenda.data;
using Projetp___Agenda.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetp___Agenda.Categoria
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {

            try
            {
                MySqlConnection conexao = Conexao.Cria_conexao();

                string sql = "INSERT INTO tb_categoria (categoria) VALUES (@categori);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@categori", categoria);

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

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = Conexao.Cria_conexao();

                string sql = "SELECT * FROM tb_categoria";

                conexao.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                return dt;
            }
            catch(Exception erro)
            {
                MessageBox.Show("não foi possivel trazer a tabela");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ExcluiCategoria(string excluir_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = Conexao.Cria_conexao();

                string sql = $"DELETE FROM tb_categoria WHERE categoria='{excluir_categoria}';";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                int linhas_afetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if(linhas_afetadas == 0)
                {
                    MessageBox.Show("nenhuma linhas afetada, nenhuma categoria excluida");
                    return false;
                }
                if (linhas_afetadas >= 1)
                {
                    MessageBox.Show($"quantidade de linhas afetadas:{linhas_afetadas}, {linhas_afetadas} categorias foram excluidas");
                    return true;
                }
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("algo deu errado, tente novamente");
                MessageBox.Show($"Erro Ocorrido: {erro}");
                return false;
            }
        }
    }
}
