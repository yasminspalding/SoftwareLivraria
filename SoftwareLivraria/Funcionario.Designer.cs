
namespace SoftwareLivraria
{
    partial class Funcionario
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
            this.texto = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(104, 69);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(406, 60);
            this.texto.TabIndex = 6;
            this.texto.Text = "Selecione uma das opções abaixo\r\n\r\n";
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LavenderBlush;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Login.FlatAppearance.BorderSize = 2;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(166, 278);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(267, 47);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cadastro.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Cadastro.FlatAppearance.BorderSize = 2;
            this.Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastro.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastro.Location = new System.Drawing.Point(166, 178);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(267, 47);
            this.Cadastro.TabIndex = 4;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = false;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Cadastro);
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Cadastro;
    }
}