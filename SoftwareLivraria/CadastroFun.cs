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
    public partial class CadastroFun : Form
    {
        DAOFuncionario funcionario;
        public CadastroFun()
        {
            InitializeComponent();
            funcionario = new DAOFuncionario();
            textBoxCodigoF.Text = Convert.ToString(funcionario.ConsultarCodigoFuncionario() + 1);
            textBoxCodigoF.ReadOnly = true;

        }
        public void Limpar()
        {
            textBoxCodigoF.Text = "" + funcionario.ConsultarCodigoFuncionario();
            textBoxCargo.Text = "";
            textBoxNomeF.Text = "";
            maskedTextBoxDataF.Text = "" + new DateTime();
            maskedTextBoxTelefoneF.Text = "";
            textBoxEnderecoF.Text = "";
            textBoxUsuarioF.Text = "";
           
        }
        public void AtivarCampos()
        {
            textBoxCodigoF.ReadOnly = false;
            textBoxCargo.ReadOnly = true;
            textBoxNomeF.ReadOnly = true;
            maskedTextBoxDataF.ReadOnly = true;
            maskedTextBoxTelefoneF.ReadOnly = true;
            textBoxEnderecoF.ReadOnly = true;
            textBoxUsuarioF.ReadOnly = true;
            textBoxUsuarioF.ReadOnly = true;
           
        } // fim ativar campos

        public void InativarCampos()
        {
            textBoxCodigoF.ReadOnly = true;
            textBoxCargo.ReadOnly = false;
            textBoxNomeF.ReadOnly = false;
            maskedTextBoxDataF.ReadOnly = false;
            maskedTextBoxTelefoneF.ReadOnly = false;
            textBoxEnderecoF.ReadOnly = false;
            textBoxUsuarioF.ReadOnly = false;
            textBoxUsuarioF.ReadOnly = false;
           
        } // fim inativar campos


        public void AtivarTodosCampos()
        {
            textBoxCodigoF.ReadOnly = false;
            textBoxCargo.ReadOnly = false;
            textBoxNomeF.ReadOnly = false;
            maskedTextBoxDataF.ReadOnly = false;
            maskedTextBoxTelefoneF.ReadOnly = false;
            textBoxEnderecoF.ReadOnly = false;
            textBoxUsuarioF.ReadOnly = false;
            textBoxUsuarioF.ReadOnly = false;

        } // fim ativar campos

       


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCodigoF.ReadOnly == false)
                {
                    Limpar();
                    InativarCampos();
                }
                else
                {
                    string cargo = textBoxCargo.Text;
                    string nomeF = textBoxNomeF.Text;
                    DateTime dataF = Convert.ToDateTime(maskedTextBoxDataF.Text);
                    string telefoneF = maskedTextBoxTelefoneF.Text;
                    string enderecoF = textBoxEnderecoF.Text;
                    string usuarioF = textBoxUsuarioF.Text;
                   

                    funcionario.CadastarFuncionario(cargo, nomeF, dataF, telefoneF, enderecoF, usuarioF);
                    Limpar();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
        } // fim do botao cadastrar 

       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarFuncionario_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxCodigoF.ReadOnly == false)
                {
                    Limpar();
                    InativarCampos();
                }
                else
                {
                    string cargo = textBoxCargo.Text;
                    string nomeF = textBoxNomeF.Text;
                    DateTime dataF = Convert.ToDateTime(maskedTextBoxDataF.Text);
                    string telefoneF = maskedTextBoxTelefoneF.Text;
                    string enderecoF = textBoxEnderecoF.Text;
                    string usuarioF = textBoxUsuarioF.Text;
                    

                    funcionario.CadastarFuncionario(cargo, nomeF, dataF, telefoneF, enderecoF, usuarioF);
                    Limpar();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }




        } // fim cadastrar funcionario 

        private void textBoxCodigoF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeF_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDataF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxTelefoneF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxEnderecoF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuarioF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenhaF_TextChanged(object sender, EventArgs e)
        {

        }
    } // FIM DA CLASSE
} // FIM DO PROJETO 
