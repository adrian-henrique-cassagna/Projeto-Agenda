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
            bool resultado = controller.AddCategoria(textBox1.Text, textBox2.Text, textBox3.Text);

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

            if (textBox2.Text.Length <= 3)
            {
                button1.Enabled = false;
            }
            if (textBox2.Text.Length > 3)
            {
                button1.Enabled = true;
            }

            if (textBox3.Text.Length < 14)
            {
                button1.Enabled = false;
            }
            if (textBox3.Text.Length == 14)
            {
                button1.Enabled = true;
            }
            if (textBox3.Text.Length > 14)
            {
                button1.Enabled = false;
            }

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
