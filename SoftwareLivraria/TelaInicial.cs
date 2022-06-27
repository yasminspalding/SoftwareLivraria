using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareLivraria
{
    public partial class TelaInicial : Form
    {
        Cliente cli;
        Funcionario fun;

        public TelaInicial()
        {
            InitializeComponent();
            cli = new Cliente();
            fun = new Funcionario();
        }

        private void texto_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cli.ShowDialog();
            this.Visible = true;
        }

        private void Funcionario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            fun.ShowDialog();
            this.Visible = true;
        }
    } // fim da classe 
}// fim do proeto 
