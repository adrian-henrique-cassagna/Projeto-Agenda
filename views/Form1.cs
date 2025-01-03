using MySql.Data.MySqlClient;
using Projetp___Agenda.Controller;
using Projetp___Agenda.data;
using Projetp___Agenda.VariablesPublicas;
using Projetp___Agenda.views;

namespace Projetp___Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verificar_usuario_senha()
        {
            //verifica se ambos os campos n�o ficaram vazios ou com a quantia de caract�res abaixo de 8 (se o usuario for diferente de nada, o bot�o cadastrar ficara habilitado)
            if (txt_usuario.Text.Length >= 8 && txt_senha.Text.Length >= 8)
            {
                entrar.Enabled = true;
            }

            //verifica se ambos os campos est�o com o numero de caract�res abaixo do permitido ou se est�o vazios (se o usuario e senha for diferente de 8 caract�res o bot�o fica desabilitado)
            else
            {
                entrar.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void cadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 nome = new Form2();
            nome.ShowDialog();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            verificar_usuario_senha();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            verificar_usuario_senha();
        }

        private void sair_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void entrar_MouseClick(object sender, MouseEventArgs e)
        {
            Usuario_Controller controle_usuario = new Usuario_Controller();
            bool resultado = controle_usuario.ValidarLogin(txt_usuario.Text, txt_senha.Text);

            UserSession.Usuario = txt_usuario.Text;
            UserSession.Senha = txt_senha.Text;

            if (resultado == true)
            {
                Conexao.CriaConexao(UserSession.Usuario, UserSession.Senha);
                this.Hide();
                Form3 nome = new Form3();
                nome.ShowDialog();
            }
        }

        private void entrar_Click(object sender, EventArgs e)
        {

        }
    }
}
