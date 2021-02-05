using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ifuel
{
    class PesquisarValor
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        #region Variáveis
        /*Variaveis de busca*/
        public double Valor = 0;
        public string Cidade = null;
        public string Bairro = null;
        public string Combustivel = null;
        /***************************/

        /*Outras variaveis*/
        public string message = null;
        public StringBuilder resultValor;
        /***************/
        #endregion

        #region Construtor
        public PesquisarValor(string cidade, string bairro, string combustivel)
        {
            Cidade = cidade.ToUpper();
            Bairro = bairro.ToUpper();
            Combustivel = combustivel;//Vai receber o combustivel selecionado
        }
        #endregion

        #region Métodos
        public void getValor()
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                MySqlDataAdapter dataAdapter;
                conectar = new MySqlConnection(connectionString);
                conectar.Open();

                try
                {
                    /*Comandos e conexões*/
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;
                    if (!string.IsNullOrEmpty(Cidade) || !string.IsNullOrEmpty(Bairro) || !string.IsNullOrEmpty(Combustivel))
                    {

                        Command.CommandText = "SELECT P.NOME_POSTO,P.CIDADE_POSTO,P.BAIRRO_POSTO,P.RUA_POSTO,C.NOME_COMB,V.COMB_VALOR "
                                           + " FROM VALOR AS V INNER JOIN POSTO  AS P ON P.ID_POSTO = V.ID_POSTO "
                                             + "INNER JOIN COMBUSTIVEL AS C ON C.COD_COMB = V.COD_COMB"
                                             + " WHERE P.CIDADE_POSTO LIKE'%"+Cidade+"%' AND P.BAIRRO_POSTO LIKE'%"+Bairro+ "%' ORDER BY V.COMB_VALOR ASC";
                        dataAdapter = new MySqlDataAdapter(Command);
                        //Estrutura da tabela 
                        DataTable objDataTable = new DataTable();
                        //Preencher com a estrutura do select enviado
                        dataAdapter.Fill(objDataTable);

                        //Cria lista de resultado
                        resultValor = new StringBuilder();
                        Valor rValor = new Valor(); 
                        //Percorrer as linhas do datatable para adicionar na lista 
                        foreach (DataRow dataRow in objDataTable.Rows)
                        {
                            //Adiciona na lista Especificando a clouna 
                            rValor.NomeP = dataRow["NOME_POSTO"].ToString();
                            rValor.CidadeP = dataRow["CIDADE_POSTO"].ToString();
                            rValor.BairroP = dataRow["BAIRRO_POSTO"].ToString();
                            rValor.RuaP = dataRow["RUA_POSTO"].ToString();
                            rValor.NomeComb = dataRow["NOME_COMB"].ToString();
                            rValor.ValorC = (double.Parse(dataRow["COMB_VALOR"].ToString())/10);

                            /*Gerar uma string com todas os valores e Postos em order crescentee: Do menor ate o maior valor*/
                            resultValor.Append("  Posto :" + rValor.NomeP + "\n");
                            resultValor.Append("  Cidade:" + rValor.CidadeP + "\n");
                            resultValor.Append("  Bairro: " + rValor.BairroP + "\n");
                            resultValor.Append("  Rua: " + rValor.RuaP + "\n");
                            resultValor.Append("  Combustível: " + rValor.NomeComb + "\n");
                            resultValor.Append("  Valor R$ ");
                            resultValor.AppendFormat("{0,1:C}", rValor.ValorC);
                            resultValor.Append("\n");
                            resultValor.Append("\n"+"--------------------------------------" +"\n");
                            
                        }
                        resultValor.ToString();
                    }
                    else
                    {
                        message = "Dados inválidos, vaerifique os campos!";
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
        #endregion
    }
}
