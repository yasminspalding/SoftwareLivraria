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
    public partial class Cliente : Form
    {
        Cadastro cad;
        Login log;
        public Cliente()
        {
            InitializeComponent();
            
            
        }

        private void Cadastro_Click(object sender, EventArgs e)
        {
            cad = new Cadastro();
            this.Visible = false;
            cad.ShowDialog();
            this.Visible = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            log = new Login();
            this.Visible = false;
            log.ShowDialog();
            this.Visible = true;
        }

        private void texto_Click(object sender, EventArgs e)
        {

        }
    }
}
