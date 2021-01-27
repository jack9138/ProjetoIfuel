using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class CadastroP
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=127.0.0.1;UserId=root;Password=Dev@9138;Database=IFUEL";
        //@"Server=127.0.0.1;UserId=root;Password=Dev@9138;Database=IFUEL"

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
        string Cep = null;
        string Endereco = null;
        /*******************/

        /*Dados do combustivel*/
        public string NomeComb1 = null;//Recebe os dados do Form
        public string NomeComb2 = null;
        public string NomeComb3 = null;
        public double  ValorComb1 = 0.0;//Recebe os dados de valor do Form
        public double  ValorComb2 = 0.0;//Recebe os dados de valor do Form
        public double ValorComb3 = 0.0;//Recebe os dados de valor do Form
        /*********************/

        /*Variaveis Adicionas*/
        public bool Cadastrar = true;
        public bool Termo =false;
        public int ID_Comb1 = 0;//Recebe os ID's da tabela=Combustivel
        public int ID_Comb2 = 0;
        public int ID_Comb3 = 0;
        private int ID_Posto = 0;
        public string messageErro = null;
        /*************************/

        #endregion
        #region Contrutor
        public CadastroP(string NomePosto, string Cnpj, string Alvara, string Estado, string Cidade, string Bairro, string Cep, string Endereco, string NomeComb1, string NomeComb2, string NomeComb3, double ValorComb1,double ValorComb2, double ValorComb3, bool  Termo)
        {

            this.NomePosto = NomePosto;
            this.Cnpj = Cnpj;
            this.Alvara = Alvara;
            this.Estado = Estado;
            this.Cidade = Cidade;
            this.Bairro = Bairro;
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
                 conectar = new MySqlConnection(connectionString);

                if (!string.IsNullOrEmpty(NomePosto) || !string.IsNullOrEmpty(Cnpj) || !string.IsNullOrEmpty(Alvara) || !string.IsNullOrEmpty(Estado) || !string.IsNullOrEmpty(Cidade) || !string.IsNullOrEmpty(Bairro) || !string.IsNullOrEmpty(Cep) || !string.IsNullOrEmpty(Endereco) || !Termo)
                {
                    //Se cadastrar igual falso, tenta cadastrar. Se for verdadeiro não tenta cadastrar
                    try
                    {
                        #region Inserir dados na Tabela Posto
                        /*String para inserir cadastro na tabela POSTO*/
                        string sqlCadastro = "(INSERT INTO POSTO (NOME_POSTO,CNPJ_POSTO,UF_POSTO,CIDADE_POSTO,RUA_POSTO,BAIRRO_POSTO,CEP_POSTO)" +  //,COMBUSTIVEL1_POSTO,COMBUSTIVEL2_POSTO,COMBUSTIVEL3_POSTO
                                            "VALUES (@NomePosto, @Cnpj, @ESTADO,@Cidade,@Endereco,@Bairro,@Cep) )"; //,@Comb1,@Comb2,@Comb3
                        MySqlCommand insertCad = new MySqlCommand(sqlCadastro, conectar);//Comando para inserir cadastro
                        insertCad.Parameters.Add("@NomePosto", MySqlDbType.VarChar).Value = NomePosto;
                        insertCad.Parameters.Add("@Cpnj", MySqlDbType.VarChar).Value = Cnpj;
                        insertCad.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = Estado;
                        insertCad.Parameters.Add("@Cidade", MySqlDbType.VarChar).Value = Cidade;
                        insertCad.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = Bairro;
                        insertCad.Parameters.Add("@Cep", MySqlDbType.VarChar).Value = Cep;
                        #endregion 

                        #region Selects de dados
                        /*Select para pegar os nomes dos combustiveis e salvar na tabela do POSTO.*/
                        //Verificar erro que ocorre nessa parte->Talvez trocar e colocar a parte de select com uma lista. 
                        string selectComb1 = "(SELECT ID_COMB FROM COMBUSTIVEL WHERE NOME_COMB = " + NomeComb1 + ")";
                        ID_Comb1 = int.Parse(selectComb1);
                        insertCad.Parameters.Add("@Comb1", MySqlDbType.Int64).Value = ID_Comb1;


                        string selectComb2 = "(SELECT ID_COMB FROM COMBUSTIVEL WHERE NOME_COMB = " + NomeComb2 + ")";
                        ID_Comb2 = int.Parse(selectComb2);
                        insertCad.Parameters.Add("@Comb2", MySqlDbType.Int64).Value = ID_Comb2;


                        string selectComb3 = "(SELECT ID_COMB FROM COMBUSTIVEL WHERE NOME_COMB = " + NomeComb3 + ")";
                        ID_Comb3 = int.Parse(selectComb3);
                        insertCad.Parameters.Add("@Comb3", MySqlDbType.Int64).Value = ID_Comb3;


                        /*Select para buscar o ID do POSTO */
                        string sqlSelectId = "(SELECT LAST_INSTER_ID() FROM POSTO)";
                        MySqlCommand comandSelect = new MySqlCommand(sqlSelectId, conectar);
                        ID_Posto = Convert.ToInt32(comandSelect);
                        #endregion

                        #region Inserir dados na Tabela POSTOSISTEMA
                        /*String para inserir na Tabela POSTOSISTEMA -> OBS:Usuário e senha do Posto é  CNPJ dele*/
                        string sqlLogin = "( INSERT INTO POSTOSISTEMA(ID_USR, LOGIN_USR, SENHA_USR)" +
                                              "VALUES(@ID_Posto,@Cnpj,@Cnpj) ";
                        MySqlCommand insertLogin = new MySqlCommand(sqlLogin, conectar);
                        insertLogin.Parameters.Add("@ID_POSTO", MySqlDbType.Int64).Value = ID_Posto;
                        insertLogin.Parameters.Add("@Cnpj", MySqlDbType.VarChar).Value = Cnpj;
                        insertLogin.Parameters.Add("@Cnpj", MySqlDbType.VarChar).Value = Cnpj;
                        #endregion

                        #region Inserir dados na tabela Valor
                        /*String para inserir na tabela Valor*/
                        string sqlValor = "( INSERT INTO VALOR(ID_POSTO, NOME_COMB, DATA_VALOR, COMB_VALOR)" +
                                              "VALUES(@ID_Posto,@CodComb,@Data_Cad,@ValorComb) ";
                        MySqlCommand insertValor1 = new MySqlCommand(sqlValor, conectar);
                        insertValor1.Parameters.Add("@ID_Posto", MySqlDbType.Int64).Value = ID_Posto;
                        insertValor1.Parameters.Add("@CodComb", MySqlDbType.Int64).Value = ID_Comb1;
                        insertValor1.Parameters.Add("@ValorComb", MySqlDbType.Decimal).Value = ValorComb1;


                        MySqlCommand insertValor2 = new MySqlCommand(sqlValor, conectar);
                        insertValor2.Parameters.Add("@ID_Posto", MySqlDbType.Int64).Value = ID_Posto;
                        insertValor2.Parameters.Add("@CodComb", MySqlDbType.Int64).Value = ID_Comb2;
                        insertValor2.Parameters.Add("@ValorComb", MySqlDbType.Decimal).Value = ValorComb2;

                        MySqlCommand insertValor3 = new MySqlCommand(sqlValor, conectar);
                        insertValor3.Parameters.Add("@ID_Posto", MySqlDbType.Int64).Value = ID_Posto;
                        insertValor3.Parameters.Add("@CodComb", MySqlDbType.Int64).Value = ID_Comb3;
                        insertValor3.Parameters.Add("@ValorComb", MySqlDbType.Decimal).Value = ValorComb3;

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
        #endregion
    }
}
