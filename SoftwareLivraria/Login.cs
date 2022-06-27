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
    public partial class Login : Form
    {
        MenuCliente menuC;
        DAOCliente daoC;
        public int i;
        public string usua;
        public string sen;
        
       


        public Login()
        {
            InitializeComponent();
            daoC = new DAOCliente();
        }

        private void senha_Click(object sender, EventArgs e)
        {

        }

        public void Validacao()
        {
            try
            {
                if (daoC.ConsultarUsuario(usua) == usua && daoC.ConsultarSenha(sen) == sen)
                {
                    MessageBox.Show("Login Efetuado!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }

            private void Entrar_Click(object sender, EventArgs e)
            {
                Validacao();
                menuC = new MenuCliente();
                this.Visible = false;
                menuC.ShowDialog();
                this.Visible = true;

            }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
