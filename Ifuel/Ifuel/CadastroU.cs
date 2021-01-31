using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Ifuel
{
    class CadastroU
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";
        
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
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();
                if (!string.IsNullOrEmpty(NomeUser) || !string.IsNullOrEmpty(Email) || !string.IsNullOrEmpty(CPF)) 
                {
                    #region Inserir dados na Tabela Cliente
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;
                    /*String para inserir cadastro na tabela Cliente*/
                    Command.CommandText = "INSERT INTO CLIENTE VALUES ( 0,'"+NomeUser+"','"+Email+ "','" + CPF + "','" + Bairro+ "','"+Cidade+"')";
                    Command.ExecuteNonQuery();
                    
                    #endregion

                    #region Inserir dados na tabela Usersistema

                    /*Select para buscar o ID do Cliente cadastrado */
                    
                    Command.CommandText= "SELECT MAX(ID_CLIENTE) FROM CLIENTE;";
                    int Id = (int)Command.ExecuteScalar();

                    /*Inserir dados na tabela USERSISTEMA */
                    Command.CommandText = "INSERT INTO USERSISTEMA VALUES('" + Email + "','" + Senha + "','" + Id+"')";
                    Command.ExecuteNonQuery();
                    #endregion

                    conectar.Close();
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

                conectar.Close();
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
