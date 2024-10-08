using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Projetp___Agenda.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetp___Agenda
{
    public partial class Form2 : Form
    {



        public Form2()
        {
            InitializeComponent();
        }

        private void verificação()
        {
            if (txt_nome.Text.Length >= 8)
            {
                cadastro.Enabled = true;
            }

            if (txt_senha.Text.Length >= 8)
            {
                cadastro.Enabled = true;
            }

            if (txt_confirmar_senha.Text.Length >= 8)
            {
                cadastro.Enabled = true;
            }

            if (txt_telefone.Text.Length >= 10)
            {
                cadastro.Enabled = true;
            }

            /////////////////////////////////////////////////////////////

            if (txt_nome.Text.Length < 8)
            {
                cadastro.Enabled = false;
            }

            if (txt_senha.Text.Length < 8)
            {
                cadastro.Enabled = false;
            }

            if (txt_confirmar_senha.Text.Length < 8)
            {
                cadastro.Enabled = false;
            }

            if (txt_telefone.Text.Length < 10)
            {
                cadastro.Enabled = false;
            }

            if (txt_confirmar_senha.Text != txt_senha.Text)
            {
                cadastro.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            verificação();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            verificação();
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            verificação();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            verificação();
        }

        private void txt_confirmar_senha_TextChanged(object sender, EventArgs e)
        {
            verificação();
        }

        private void cadastro_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlConnection conexao = Conexao.Cria_conexao();

            //abrindo a conexão
            conexao.Open();

            //criando um comando em SQL para inserir o usuario
            string sql = $"INSERT INTO tb_usuarios (nome, usuario, telefone, senha) VALUES( @nome,@usuario,@telefone,@senha)";

            //criando um comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome",txt_nome.Text);
            comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
            comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
            comando.Parameters.AddWithValue("@senha", txt_senha.Text);

            MySqlConnection conexãov = new Conexao

            //executando a instrução do SQl no banco de dados
            comando.ExecuteNonQuery();

            //fexar a conexão com o banco de dados
            conexao.Close();

            bool erro = true;

            if (txt_nome.Text.Length >= 8)
            {
                erro = false;
                MessageBox.Show("usuario cadastrado");
                this.Close();
            }

            if (txt_usuario.Text.Length >= 8)
            {
                erro = false;
            }

            if (txt_telefone.Text.Length >= 10)
            {
                erro = false;
            }

            if (txt_senha.Text.Length >= 8)
            {
                erro = false;
            }

            else
            {
                erro = true;
            }
        }

        private void cancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
