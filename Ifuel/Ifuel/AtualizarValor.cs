using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class AtualizarValor
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        #region Variaveis
        string Comb = null;
        double Nvalor = 0.0;
        public int ID_POSTO = 0; 

        /*Outras Variaveis*/
        public string messageErro;
        public bool Atualizou = false;
        /*************/
        #endregion

        #region Construtor
        public AtualizarValor(string comb, double nvalor, int Id_posto)
        {
            Comb = comb;
            Nvalor = nvalor;
            ID_POSTO = Id_posto;
        }

       
        #endregion

        #region Métodos
        public void setNValor()
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

                    /*Selects para pegar os nomes dos combustiveis e salvar na tabela do POSTO.*/
                    Command.CommandText = "SELECT COD_COMB FROM COMBUSTIVEL WHERE NOME_COMB = '" + Comb + "'";
                    int comb1 = (int)Command.ExecuteScalar();


                    /*Pega a data e hora do dia que esta sendo atualizado*/
                    DateTime Data = DateTime.Now;
                    /*Comandos para inserir na tabela Valor*/
                    /*Como os valores da coluna no banco é DECIMAL. É feito a mutiplicação por 10, para mostar o valor é feito a divisão de 10*/
                    Command.CommandText = "UPDATE VALOR SET COMB_VALOR = '" + Nvalor + "' AND DATA_VALOR = '" + Data.ToString("yyyy-MM-dd H:mm:ss") + "'  WHERE ID_POSTO = '" + ID_POSTO + "' AND COD_COMB = '" + (comb1*10) + "';";
                    Command.ExecuteNonQuery();

                    Atualizou = true;
                }
                catch (Exception erro)
                {
                    Atualizou = false;
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

        #endregion
    }
}
