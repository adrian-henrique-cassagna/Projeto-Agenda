using Projetp___Agenda.Categoria;
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
    public partial class Form5 : Form
    {
        private void AtualizadorTabela()
        {
            CategoriaController controller = new CategoriaController();
            DataTable dt = controller.GetCategorias();
            dataGridView1.DataSource = dt;
        }

        private void ExcluirCategoria()
        {
            CategoriaController controller = new CategoriaController();
            bool resultado = controller.ExcluiCategoria(textBox1.Text);
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            AtualizadorTabela();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirCategoria();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nome = new Form3();
            nome.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizadorTabela();
        }
    }
}
