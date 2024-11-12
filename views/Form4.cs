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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            bool resultado = controller.AddCategoria(textBox1.Text);

            if (resultado == true)
            {
                MessageBox.Show("Aategoria Adicionada Com Sucesso");
            }
            else
            {
                MessageBox.Show("a categoria nõa foi adicionada");
            }

            if (textBox1.Text.Length <= 3)
            {
                button1.Enabled = false;
            }
            if (textBox1.Text.Length > 3)
            {
                button1.Enabled = true;
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nome = new Form3();
            nome.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
