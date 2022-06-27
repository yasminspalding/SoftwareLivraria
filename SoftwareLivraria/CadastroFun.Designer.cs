
namespace SoftwareLivraria
{
    partial class CadastroFun
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
            this.textBoxUsuarioF = new System.Windows.Forms.TextBox();
            this.textBoxEnderecoF = new System.Windows.Forms.TextBox();
            this.textBoxNomeF = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefoneF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataF = new System.Windows.Forms.MaskedTextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.Label();
            this.datNasc = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoF = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.Label();
            this.CadastrarFuncionario = new System.Windows.Forms.Button();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsuarioF
            // 
            this.textBoxUsuarioF.Location = new System.Drawing.Point(274, 350);
            this.textBoxUsuarioF.Name = "textBoxUsuarioF";
            this.textBoxUsuarioF.Size = new System.Drawing.Size(255, 20);
            this.textBoxUsuarioF.TabIndex = 24;
            this.textBoxUsuarioF.TextChanged += new System.EventHandler(this.textBoxUsuarioF_TextChanged);
            // 
            // textBoxEnderecoF
            // 
            this.textBoxEnderecoF.Location = new System.Drawing.Point(274, 311);
            this.textBoxEnderecoF.Name = "textBoxEnderecoF";
            this.textBoxEnderecoF.Size = new System.Drawing.Size(255, 20);
            this.textBoxEnderecoF.TabIndex = 23;
            this.textBoxEnderecoF.TextChanged += new System.EventHandler(this.textBoxEnderecoF_TextChanged);
            // 
            // textBoxNomeF
            // 
            this.textBoxNomeF.Location = new System.Drawing.Point(274, 188);
            this.textBoxNomeF.Name = "textBoxNomeF";
            this.textBoxNomeF.Size = new System.Drawing.Size(255, 20);
            this.textBoxNomeF.TabIndex = 22;
            this.textBoxNomeF.TextChanged += new System.EventHandler(this.textBoxNomeF_TextChanged);
            // 
            // maskedTextBoxTelefoneF
            // 
            this.maskedTextBoxTelefoneF.Location = new System.Drawing.Point(274, 271);
            this.maskedTextBoxTelefoneF.Mask = "(99) 99999 - 9999";
            this.maskedTextBoxTelefoneF.Name = "maskedTextBoxTelefoneF";
            this.maskedTextBoxTelefoneF.Size = new System.Drawing.Size(255, 20);
            this.maskedTextBoxTelefoneF.TabIndex = 21;
            this.maskedTextBoxTelefoneF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxTelefoneF_MaskInputRejected);
            // 
            // maskedTextBoxDataF
            // 
            this.maskedTextBoxDataF.Location = new System.Drawing.Point(274, 228);
            this.maskedTextBoxDataF.Mask = "9999-99-99";
            this.maskedTextBoxDataF.Name = "maskedTextBoxDataF";
            this.maskedTextBoxDataF.Size = new System.Drawing.Size(255, 20);
            this.maskedTextBoxDataF.TabIndex = 20;
            this.maskedTextBoxDataF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDataF_MaskInputRejected);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(84, 350);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(79, 20);
            this.usuario.TabIndex = 18;
            this.usuario.Text = "Usuário: ";
            // 
            // endereco
            // 
            this.endereco.AutoSize = true;
            this.endereco.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco.Location = new System.Drawing.Point(84, 311);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(91, 20);
            this.endereco.TabIndex = 17;
            this.endereco.Text = "Endereço: ";
            // 
            // datNasc
            // 
            this.datNasc.AutoSize = true;
            this.datNasc.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datNasc.Location = new System.Drawing.Point(84, 228);
            this.datNasc.Name = "datNasc";
            this.datNasc.Size = new System.Drawing.Size(172, 20);
            this.datNasc.TabIndex = 16;
            this.datNasc.Text = "Data de Nascimento: ";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(84, 271);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(86, 20);
            this.telefone.TabIndex = 15;
            this.telefone.Text = "Telefone: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cadastro Funcionários";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCodigoF
            // 
            this.textBoxCodigoF.Location = new System.Drawing.Point(274, 111);
            this.textBoxCodigoF.Name = "textBoxCodigoF";
            this.textBoxCodigoF.Size = new System.Drawing.Size(255, 20);
            this.textBoxCodigoF.TabIndex = 27;
            this.textBoxCodigoF.TextChanged += new System.EventHandler(this.textBoxCodigoF_TextChanged);
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo.Location = new System.Drawing.Point(86, 109);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(77, 20);
            this.codigo.TabIndex = 26;
            this.codigo.Text = "Código: ";
            // 
            // CadastrarFuncionario
            // 
            this.CadastrarFuncionario.BackColor = System.Drawing.Color.LavenderBlush;
            this.CadastrarFuncionario.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.CadastrarFuncionario.FlatAppearance.BorderSize = 2;
            this.CadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarFuncionario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarFuncionario.Location = new System.Drawing.Point(212, 400);
            this.CadastrarFuncionario.Name = "CadastrarFuncionario";
            this.CadastrarFuncionario.Size = new System.Drawing.Size(128, 38);
            this.CadastrarFuncionario.TabIndex = 28;
            this.CadastrarFuncionario.Text = "Cadastar";
            this.CadastrarFuncionario.UseVisualStyleBackColor = false;
            this.CadastrarFuncionario.Click += new System.EventHandler(this.CadastrarFuncionario_Click);
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(274, 149);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(255, 20);
            this.textBoxCargo.TabIndex = 29;
            // 
            // cargo
            // 
            this.cargo.AutoSize = true;
            this.cargo.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo.Location = new System.Drawing.Point(86, 149);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(66, 20);
            this.cargo.TabIndex = 30;
            this.cargo.Text = "Cargo: ";
            // 
            // CadastroFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.CadastrarFuncionario);
            this.Controls.Add(this.textBoxCodigoF);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.textBoxUsuarioF);
            this.Controls.Add(this.textBoxEnderecoF);
            this.Controls.Add(this.textBoxNomeF);
            this.Controls.Add(this.maskedTextBoxTelefoneF);
            this.Controls.Add(this.maskedTextBoxDataF);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.datNasc);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFun";
            this.Text = "Cadastro Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsuarioF;
        private System.Windows.Forms.TextBox textBoxEnderecoF;
        private System.Windows.Forms.TextBox textBoxNomeF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataF;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label endereco;
        private System.Windows.Forms.Label datNasc;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoF;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Button CadastrarFuncionario;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Label cargo;
    }
}