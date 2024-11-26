using Projetp___Agenda.Controller;
using Projetp___Agenda.VariablesPublicas;
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
            //MessageBox.Show($"Bem-Vindo {UserSession.Nome}");
            label2.Text = $"Seja Bem - Vindo {UserSession.Nome}";
        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nome = new Form4();
            nome.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nome = new Form1();
            nome.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nome = new Form5();
            nome.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 nome = new Form6();
            nome.ShowDialog();
        }
    }
}
