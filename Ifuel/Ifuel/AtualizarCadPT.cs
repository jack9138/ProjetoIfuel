using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class AtualizarCadPT
    {

        /*String para conectar no Banco*/
        MySqlConnection conectar;
        MySqlDataAdapter dataAdapter;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        /*Variaveis*/
        public string NomeP;
        public string CNPJ;
        public string Cidade;
        public string UF;
        public string Bairro;
        public string Cep;
        public string Rua;
        public string Alvara;
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
                        Command.CommandText = "SELECT NOME_POSTO, CNPJ_POSTO, UF_POSTO,CIDADE_POSTO,BAIRRO_POSTO, RUA_POSTO,CEP_POSTO, ALVARA FROM POSTO WHERE ID_POSTO = '" + Id_Usr + "';";
                        dataAdapter = new MySqlDataAdapter(Command);
                        //Estrutura da tabela 
                        DataTable objDataTable = new DataTable();
                        //Preencher com a estrutura do select enviado
                        dataAdapter.Fill(objDataTable);

                        AtualizarCadPT atualizar = new AtualizarCadPT();
                        //Percorrer as linhas do datatable para adicionar na lista 
                        foreach (DataRow dataRow in objDataTable.Rows)
                        {
                            //Adiciona na lista Especificando a clouna 
                            atualizar.NomeP = dataRow["NOME_POSTO"].ToString();
                            atualizar.CNPJ = dataRow["CNPJ"].ToString();
                            atualizar.Cidade = dataRow["CIDADE_POSTO"].ToString();
                            atualizar.UF = dataRow["UF_POSTO"].ToString();
                            atualizar.Bairro = dataRow["BAIRRO_POSTO"].ToString();
                            atualizar.Rua = dataRow["RUA_POSTO"].ToString();
                            atualizar.Cep = dataRow["CEP_POSTO"].ToString();
                            atualizar.Alvara = dataRow["ALVARA"].ToString();
                        }
                        Atualizou = true;
                    }
                    Atualizou = false;
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
                    Command.CommandText = "UPDATE POSTO SET NOME_POSTO = '" + NomeP + "' AND CNPJ_POSTO = '" + CNPJ + "' AND UF_POSTO = '" + UF + "' AND CIDADE_POSTO = '"+Cidade+"' AND BAIRRO_POSTO = '" + Bairro + "' AND RUA_POSTO = '" + Rua + "' AND CEP_POSTO = '" + Cep + "' AND ALVARA = '"+Alvara+"' WHERE ID_POSTO = '" + Id_Usr + "';";
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
