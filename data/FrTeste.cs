using MySql.Data.MySqlClient;
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

namespace Projetp___Agenda.data
{
    public partial class FrTeste : Form
    {
        public FrTeste()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSession.Nome = textBox1.Text;
            UserSession.Senha = textBox2.Text;

            MessageBox.Show($"seja bem vindo{UserSession.Nome}");
        }
        private void FrTeste_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
