﻿namespace Projetp___Agenda.views
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 223);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 33);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 205);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Categoria";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(346, 106);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 6;
            button1.Text = "CADASTRAR";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(346, 212);
            button2.Name = "button2";
            button2.Size = new Size(109, 42);
            button2.TabIndex = 7;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseClick += button2_MouseClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 95);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 33);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 160);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 33);
            textBox3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Telefone";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lone_tree;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(499, 316);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
    }
}