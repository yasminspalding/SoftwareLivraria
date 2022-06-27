using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SoftwareLivraria
{
    class DAOCliente
    {
        public MySqlConnection conexaoCliente;
        public string dados;
        public string comando;
        public string resultado;
        // declarando vetores 
        public int[] codigo;
        public string[] nome;
        public DateTime[] dataNasc;
        public string[] telefone;
        public string[] endereco;
        public string[] usuario;
        public string[] senha;
        public int i;
        public int contador;
        public int contadorCodigo;
       


        public DAOCliente()
        {
            conexaoCliente = new MySqlConnection("server=localhost;DataBase=Livraria;Uid=root;password=");
            try
            {
                conexaoCliente.Open(); // tentando a conexao com o BD
               
            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro); // enviando mensagem de erro 
                conexaoCliente.Close(); // fechano a conexao como BD
            }

        } // fim DAO cliente 

        public void CadastarCliente(string nome, DateTime dataNasc, string telefone, string endereco, string usuario, string senha)
        {
            try
            {
                // preparar os dados para inserir no Bd 
                dados   = "('', '" + nome + "','" + dataNasc + "','" + telefone + "','" + endereco + "','" + usuario + "','" + senha + "')";
                comando = "Insert into Cliente(codigoCliente, nome, dataDeNascimento, telefone, endereco, usuario, senha) values " + dados;

                // executar o comando na base de dados 
                MySqlCommand sql = new MySqlCommand(comando, conexaoCliente);
                resultado = "" + sql.ExecuteNonQuery();
                if (resultado == "1")
                {
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Cadastrado!");
                }

            }
            catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        } // fim cadastrar cliente


        public void PreencherVetorCliente()
        {
            string query = "select * from Cliente"; // coletar os dados do BD

            // instanciando os vetores 
            codigo = new int[100];
            nome = new string[100];
            //dataNasc = new DateTime[100];
            telefone = new string[100];
            endereco = new string[100];
            usuario = new string[100];
            senha = new string[100];


            // dando valores iniciais para os vetores
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                nome[i] = "";
               // dataNasc[i] = new DateTime();
                telefone[i] = "";
                endereco[i] = "";
                usuario[i] = "";
                senha[i] = "";

            } // fim for 

            // realizar comandos de consulta 
            MySqlCommand coletar = new MySqlCommand(query, conexaoCliente);
            // ler os dados 
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            contadorCodigo = 0;

            // preencher os vetores 
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigoCliente"]);
                nome[i] = leitura["nome"] + "";
               // dataNasc[i] = Convert.ToDateTime(leitura["dataDeNascimento"]);
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                usuario[i] = leitura["usuario"] + "";
                senha[i] = leitura["senha"] + "";

            }
            leitura.Close();
        } // fim preencher vetor 

        public int ConsultarCodigo()
        {
            PreencherVetorCliente();
            return codigo[contadorCodigo];
        } // fim consultar codigo 


        public string ConsultarUsuario(string usua)
        {
            PreencherVetorCliente();
            for (i = 0; i < contador; i++)
            {
                if (usuario[i] == usua)
                {
                    return usuario[i];
                }
            }//fim do for
            return "Usuario não encontrado!";
        }//fim do consultarUsuario


        public string ConsultarSenha(string sen)
        {
            PreencherVetorCliente();
            for (i = 0; i < contador; i++)
            {
                if (senha[i] == sen)
                {
                    return senha[i];
                }
            }//fim do for
            return "Senha não encontrado!";
        }//fim do consultarUsuario


    } // fim da classe 
} // fim do projeto 
