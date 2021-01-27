using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Login
    {
        /*String para conectar no Banco*/
        string connectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=ifuel";

        /*Para confirmar login*/
        public bool Logar = false;
        int ConfLogin = 0;

        public void getLoginPosto(string Cnpj, string Senha) 
        {
           
            try
            {

                string sql = "(SELECT (LOGIN_USR) FROM POSTOSISTEMA WHERE  LOGIN_USR = @Cnpj  AND  SENHA_USR = @Senha  )";
                MySqlConnection conectar = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, conectar);
                cmd.Parameters.Add("@Cnpj", MySqlDbType.VarChar).Value = Cnpj;
                cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;

                conectar.Open();

                ConfLogin = (int)cmd.ExecuteScalar();

                if (ConfLogin > 0)
                {
                    Logar = true;
                }
                else
                {
                    Logar = false;
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
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                str.ToString();
            }
        }

        public void getLoginUser(string Email, string Senha)
        {

            try
            {

                string sql = "(SELECT (LOGIN_USR) FROM POSTOSISTEMA WHERE  LOGIN_USR = @Email  AND  SENHA_USR = @Senha  )";
                MySqlConnection conectar = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, conectar);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = Senha;

                conectar.Open();

                ConfLogin = (int)cmd.ExecuteScalar();

                if (ConfLogin > 0)
                {
                    Logar = true;
                }
                else
                {
                    Logar = false;
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
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                str.ToString();
            }
        }

    }
}
