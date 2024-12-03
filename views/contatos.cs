using Projetp___Agenda.Categoria;
using Projetp___Agenda.Controller;
using Projetp___Agenda.data;
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
    public partial class contatos : Form
    {

        public contatos()
        {
            InitializeComponent();
        }

        private void contatos_Load(object sender, EventArgs e)
        {
            CategoriaController controller = new CategoriaController();
            var dt = controller.GetCategorias();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
