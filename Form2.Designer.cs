namespace Projetp___Agenda
{
    partial class Form2
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
            txt_senha = new TextBox();
            txt_telefone = new TextBox();
            txt_usuario = new TextBox();
            txt_nome = new TextBox();
            txt_confirmar_senha = new TextBox();
            cadastro = new Button();
            cancelar = new Button();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.BackColor = SystemColors.InactiveCaption;
            txt_senha.Location = new Point(12, 218);
            txt_senha.Multiline = true;
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(153, 35);
            txt_senha.TabIndex = 2;
            txt_senha.Text = "SENHA";
            txt_senha.TextChanged += txt_senha_TextChanged;
            // 
            // txt_telefone
            // 
            txt_telefone.BackColor = SystemColors.InactiveCaption;
            txt_telefone.Location = new Point(12, 94);
            txt_telefone.Multiline = true;
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(205, 35);
            txt_telefone.TabIndex = 3;
            txt_telefone.Text = "TELEFONE";
            txt_telefone.TextChanged += txt_telefone_TextChanged;
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.InactiveCaption;
            txt_usuario.Location = new Point(12, 53);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(205, 35);
            txt_usuario.TabIndex = 4;
            txt_usuario.Text = "USUARIO";
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // txt_nome
            // 
            txt_nome.BackColor = SystemColors.InactiveCaption;
            txt_nome.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nome.Location = new Point(12, 12);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(205, 35);
            txt_nome.TabIndex = 5;
            txt_nome.Text = "NOME";
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // txt_confirmar_senha
            // 
            txt_confirmar_senha.BackColor = SystemColors.InactiveCaption;
            txt_confirmar_senha.Location = new Point(12, 259);
            txt_confirmar_senha.Multiline = true;
            txt_confirmar_senha.Name = "txt_confirmar_senha";
            txt_confirmar_senha.Size = new Size(153, 35);
            txt_confirmar_senha.TabIndex = 6;
            txt_confirmar_senha.Text = "CONFIRMAR SENHA";
            txt_confirmar_senha.TextChanged += txt_confirmar_senha_TextChanged;
            // 
            // cadastro
            // 
            cadastro.BackColor = Color.Silver;
            cadastro.Enabled = false;
            cadastro.Location = new Point(181, 396);
            cadastro.Name = "cadastro";
            cadastro.Size = new Size(75, 52);
            cadastro.TabIndex = 7;
            cadastro.Text = "CADASTRO";
            cadastro.UseVisualStyleBackColor = false;
            // 
            // cancelar
            // 
            cancelar.BackColor = Color.Silver;
            cancelar.Location = new Point(345, 396);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(80, 52);
            cancelar.TabIndex = 8;
            cancelar.Text = "CANCELAR";
            cancelar.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WALLPAPER02;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(586, 470);
            Controls.Add(cancelar);
            Controls.Add(cadastro);
            Controls.Add(txt_confirmar_senha);
            Controls.Add(txt_nome);
            Controls.Add(txt_usuario);
            Controls.Add(txt_telefone);
            Controls.Add(txt_senha);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_senha;
        private TextBox txt_telefone;
        private TextBox txt_usuario;
        private TextBox txt_nome;
        private TextBox txt_confirmar_senha;
        private Button cadastro;
        private Button cancelar;
    }
}