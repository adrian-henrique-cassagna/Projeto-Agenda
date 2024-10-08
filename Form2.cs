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
            if (txt_nome.Text.Length >= 8 && txt_senha.Text.Length >= 8 && txt_confirmar_senha.Text.Length >= 8 && txt_telefone.Text.Length == 11)
            {
                cadastro.Enabled = true;
            }
            if (txt_nome.Text.Length < 8 && txt_senha.Text.Length < 8 && txt_confirmar_senha.Text.Length < 8 && txt_telefone.Text.Length < 11) 
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
    }
}
