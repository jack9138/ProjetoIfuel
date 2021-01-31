using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Avaliacao
    {
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";
        //string conect = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";
        #region Declaração de Variaveis
        /*Dados da avaliação*/
        public string Comentario = null;
       public string NomePosto = null;
       public int Nota = 0;
       public  DateTime DataAva;
       public int numPosto;
        /*****************/

        /*Outras Variaveis*/
        public string messageErro = null;
        /*****************/
        #endregion

        #region Construtor
        /*Construtor Avaliacao*/
        public Avaliacao(string comentario, string nomePosto, int nota, DateTime dataAva)
        {
            Comentario = comentario;
            NomePosto = nomePosto;
            Nota = nota;
            DataAva = dataAva;
        }
        #endregion


        #region Métodos
        /*Responsavel por guardar os dados no Banco*/
        public  void setAvaliacao()
        {
            try
            {
                /*Método para verificar dados e salvar no banco*/
                conectar = new MySqlConnection(connectionString);
                int numPosto;
                MySqlDataAdapter select_adapter = new MySqlDataAdapter();
                string selectIdP = "(SELECT ID_POSTO FROM POSTO WHERE NOME_COMB  " + NomePosto+ ")";
                select_adapter.SelectCommand = new MySqlCommand(selectIdP,conectar);
                select_adapter.SelectCommand.Parameters.Add("@NomePosto", MySqlDbType.VarChar).Value = NomePosto.ToUpper();
                numPosto = int.Parse(selectIdP);

                MySqlDataAdapter insert_adapter = new MySqlDataAdapter();
                string insertAv = "(INSERT INTO AVALIACAO (DATA_AV,NOTA_AV, COMENT_AV,ID_POSTO) "
                                    +"VALUES(@DataAva, @Comentario, @Nota,@numPosto))";
                insert_adapter.InsertCommand = new MySqlCommand(insertAv,conectar);
                insert_adapter.InsertCommand.Parameters.Add("@DataAva", MySqlDbType.DateTime).Value = DataAva;
                insert_adapter.InsertCommand.Parameters.Add("@Comentario", MySqlDbType.VarChar).Value = Comentario;
                insert_adapter.InsertCommand.Parameters.Add("@Nota", MySqlDbType.DateTime).Value = Nota;
                insert_adapter.InsertCommand.Parameters.Add("@numPosto", MySqlDbType.DateTime).Value = numPosto;

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
        public void getAvaliacao()
        {
            try
            {
                /*Método para verificar dados e salvar no banco*/
                conectar = new MySqlConnection(connectionString);
                MySqlDataAdapter select_adapter = new MySqlDataAdapter();
                

                /*Seleciona a nota*/
                string selectN = "(SELECT NOTA_AV FROM AVALIACAO WHERE ID_POSTO = " + numPosto+ ")";
                select_adapter.SelectCommand = new MySqlCommand(selectN, conectar);
                int nota = int.Parse(selectN);


                /*Seleciona o comentario*/
                string selectC = "(SELECT COMENT_AV, ID_POSTO FROM AVALIACAO WHERE ID_POSTO = " + numPosto + ")";
                select_adapter.SelectCommand = new MySqlCommand(selectC, conectar);
                string comentario = selectC;
                /*Seleciona a Data do comentario*/
                string selectD = "(SELECT DATA_AV FROM AVALIACAO WHERE ID_POSTO = " + numPosto + ")";
                select_adapter.SelectCommand = new MySqlCommand(selectD, conectar);
                DateTime dataAva = DateTime.Parse(selectD);

              

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
