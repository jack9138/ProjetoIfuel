using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Ifuel
{
    class CadastroU
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=127.0.0.1;UserId=root;Password=Dev@9138;Database=IFUEL";
        #region Declaração de variáveis
        /*Dados cadastro do Usuário*/
        string NomeUser;
        string CPF;
        string Email;     
        string Senha;
        /**************************/

        /*Dados do Endereço*/
        string Cidade;
        string Bairro;
        /*******************/

        /*Outras variaveis*/
        private int ID_Cliente = 0;
        public string messageErro = null;
        public bool Cadastrar = false;
        /**********************/
        #endregion


        #region Contrutor
        /*Construtor: Usuário*/
        public CadastroU(string NomeUser, string CPF, string Email, string Senha, string Cidade, string Bairro)
        {
            this.NomeUser = NomeUser;
            this.CPF = CPF;
            this.Email = Email;          
            this.Senha = Senha;       
            this.Cidade = Cidade;
            this.Bairro = Bairro;
        }

        #endregion

        #region  Métodos
        public void setCadastroU()
        {
            
            try
            {
                conectar = new MySqlConnection(connectionString);
                if (!string.IsNullOrEmpty(NomeUser) || !string.IsNullOrEmpty(Email) || !string.IsNullOrEmpty(CPF)) 
                {
                    #region Inserir dados na Tabela Cliente
                    /*String para inserir cadastro na tabela Cliente*/
                    string sqlCadastro = "(INSERT INTO CLIENTE(NOME_CLIENTE,Email_Cliente,CPF,Bairro,CIDADE)" +
                                        "VALUES (@NomeUser, @Email,@CPF,@Bairro,@Cidade) )";
                    MySqlCommand insertCad = new MySqlCommand(sqlCadastro, conectar);//Comando para inserir cadastro
                    insertCad.Parameters.Add("@NomeUser", MySqlDbType.VarChar).Value = NomeUser;
                    insertCad.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = CPF;
                    insertCad.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                    insertCad.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = Bairro;
                    insertCad.Parameters.Add("@Cidade", MySqlDbType.VarChar).Value = Cidade;
                    #endregion

                    #region Inserir dados na tabela Usersistema

                    /*Select para buscar o ID do Cliente cadastrado */
                    string sqlSelectId = "(SELECT LAST_INSTER_ID() FROM POSTO)";
                    MySqlCommand comandSelect = new MySqlCommand(sqlSelectId, conectar);
                    ID_Cliente = Convert.ToInt32(comandSelect);

                    string sqlLogin = "( INSERT INTO POSTOSISTEMA(ID_USR, LOGIN_USR, SENHA_USR)" +
                                                 "VALUES(@ID_Cliente,@Email,@Senha) ";
                    MySqlCommand insertLogin = new MySqlCommand(sqlLogin, conectar);
                    insertLogin.Parameters.Add("@ID_POSTO", MySqlDbType.Int64).Value = ID_Cliente;
                    insertLogin.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                    insertLogin.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;
                    #endregion

                   
                }
                else
                {
                    Cadastrar = false;
                }

                Cadastrar = true;
            }

            /*Trata erros do Banco*/
            catch (MySqlException erro)
            {
                Cadastrar = false;
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
                Cadastrar = false;
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
