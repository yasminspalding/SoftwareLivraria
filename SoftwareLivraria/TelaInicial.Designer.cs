
namespace SoftwareLivraria
{
    partial class TelaInicial
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
            this.Funcionario = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(15, 55);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(583, 90);
            this.texto.TabIndex = 6;
            this.texto.Text = "Selecione uma das opções abaixo para continuar\r\n\r\n\r\n";
            this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.texto.Click += new System.EventHandler(this.texto_Click);
            // 
            // Funcionario
            // 
            this.Funcionario.BackColor = System.Drawing.Color.LavenderBlush;
            this.Funcionario.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Funcionario.FlatAppearance.BorderSize = 2;
            this.Funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Funcionario.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funcionario.Location = new System.Drawing.Point(165, 277);
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(267, 47);
            this.Funcionario.TabIndex = 5;
            this.Funcionario.Text = "Funcionario";
            this.Funcionario.UseVisualStyleBackColor = false;
            this.Funcionario.Click += new System.EventHandler(this.Funcionario_Click);
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cliente.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Cliente.FlatAppearance.BorderSize = 2;
            this.Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cliente.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(165, 175);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(267, 47);
            this.Cliente.TabIndex = 4;
            this.Cliente.Text = "Cliente";
            this.Cliente.UseVisualStyleBackColor = false;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.Funcionario);
            this.Controls.Add(this.Cliente);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button Funcionario;
        private System.Windows.Forms.Button Cliente;
    }
}