using MySql.Data.MySqlClient;
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
            try
            {
                MySqlConnection conexao = Conexao.CriaConexao(textBox1.Text, textBox2.Text);
                conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("algo deu errado" + erro);
            }
        }
        private void FrTeste_Load(object sender, EventArgs e)
        {

        }
    }
}
