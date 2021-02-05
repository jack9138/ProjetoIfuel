using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class AtualizarCadUs
    {

        /*String para conectar no Banco*/
        MySqlConnection conectar;
        MySqlDataAdapter dataAdapter;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        /*Variaveis*/
        public string NomeUser;
        public string CPF;
        public string Email;
        public string Cemail;
        public string Bairro;
        public string Cidade;
        public string message;
        public bool Atualizou = false;
        /*******************/

        

        public void getCadastro(int Id_Usr)
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();
                try
                {
                    /*Comandos e conexões*/
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;
                    if (Id_Usr <= 0)
                    {
                        Command.CommandText = "SELECT NOME_CLIENTE, EMAIL_CLIENTE, CPF,BAIRRO, CIDADE FROM CLIENTE WHERE ID_CLIENTE = '" + Id_Usr + "';";
                        dataAdapter = new MySqlDataAdapter(Command);
                        //Estrutura da tabela 
                        DataTable objDataTable = new DataTable();
                        //Preencher com a estrutura do select enviado
                        dataAdapter.Fill(objDataTable);

                        AtualizarCadUs atualizar = new AtualizarCadUs();
                        //Percorrer as linhas do datatable para adicionar na lista 
                        foreach (DataRow dataRow in objDataTable.Rows)
                        {
                            //Adiciona na lista Especificando a clouna 
                            atualizar.NomeUser = dataRow["NOME_CLIENTE"].ToString();
                            atualizar.CPF = dataRow["CPF"].ToString();
                            atualizar.Cidade = dataRow["CIDADE_CLIENTE"].ToString();
                            atualizar.Email = dataRow["EMAIL_CLIENTE"].ToString();
                            atualizar.Bairro = dataRow["BAIRRO"].ToString();


                        }
                    }
                    conectar.Close();
                }
                /*Trata erros do Banco*/
                catch (MySqlException erro)
                {
                    StringBuilder str = new StringBuilder();
                    str.AppendLine(erro.Message);
                    str.Append(erro.SqlState);
                    str.AppendLine("\n");
                    str.AppendLine(erro.StackTrace);
                    message = str.ToString();
                }

                /*Trata erro do Programa*/
                catch (IfuelException erro)
                {
                    StringBuilder str = new StringBuilder();
                    str.AppendLine(erro.Message);
                    str.AppendLine("\n");
                    str.AppendLine(erro.StackTrace);
                    str.ToString();
                    message = str.ToString();
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
                message = str.ToString();
            }
        }


        public void upCadastro(int Id_Usr)
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();
                if (Id_Usr <= 0)
                {
                    #region Inserir dados na Tabela Cliente
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;

                    /*Atualizar dados na tabela Cliente */
                    Command.CommandText = "UPDATE CLIENTE SET NOME_CLIENTE = '" + NomeUser + "'  AND EMAIL_CLIENTE = '" + Email + "' AND BAIRRO = '" + Bairro + "' AND CIDADE = '" + Cidade + "' WHERE ID_CLIENTE = '" + Id_Usr + "'; ";
                    Command.ExecuteNonQuery();
                    #endregion

                    conectar.Close();
                }
                else
                {
                    Atualizou = false;
                }

                Atualizou = true;
            }

            /*Trata erros do Banco*/
            catch (MySqlException erro)
            {
               
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.Append(erro.SqlState);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                message = str.ToString();

                conectar.Close();
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
               
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                message = str.ToString();
            }
        }



    }
}
