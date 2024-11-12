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
        public bool categoria_desejada()
        {
            string categoria_selecionada = textBox1.Text;
            return true;
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            DataTable dt = controller.GetCategorias();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            bool resultado = controller.ExcluiCategoria(textBox1.Text);
        }
    }
}
