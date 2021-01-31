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
       
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";
        
        #region Variáveis
        public double Valor = 0;
        public string Cidade = null;
        public string Bairro = null;
        public string Combustivel = null;
        #endregion

        #region Construtor
        public PesquisarValor( string cidade, string bairro, string combustivel)
        {
            Cidade = cidade;
            Bairro = bairro;
            Combustivel = combustivel;
        }
        #endregion

        #region Métodos
        public void getValor()
        {
            MySqlConnection conectar = new MySqlConnection(connectionString) ;
            conectar.Open(); 
            string selectValor = @"(SELECT P.NOME_POSTO,P.CIDADE_POSTO,P.BAIRRO_POSTO,P.RUA_POSTO,C.NOME_COMB,V.COMB_VALOR 
                                        FROM VALOR AS V
                                         INNER JOIN POSTO  AS P ON P.ID_POSTO = V.ID_POSTO 
                                            INNER JOIN COMBUSTIVEL AS C ON C.COD_COMB = V.COD_COMB
                                                WHERE P.CIDADE_POSTO @Cidade AND P.BAIRRO_POSTO @Bairro)";

            MySqlCommand comand = new MySqlCommand(selectValor);
            comand.CommandType = CommandType.Text;

            MySqlDataReader reader;
            reader = comand.ExecuteReader();
            reader.Read();

            //Aqui precisa receber os valores do select e guardar para mostar na tela;
        }

        #endregion
    }
}
