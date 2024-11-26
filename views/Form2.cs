using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using Projetp___Agenda.Controller;
using Projetp___Agenda.data;
using Projetp___Agenda.VariablesPublicas;
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
            string nome = txt_nome.Text;
            string usuario = txt_usuario.Text;
            string telefone = txt_telefone.Text;
            string senha = txt_senha.Text;

            Usuario_Controller controleUsuario = new Usuario_Controller();
            bool resultado = controleUsuario.AddUser(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("o cadastro foi um sucesso");
            }
            else
            {
                MessageBox.Show("o cadastro não foi um sucesso");
            }
        }

        private void cancelar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void cadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
