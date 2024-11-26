namespace Projetp___Agenda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            entrar = new Button();
            cadastrar = new Button();
            label2 = new Label();
            label1 = new Label();
            sair = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.InactiveCaption;
            txt_usuario.Location = new Point(141, 107);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(209, 31);
            txt_usuario.TabIndex = 0;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = SystemColors.InactiveCaption;
            txt_senha.Location = new Point(141, 170);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(209, 31);
            txt_senha.TabIndex = 1;
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // entrar
            // 
            entrar.BackColor = SystemColors.ActiveCaption;
            entrar.Enabled = false;
            entrar.Location = new Point(141, 272);
            entrar.Name = "entrar";
            entrar.Size = new Size(83, 43);
            entrar.TabIndex = 2;
            entrar.Text = "ENTRAR";
            entrar.UseVisualStyleBackColor = false;
            entrar.Click += entrar_Click;
            entrar.MouseClick += entrar_MouseClick;
            // 
            // cadastrar
            // 
            cadastrar.BackColor = SystemColors.ActiveCaption;
            cadastrar.Location = new Point(267, 272);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(83, 43);
            cadastrar.TabIndex = 3;
            cadastrar.Text = "CADASTRAR";
            cadastrar.UseVisualStyleBackColor = false;
            cadastrar.MouseClick += cadastrar_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 152);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 89);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "usuario";
            // 
            // sair
            // 
            sair.BackColor = SystemColors.ActiveCaption;
            sair.Location = new Point(12, 12);
            sair.Name = "sair";
            sair.Size = new Size(83, 43);
            sair.TabIndex = 7;
            sair.Text = "SAIR";
            sair.UseVisualStyleBackColor = false;
            sair.MouseClick += sair_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.WALLPAPER;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 369);
            Controls.Add(sair);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cadastrar);
            Controls.Add(entrar);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_senha;
        private Button entrar;
        private Button cadastrar;
        private Label label2;
        private Label label1;
        private Button sair;
    }
}
