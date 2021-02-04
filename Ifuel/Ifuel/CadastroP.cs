using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class CadastroP
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
       string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";


        /************/
        #region Declaração de variaveis
        /*Dados cadastro do Posto*/
        public string NomePosto = null;
        public string Cnpj = null;
        public string Alvara = null;
        /************************/

        /*Dados do Endereço*/
        public string Estado = null;
        string Cidade = null;
        string Bairro = null;
        int Cep = 0;
        string Endereco = null;
        /*******************/

        /*Dados do combustivel*/
        public string NomeComb1 = null;//Recebe os dados do Form
        public string NomeComb2 = null;
        public string NomeComb3 = null;
        public double ValorComb1 = 0.0;//Recebe os dados de valor do Form
        public double ValorComb2 = 0.0;//Recebe os dados de valor do Form
        public double ValorComb3 = 0.0;//Recebe os dados de valor do Form
        /*********************/

        /*Variaveis Adicionas*/
        public bool Cadastrar = true;
        public bool Termo =false;
        public int ID_Comb1 = 0;//Recebe os ID's da tabela=Combustivel
        public int ID_Comb2 = 0;
        public int ID_Comb3 = 0;
        public string messageErro = null;
        private string Senha = null;
        private string User = null;
        /*************************/

        #endregion
        #region Contrutor
        public CadastroP(string NomePosto, string Cnpj, string Alvara, string Estado, string Cidade, string Bairro, int Cep, string Endereco, string NomeComb1, string NomeComb2, string NomeComb3, double ValorComb1,double ValorComb2, double ValorComb3, bool  Termo)
        {

            this.NomePosto = NomePosto.ToUpper();
            this.Cnpj = Cnpj;
            this.Alvara = Alvara;
            this.Estado = Estado.ToUpper();
            this.Cidade = Cidade.ToUpper();
            this.Bairro = Bairro.ToUpper();
            this.Cep = Cep;
            this.Endereco = Endereco;
            this.NomeComb1 = NomeComb1;
            this.NomeComb2 = NomeComb2;
            this.NomeComb3 = NomeComb3;
            this.ValorComb1 = ValorComb1;
            this.ValorComb1 = ValorComb2;
            this.ValorComb1 = ValorComb3;
            this.Termo = Termo;

        }
        #endregion
        #region Métodos      
        public void setCadastroPosto()
        {
            
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();

                if (!string.IsNullOrEmpty(NomePosto) || !string.IsNullOrEmpty(Cnpj) || !string.IsNullOrEmpty(Alvara) || !string.IsNullOrEmpty(Estado) || !string.IsNullOrEmpty(Cidade) || !string.IsNullOrEmpty(Bairro) || Cep == 0 || !string.IsNullOrEmpty(Endereco) || !Termo)
                {
                    //Se cadastrar igual falso, tenta cadastrar. Se for verdadeiro não tenta cadastrar
                    try
                    {
                        /*Comandos e conexões*/
                        Command.Connection = conectar;
                        Command.CommandType = CommandType.Text;


                        #region Selects para pegar o ID do combustivel
                        /*Selects para pegar os nomes dos combustiveis e salvar na tabela do POSTO.*/
                        Command.CommandText = "SELECT COD_COMB FROM COMBUSTIVEL WHERE NOME_COMB = '" + NomeComb1 + "'";
                        int comb1 = (int)Command.ExecuteScalar();

                        Command.CommandText = "SELECT COD_COMB FROM COMBUSTIVEL WHERE NOME_COMB = '" + NomeComb2 + "'";
                        int comb2 = (int)Command.ExecuteScalar();
                        //int comb2 = int.Parse(Command.ExecuteReader());
                        Command.CommandText = "SELECT COD_COMB FROM COMBUSTIVEL WHERE NOME_COMB = '" + NomeComb3 + "'";
                        int comb3 = (int)Command.ExecuteScalar();
                        #endregion




                        #region Inserir dados na Tabela Posto
                        /*String para inserir cadastro na tabela POSTO*/
                        Command.CommandText = "INSERT INTO POSTO VALUES (0,'"+NomePosto+"', '"+Cnpj+"', '"+Estado+"','"+Cidade+"','"+Endereco+"','"+Bairro+"','"+Cep+ "','" + comb1+ "','" + comb2 + "','" + comb3 + "','"+Alvara+"')";
                        Command.ExecuteNonQuery();
                        #endregion

                        #region Inserir dados na Tabela POSTOSISTEMA
                        /*Select para buscar o ID do POSTO */
                        Command.CommandText = "SELECT MAX(ID_POSTO) FROM POSTO";
                        int ID_Posto = (int)Command.ExecuteScalar();

                        /*String para inserir na Tabela POSTOSISTEMA -> OBS:Usuário e senha do Posto é  CNPJ dele*/
                        Senha = Cnpj.Substring(0,5); //Realiza o corte na strign para salvar apenas os 5 primeiros numeros como senha
                        User = Cnpj.Substring(0, 5); //Realiza o corte na strign para salvar apenas os 5 primeiros numeros como Usuário
                        Command.CommandText = "INSERT INTO POSTOSISTEMA VALUES('"+User+"','"+Senha+ "','" + ID_Posto + "') ";
                        Command.ExecuteNonQuery();
                        #endregion

                        #region Inserir dados na tabela Valor
                        /*Pega a data local para inserir na tabela*/
                        DateTime Data = DateTime.Now;

                        /*Comandos para inserir na tabela Valor*/
                        /*Como os valores da coluna no banco é DECIMAL. É feito a mutiplicação por 10, para mostar o valor é feito a divisão de 10*/
                        Command.CommandText = "INSERT INTO VALOR VALUES(0,'"+ID_Posto + "','"+comb1+ "','" + Data.ToString("yyyy-MM-dd H:mm:ss") + "','" + (ValorComb1*10)+ "')";
                        Command.ExecuteNonQuery();

                        Command.CommandText = "INSERT INTO VALOR VALUES(0,'" +ID_Posto + "','" +comb2 + "','" + Data.ToString("yyyy-MM-dd H:mm:ss") + "','" +(ValorComb2*10)+ "')";
                        Command.ExecuteNonQuery();

                        Command.CommandText = "INSERT INTO VALOR VALUES(0,'" +ID_Posto + "','" +comb3+ "','" + Data.ToString("yyyy-MM-dd H:mm:ss") + "','" +(ValorComb3*10)+ "')";
                        Command.ExecuteNonQuery();
                        #endregion

                        Cadastrar = true;
                        conectar.Close();
                    }
                    catch (Exception erro)
                    {
                        Cadastrar = false;
                        StringBuilder str = new StringBuilder();
                        str.AppendLine(erro.Message);
                        str.AppendLine("\n");
                        str.AppendLine(erro.StackTrace);
                        messageErro = str.ToString();
                        conectar.Close();//Fecha a conexão
                    }
                 
                }
                else
                {
                    Cadastrar = false;
                    messageErro = ("Erro:Dados de Cadastro vazios ou faltando\nVerifique os campos");
                    conectar.Close();
                }
            }
            /*Trata erros do Banco*/
            catch (MySqlException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.Append(erro.SqlState);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                messageErro = str.ToString();
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                messageErro = str.ToString();
            }

           
        }


        public void updatePCadastro()
        {
            //Colocar coisas para atualzar o cadastro do posto
        }
        #endregion
    }
}
