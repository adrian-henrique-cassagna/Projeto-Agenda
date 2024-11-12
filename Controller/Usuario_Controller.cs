﻿using MySql.Data.MySqlClient;
using Projetp___Agenda.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                string sql = "INSERT INTO tb_cliente (nome, usuario, telefone, senha) VALUES (@name, @user, @phone, @password);";

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
                string sql = "SELECT nome, usuario, telefone FROM tb_cliente;";

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

                string sql = $"DELETE FROM tb_cliente WHERE usuario='{excluir_usuario}';";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

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
    }
}
