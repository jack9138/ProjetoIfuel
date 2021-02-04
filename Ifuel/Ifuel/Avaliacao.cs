using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Avaliacao
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";
        #region Declaração de Variaveis
        /*Dados da avaliação*/
        public string Comentario = null;
        public string NomePosto = null;
        public string Nota = null;
        public DateTime DataAva; //Data que foi feita a avaliação
        private string Data;//Data para montar lista das avalições
        /*****************/

        /*Outras Variaveis*/
        public string messageErro = null;
        public bool Avaliou = false;
        public int numPosto = 0;
        string Avaliacoes = null;
        public StringBuilder ListaAvali;
        /*****************/
        #endregion

        #region Construtor
        /*Construtor Avaliacao*/
        public Avaliacao(string comentario, string nomePosto, string nota, DateTime dataAva)
        {
            Comentario = comentario;
            NomePosto = nomePosto;
            Nota = nota;
            DataAva = dataAva;
        }
        public Avaliacao()
        {

        }
        #endregion


        #region Métodos
        /*Responsavel por guardar os dados no Banco*/
        public void setAvaliacao()
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();
                try
                {
                    if (!string.IsNullOrEmpty(NomePosto) || !string.IsNullOrEmpty(Comentario))
                    {
                        /*Comandos e conexões*/
                        Command.Connection = conectar;
                        Command.CommandType = CommandType.Text;

                        /*Seleciona o ID do posto para colocar na tabela de Avaliação*/
                        Command.CommandText = "SELECT ID_POSTO FROM POSTO WHERE NOME_POSTO = '"+ NomePosto + "'";
                        int Id_posto = (int)Command.ExecuteScalar();

                        /*Pega a data atual e salva na tabela*/
                        DateTime Data = DateTime.Now;
                        /*Comando de insert na tabela de avalliação*///Testar modificação feita no número 1
                        Command.CommandText = "INSERT INTO AVALIACAO VALUES(0,'"+Data.ToString("yyyy-MM-dd H:mm:ss") +"', '"+int.Parse(Nota)+"','"+Comentario+"','"+Id_posto+"')";
                        Command.ExecuteNonQuery();
                        Avaliou = true;
                    }
                    else
                    {
                        Avaliou = false;

                    }

                     
                }
                catch (Exception erro)
                {
                   
                    StringBuilder str = new StringBuilder();
                    str.AppendLine(erro.Message);
                    str.AppendLine("\n");
                    str.AppendLine(erro.StackTrace);
                    messageErro = str.ToString();
                    conectar.Close();//Fecha a conexão
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

        /*Responsavel por buscar os dados*/
        public void getAvaliacao(string DataIni, string DataFim, int numPosto)
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
                    if (!string.IsNullOrEmpty(DataIni) || numPosto != 0)
                    {

                        if (!string.IsNullOrEmpty(DataFim)) 
                        {
                            DateTime dataIni = Convert.ToDateTime(DataIni);
                            DateTime dataFim = Convert.ToDateTime(DataFim);
                            StringBuilder ResulAv = new StringBuilder();

                            /*Seleciona a nota*/
                            Command.CommandText = "SELECT DATA_AV, NOTA_AV,COMENT_AV FROM AVALIACAO WHERE ID_POSTO = '" + numPosto + "' AND DATA_AV BETWEEN'"+dataIni.ToString("yyyy-MM-dd H:mm:ss") + "'AND '"+dataFim.ToString("yyyy-MM-dd H:mm:ss")+ "' ";

                            dataAdapter = new MySqlDataAdapter(Command);
                            //Estrutura da tabela 
                            DataTable objDataTable = new DataTable();
                            //Preencher com a estrutura do select enviado
                            dataAdapter.Fill(objDataTable);

                            //Cria lista de resultado
                            ListaAvali = new StringBuilder();
                            Avaliacao av = new Avaliacao();
                            //Percorrer as linhas do datatable para adicionar na lista 
                            foreach (DataRow dataRow in objDataTable.Rows)
                            {
                                //Adiciona na lista Especificando a clouna 
                                av.Data = dataRow["DATA_AV"].ToString();
                                av.Nota = dataRow["NOTA_AV"].ToString();
                                av.Comentario = dataRow["COMENT_AV"].ToString();


                                /*Gerar uma string com todas os valores e Postos em order crescentee: Do menor ate o maior valor*/
                                ListaAvali.Append("--------------------------------------" + "\n");
                                ListaAvali.Append(" Data da Avaliação : " + DateTime.Parse(av.Data).ToString("yyyy-MM-dd H:mm:ss"));
                                ListaAvali.Append(" Nota : " + int.Parse(av.Nota) + "\n");
                                ListaAvali.Append(" Comentario: " + av.Comentario.ToString());
                                ListaAvali.Append("\n" + "--------------------------------------" + "\n");

                            }
                            ListaAvali.ToString();
                        }
                        else
                        {
                            DateTime dataIni = Convert.ToDateTime(DataIni);
                            DateTime dataFim = DateTime.Now;
                            StringBuilder ResulAv = new StringBuilder();
                            /*Seleciona a nota*/
                            Command.CommandText = "SELECT DATA_AV, NOTA_AV,COMENT_AV FROM AVALIACAO WHERE ID_POSTO = '" + numPosto + "' AND DATA_AV BETWEEN '" + dataIni.ToString("yyyy-MM-dd H:mm:ss") + "' AND '" + dataFim.ToString("yyyy-MM-dd H:mm:ss") + "' ";
                           

                            dataAdapter = new MySqlDataAdapter(Command);
                            //Estrutura da tabela 
                            DataTable objDataTable = new DataTable();
                            //Preencher com a estrutura do select enviado
                            dataAdapter.Fill(objDataTable);

                            //Cria lista de resultado
                            ListaAvali  = new StringBuilder();
                            Avaliacao av = new Avaliacao();
                            //Percorrer as linhas do datatable para adicionar na lista 
                            foreach (DataRow dataRow in objDataTable.Rows)
                            {
                                //Adiciona na lista Especificando a clouna 
                                av.Data = dataRow["DATA_AV"].ToString() ;
                                av.Nota = dataRow["NOTA_AV"].ToString();
                                av.Comentario = dataRow["COMENT_AV"].ToString();
                                

                                /*Gerar uma string com todas os valores e Postos em order crescentee: Do menor ate o maior valor*/
                                ListaAvali.Append("--------------------------------------" + "\n");
                                ListaAvali.Append(" Data da Avaliação : " + DateTime.Parse(av.Data).ToString("yyyy-MM-dd H:mm:ss"));
                                ListaAvali.Append(" Nota :"  + int.Parse(av.Nota) + "\n");
                                ListaAvali.Append(" Comentario: " + av.Comentario.ToString() );
                                ListaAvali.Append("\n" + "--------------------------------------" + "\n");

                            }
                            ListaAvali.ToString();


                        }

                    }
                    else
                    {
                        messageErro = ("Data de inicio vazia\nVerifique os campos");
                    }
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

        public override string ToString()
        {
            return Avaliacoes;
        }
        #endregion
    }
}
