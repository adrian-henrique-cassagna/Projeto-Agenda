using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Projetp___Agenda.data;
using Projetp___Agenda.VariablesPublicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Projetp___Agenda.Controller
{
    internal class Usuario_Controller
    {
        public bool AddUser(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                //criando a conexão usando usando uma conexão que esta localizada na pasta data
                MySqlConnection conexao = Conexao.Cria_conexao();

                //adicionando os itens no banco de dados usando insert into e camuflando eles usando uma mascara:(@name, @user, @phone, @password)
                string sql = "INSERT INTO tb_cliente (nome, usuario, telefone, senha) VALUES (@name, @user, @phone, @password);" +
                    $"create user '{usuario}'@'localhost' identified by '{senha}';" +
                    $"GRANT ALL PRIVILEGES ON db_agenda.* TO '{usuario}'@'localhost'";

                //abrindo a conexão com o bacno de cados
                conexao.Open();

                //redefinindo o valor dos @ pelo valor original:(nome, usuario, telefone, senha)
                //estas informações iram virar parametros da função
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@name", nome);
                comando.Parameters.AddWithValue("@user", usuario);
                comando.Parameters.AddWithValue("@phone", telefone);
                comando.Parameters.AddWithValue("@password", senha);

                //para executar o camando no banco de dados
                int linhas_afetadas = comando.ExecuteNonQuery();

                //fechando a conexão com o banco de dados
                conexao.Close();

                if (linhas_afetadas > 0)
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
                MessageBox.Show("erro de conexão este usuario ja existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(erro.Message);
                return false;
            }
        }

        public bool ValidarLogin(string usuario, string senha)
        {
            try
            {
                MySqlConnection conexao = Conexao.Cria_conexao();

                string sql = @"select * from tb_cliente where usuario = @user and binary senha = @password;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@user", usuario);
                comando.Parameters.AddWithValue("@password", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO!, algo deu errado");
                MessageBox.Show("Erro Ocorrido:" + erro.Message);
                return false;
            }

        }

        public DataTable GetCatUser()
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = Conexao.Cria_conexao();
                string sql = $"SELECT nome, usuario FROM tb_cliente;";

                conexao.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool ExcluirUsuario(string excluir_usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = Conexao.Cria_conexao();

                string sql = $"DELETE FROM tb_cliente WHERE usuario = @excluir_usuario;";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@excluir_usuario", excluir_usuario);

                int linhas_afetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhas_afetadas == 0)
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

        public bool MudarSenha(string mudar_senha, string usuario)
        {
            try
            {
                MySqlConnection conexao = Conexao.Cria_conexao();

                string sql = $"UPDATE tb_cliente SET senha = '{mudar_senha}' WHERE usuario='{usuario}';";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);



                int linhas_afetadas = comando.ExecuteNonQuery();

                conexao.Close();

                if (linhas_afetadas == 0)
                {
                    MessageBox.Show("nenhuma linha foi afetada, nenhuma senha foi alterada");
                    return false;
                }

                if (linhas_afetadas  >= 1)
                {
                    MessageBox.Show($"quantidade de linhas afetadas:{linhas_afetadas},a senha de {linhas_afetadas} foi alterada");
                    return true;
                }

                return true;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro Ocorrido, tente novamente mais tarde");
                MessageBox.Show($"Error: {erro}");
                return false;
            }
        }

        public bool VerificarNome(string usuario, string senha)
        {
            MySqlConnection conexao = Conexao.Cria_conexao();

            string sql = "use db_agenda;" + $"select usuario, senha, nome, telefone from tb_cliente WHERE usuario = '{usuario}' and senha = '{senha}';";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand (sql, conexao);

            MySqlDataReader resultado = comando.ExecuteReader();

            if(resultado.Read())
            {
                UserSession.Usuario = resultado.GetString(0);
                UserSession.Senha = resultado.GetString(1);
                UserSession.Nome = resultado.GetString(2);
                conexao.Close();
                return true;
            }
            else
            {
                conexao.Close();
                return false;
            }
            
        }
    }
}
