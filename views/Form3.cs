﻿using Projetp___Agenda.Controller;
using Projetp___Agenda.data;
using Projetp___Agenda.VariablesPublicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            label2.Text = $"Seja Bem - Vindo {UserSession.Usuario}";
        }

        private void cadastroCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 nome = new Form4();
            nome.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            this.Hide();
            Form6 nome = new Form6();
            nome.ShowDialog();
        }


        private void contatosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            contatos nome = new contatos();
            nome.ShowDialog();
        }
    }
}
