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
            //verifica se ambos os campos não ficaram vazios ou com a quantia de caractéres abaixo de 8 (se o usuario for diferente de nada, o botão cadastrar ficara habilitado)
            if (txt_usuario.Text.Length >= 8 && txt_senha.Text.Length >= 8)
            {
                entrar.Enabled = true;
            }

            //verifica se ambos os campos estão com o numero de caractéres abaixo do permitido ou se estão vazios (se o usuario e senha for diferente de 8 caractéres o botão fica desabilitado)
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
