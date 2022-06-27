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
    public partial class Funcionario : Form
    {
        CadastroFun cadF;
        LoginFun logF;
        public Funcionario()
        {
            InitializeComponent();
            cadF = new CadastroFun();
            logF = new LoginFun();

        }

        private void Cadastro_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            cadF.ShowDialog();
            this.Visible = true;
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            logF.ShowDialog();
            this.Visible = true;

        }

        private void texto_Click(object sender, EventArgs e)
        {

        }
    }
}
