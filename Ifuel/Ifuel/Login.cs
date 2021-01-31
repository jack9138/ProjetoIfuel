using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Login
    {
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        /*Para confirmar login*/
        public bool Logar = false;
        int ConfLogin = 0;

        /*Outras variaveis*/
        public string message = null;
        /***************/
        public void getLoginPosto(string User, string Senha) 
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
                    if (!string.IsNullOrEmpty(User) || !string.IsNullOrEmpty(Senha))
                    {
                        Command.CommandText = "SELECT ID_USR FROM POSTOSISTEMA WHERE  LOGIN_USR = '" + User + "'  AND  SENHA_USR = '" + Senha + "'";

                        ConfLogin = (int)Command.ExecuteScalar();

                        if (ConfLogin > 0)
                        {
                            Logar = true;
                        }
                        else
                        {
                            Logar = false;
                        }
                    }
                    else
                    {
                        Logar = false;
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

        public void getLoginUser(string Email, string Senha)
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
                    if (!string.IsNullOrEmpty(Email) || !string.IsNullOrEmpty(Senha))
                    {
                        Command.CommandText = "SELECT ID_USR FROM USERSISTEMA WHERE  LOGIN_USR = '" + Email+ "'  AND  SENHA_USR = '" +Senha+ "'";

                        ConfLogin = (int)Command.ExecuteScalar();

                        if (ConfLogin > 0)
                        {
                            Logar = true;
                        }
                        else
                        {
                            Logar = false;
                        }
                    }
                    else
                    {
                        Logar = false;
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

    }
}
