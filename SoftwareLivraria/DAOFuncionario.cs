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
    class DAOFuncionario
    {
        public MySqlConnection conexaoFuncionario;
        public string dadosF;
        public string comandoF;
        public string resultadoF;
        // declarando vetores 
        public int[] codigoF;
        public string[] nomeF;
        public string[] cargoF;
        public DateTime[] dataNascF;
        public string[] telefoneF;
        public string[] enderecoF;
        public string[] usuarioF;
        
        public int i;
        public int contador;
        public int contadorCodigoF;
        public DAOFuncionario()
        {
            conexaoFuncionario = new MySqlConnection("server=localhost;DataBase=Livraria;Uid=root;password=");
            try
            {
                conexaoFuncionario.Open(); // tentando a conexao com o BD
                MessageBox.Show("Conectado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro); // enviando mensagem de erro 
                conexaoFuncionario.Close(); // fechano a conexao como BD
            }

        } // fim DAO funcionario 

        public void CadastarFuncionario(string cargo, string nome, DateTime dataNasc, string telefone, string endereco, string usuario)
        {
            try
            {
                // preparar os dados para inserir no Bd 
                dadosF = "('', '" + nome + "','" + dataNasc + "','" + telefone + "','" + endereco + "','" + usuario + "')";
                comandoF = "Insert into Funcionario(codigoFuncionario, cargo, nome, dataDeNasc, telefone, endereco, usuario) values " + dadosF;

                // executar o comando na base de dados 
                MySqlCommand sql = new MySqlCommand(comandoF, conexaoFuncionario);
                resultadoF = "" + sql.ExecuteNonQuery();
                if (resultadoF == "1")
                {
                    MessageBox.Show("Cadastrado com Sucesso!");
                }
                else
                {
                    MessageBox.Show("Não Cadastrado!");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        } // fim cadastrar cliente











        public void PreencherVetorFuncionario()
        {
            string query = "select * from Funcionario"; // coletar os dados do BD

            // instanciando os vetores 
            codigoF = new int[100];
            cargoF = new string[100];
            nomeF = new string[100];
            dataNascF = new DateTime[100];
            telefoneF = new string[100];
            enderecoF = new string[100];
            usuarioF = new string[100];
           

            // dando valores iniciais para os vetores
            for (i = 0; i < 100; i++)
            {
                codigoF[i] = 0;
                cargoF[i] = "";
                nomeF[i] = "";
                dataNascF[i] = new DateTime();
                telefoneF[i] = "";
                enderecoF[i] = "";
                usuarioF[i] = "";
                
            } // fim for 

            // realizar comandos de consulta 
            MySqlCommand coletar = new MySqlCommand(query, conexaoFuncionario);
            // ler os dados 
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            contadorCodigoF = 0;

            // preencher os vetores 
            while (leitura.Read())
            {
                codigoF[i] = Convert.ToInt32(leitura["codigo"]);
                cargoF[i] = leitura["cargo"] + "";
                nomeF[i] = leitura["nome"] + "";
                dataNascF[i] = Convert.ToDateTime(leitura["dataDeNascimento"]);
                telefoneF[i] = leitura["telefone"] + "";
                enderecoF[i] = leitura["endereco"] + "";
                usuarioF[i] = leitura["usuario"] + "";
               
            }
            leitura.Close();
        } // fim preencher vetor 

        public int ConsultarCodigoFuncionario()
        {
            PreencherVetorFuncionario();
            return codigoF[contadorCodigoF];
        } // fim consultar codigo 



    }// fim da classe
} // fim do projeto 
