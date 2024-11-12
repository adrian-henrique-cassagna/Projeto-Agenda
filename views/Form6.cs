using Projetp___Agenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetp___Agenda.views
{
    public partial class Form6 : Form
    {

        private void CarregaTabela()
        {
            Usuario_Controller carrega_usuario = new Usuario_Controller();
            DataTable dt = carrega_usuario.GetCatUser();
            dataGridView1.DataSource = dt;
        }

        private void ExcluirUsuario()
        {
            Usuario_Controller controller = new Usuario_Controller();
            bool excluirusuario = controller.ExcluirUsuario(textBox1.Text);
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CarregaTabela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nome = new Form3();
            nome.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirUsuario();
        }
    }
}
