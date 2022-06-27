
namespace SoftwareLivraria
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o login e senha";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(70, 149);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(74, 20);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuário:";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(70, 215);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(61, 20);
            this.senha.TabIndex = 2;
            this.senha.Text = "Senha:";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(163, 151);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(265, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(163, 215);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(265, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.Entrar.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Entrar.FlatAppearance.BorderSize = 2;
            this.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Location = new System.Drawing.Point(207, 279);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(138, 47);
            this.Entrar.TabIndex = 15;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(553, 356);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button Entrar;
    }
}