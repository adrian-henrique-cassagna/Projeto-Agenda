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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void aRQUIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nome = new Form4();
            nome.ShowDialog();
        }
    }
}
