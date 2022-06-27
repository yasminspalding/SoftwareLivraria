
namespace SoftwareLivraria
{
    partial class Cadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.datNasc = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.maskedTextBoxDataDeNasc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(53, 216);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(86, 20);
            this.telefone.TabIndex = 2;
            this.telefone.Text = "Telefone: ";
            // 
            // datNasc
            // 
            this.datNasc.AutoSize = true;
            this.datNasc.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datNasc.Location = new System.Drawing.Point(53, 173);
            this.datNasc.Name = "datNasc";
            this.datNasc.Size = new System.Drawing.Size(172, 20);
            this.datNasc.TabIndex = 3;
            this.datNasc.Text = "Data de Nascimento: ";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(53, 256);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(91, 20);
            this.endereco.TabIndex = 4;
            this.endereco.Text = "Endereço: ";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(53, 295);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(79, 20);
            this.usuario.TabIndex = 5;
            this.usuario.Text = "Usuário: ";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(53, 332);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(66, 20);
            this.senha.TabIndex = 6;
            this.senha.Text = "Senha: ";
            // 
            // maskedTextBoxDataDeNasc
            // 
            this.maskedTextBoxDataDeNasc.Location = new System.Drawing.Point(243, 173);
            this.maskedTextBoxDataDeNasc.Mask = "9999-99-99";
            this.maskedTextBoxDataDeNasc.Name = "maskedTextBoxDataDeNasc";
            this.maskedTextBoxDataDeNasc.Size = new System.Drawing.Size(266, 20);
            this.maskedTextBoxDataDeNasc.TabIndex = 7;
            this.maskedTextBoxDataDeNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDataDeNasc_MaskInputRejected);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(243, 216);
            this.maskedTextBoxTelefone.Mask = "(99) 99999 - 9999";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(266, 20);
            this.maskedTextBoxTelefone.TabIndex = 8;
            this.maskedTextBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefone_MaskInputRejected);
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(243, 133);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(266, 20);
            this.textBoxnome.TabIndex = 9;
            this.textBoxnome.TextChanged += new System.EventHandler(this.textBoxnome_TextChanged);
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(243, 256);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(266, 20);
            this.textBoxEndereco.TabIndex = 10;
            this.textBoxEndereco.TextChanged += new System.EventHandler(this.textBoxEndereco_TextChanged);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(243, 295);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(266, 20);
            this.textBoxUsuario.TabIndex = 11;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(243, 332);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(266, 20);
            this.textBoxSenha.TabIndex = 12;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Cadastrar.FlatAppearance.BorderSize = 2;
            this.Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(216, 391);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(138, 47);
            this.Cadastrar.TabIndex = 13;
            this.Cadastrar.Text = "Cadastar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(53, 95);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(77, 20);
            this.codigo.TabIndex = 14;
            this.codigo.Text = "Código: ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(243, 97);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(266, 20);
            this.textBoxCodigo.TabIndex = 15;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxDataDeNasc);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.datNasc);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label datNasc;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataDeNasc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
    }
}