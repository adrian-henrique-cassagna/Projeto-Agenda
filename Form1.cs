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
            if (txt_usuario.Text.Length < 8 && txt_senha.Text.Length < 8)
            {
                entrar.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            Form2 nome = new Form2();
            nome.ShowDialog();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            verificar_usuario_senha();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            verificar_usuario_senha();
        }

        private void usuario(object sender, EventArgs e)
        {

        }
    }
}
