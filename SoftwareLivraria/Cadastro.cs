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
    public partial class Cadastro : Form
    {
        DAOCliente cliente;
        public Cadastro()
        {
            InitializeComponent();
            cliente = new DAOCliente();
            textBoxCodigo.Text = Convert.ToString(cliente.ConsultarCodigo() + 1);
            textBoxCodigo.ReadOnly = true;

        }
        public void Limpar()
        {
            textBoxCodigo.Text = "" + cliente.ConsultarCodigo();
            textBoxnome.Text = "";
            maskedTextBoxDataDeNasc.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEndereco.Text = "";
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
        }
        public void AtivarCampos()
        {
            textBoxCodigo.ReadOnly = false;
            textBoxnome.ReadOnly = true;
            maskedTextBoxDataDeNasc.ReadOnly = true;
            maskedTextBoxTelefone.ReadOnly = true;
            textBoxEndereco.ReadOnly = true;
            textBoxUsuario.ReadOnly = true;
            textBoxUsuario.ReadOnly = true;
            textBoxSenha.ReadOnly = true;
        } // fim ativar campos

        public void InativarCampos()
        {
            textBoxCodigo.ReadOnly = true;
            textBoxnome.ReadOnly = false;
            maskedTextBoxDataDeNasc.ReadOnly = false;
            maskedTextBoxTelefone.ReadOnly = false;
            textBoxEndereco.ReadOnly = false;
            textBoxUsuario.ReadOnly = false;
            textBoxUsuario.ReadOnly = false;
            textBoxSenha.ReadOnly = false;
        } // fim inativar campos


        public void AtivarTodosCampos()
        {
            textBoxCodigo.ReadOnly = false;
            textBoxnome.ReadOnly = false;
            maskedTextBoxDataDeNasc.ReadOnly = false;
            maskedTextBoxTelefone.ReadOnly = false;
            textBoxEndereco.ReadOnly = false;
            textBoxUsuario.ReadOnly = false;
            textBoxUsuario.ReadOnly = false;
            textBoxSenha.ReadOnly = false;
        } // fim ativar campos

        public DateTime TratarData(string dataNasc)
        {
            string tratamento = dataNasc.Replace(",", "");
            tratamento = tratamento.Replace("-", "");
            return Convert.ToDateTime(tratamento);
        } // fim tratar data


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBoxCodigo.ReadOnly == false)
                {
                    Limpar();
                    InativarCampos();
                }
                else
                {
                   
                    string nome         = textBoxnome.Text;
                    DateTime dataDeNasc = Convert.ToDateTime(maskedTextBoxDataDeNasc.Text);
                    string telefone     = maskedTextBoxTelefone.Text;
                    string endereco     = textBoxEndereco.Text;
                    string usuario      = textBoxUsuario.Text;
                    string senha        = textBoxSenha.Text;

                    cliente.CadastarCliente(nome, dataDeNasc, telefone, endereco, usuario, senha);
                    Limpar();
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("" + erro);
            }


        } // fim do botao cadastrar 

















        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxDataDeNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    } // fim do botao cadastrar  
    } // fim da classe

