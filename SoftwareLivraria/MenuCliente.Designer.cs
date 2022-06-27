
namespace SoftwareLivraria
{
    partial class MenuCliente
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
            this.Compra = new System.Windows.Forms.Button();
            this.AtualizarDados = new System.Windows.Forms.Button();
            this.Reserva = new System.Windows.Forms.Button();
            this.consultarReserva = new System.Windows.Forms.Button();
            this.consultarCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma das opções abaixo";
            // 
            // Compra
            // 
            this.Compra.BackColor = System.Drawing.Color.LavenderBlush;
            this.Compra.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Compra.FlatAppearance.BorderSize = 2;
            this.Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compra.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compra.Location = new System.Drawing.Point(125, 117);
            this.Compra.Name = "Compra";
            this.Compra.Size = new System.Drawing.Size(171, 47);
            this.Compra.TabIndex = 16;
            this.Compra.Text = "Compra";
            this.Compra.UseVisualStyleBackColor = false;
            this.Compra.Click += new System.EventHandler(this.Compra_Click);
            // 
            // AtualizarDados
            // 
            this.AtualizarDados.BackColor = System.Drawing.Color.LavenderBlush;
            this.AtualizarDados.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.AtualizarDados.FlatAppearance.BorderSize = 2;
            this.AtualizarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AtualizarDados.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtualizarDados.Location = new System.Drawing.Point(200, 275);
            this.AtualizarDados.Name = "AtualizarDados";
            this.AtualizarDados.Size = new System.Drawing.Size(234, 47);
            this.AtualizarDados.TabIndex = 17;
            this.AtualizarDados.Text = "Atualizar ou Excluir Dados ";
            this.AtualizarDados.UseVisualStyleBackColor = false;
            this.AtualizarDados.Click += new System.EventHandler(this.AtualizarDados_Click);
            // 
            // Reserva
            // 
            this.Reserva.BackColor = System.Drawing.Color.LavenderBlush;
            this.Reserva.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.Reserva.FlatAppearance.BorderSize = 2;
            this.Reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reserva.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserva.Location = new System.Drawing.Point(334, 117);
            this.Reserva.Name = "Reserva";
            this.Reserva.Size = new System.Drawing.Size(171, 47);
            this.Reserva.TabIndex = 18;
            this.Reserva.Text = "Reserva";
            this.Reserva.UseVisualStyleBackColor = false;
            this.Reserva.Click += new System.EventHandler(this.Reserva_Click);
            // 
            // consultarReserva
            // 
            this.consultarReserva.BackColor = System.Drawing.Color.LavenderBlush;
            this.consultarReserva.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.consultarReserva.FlatAppearance.BorderSize = 2;
            this.consultarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarReserva.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarReserva.Location = new System.Drawing.Point(334, 200);
            this.consultarReserva.Name = "consultarReserva";
            this.consultarReserva.Size = new System.Drawing.Size(171, 47);
            this.consultarReserva.TabIndex = 19;
            this.consultarReserva.Text = "Consultar Reserva";
            this.consultarReserva.UseVisualStyleBackColor = false;
            this.consultarReserva.Click += new System.EventHandler(this.consultarReserva_Click);
            // 
            // consultarCompra
            // 
            this.consultarCompra.BackColor = System.Drawing.Color.LavenderBlush;
            this.consultarCompra.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.consultarCompra.FlatAppearance.BorderSize = 2;
            this.consultarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarCompra.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarCompra.Location = new System.Drawing.Point(125, 200);
            this.consultarCompra.Name = "consultarCompra";
            this.consultarCompra.Size = new System.Drawing.Size(171, 47);
            this.consultarCompra.TabIndex = 20;
            this.consultarCompra.Text = "Consultar Compra";
            this.consultarCompra.UseVisualStyleBackColor = false;
            this.consultarCompra.Click += new System.EventHandler(this.consultarCompra_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(596, 364);
            this.Controls.Add(this.consultarCompra);
            this.Controls.Add(this.consultarReserva);
            this.Controls.Add(this.Reserva);
            this.Controls.Add(this.AtualizarDados);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MenuCliente";
            this.Text = "Menu Cliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Compra;
        private System.Windows.Forms.Button AtualizarDados;
        private System.Windows.Forms.Button Reserva;
        private System.Windows.Forms.Button consultarReserva;
        private System.Windows.Forms.Button consultarCompra;
    }
}