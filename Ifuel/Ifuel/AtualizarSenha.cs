using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class AtualizarSenha
    {
        #region Declaração de Variaveis
        /*String para conectar no Banco*/
        MySqlConnection conectar;
        string connectionString = @"Server=localhost;Port=3306;Database=ifuel;Uid=Dev;Pwd=Dev@9138;";

        /*Variaveis*/
        public string User = null;
        public string Senha = null;
        public string message = null;
        public bool Atualizou = false;
        #endregion


        #region Contrutores
        public AtualizarSenha(string user, string senha)
        {
            User = user;
            Senha = senha;
        }
        #endregion


        #region Métodos

        public void setAtualizarUser()
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();

                if (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Senha))
                {
                    /*Comandos e conexões*/
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;
                    /*Verificar se o usuário existe*/
                    Command.CommandText = "SELECT ID_USR FROM USERSISTEMA WHERE LOGIN_USR = '" + User + "';";
                    int Id_Usr = (int)Command.ExecuteScalar();


                    if (Id_Usr > 0)
                    {

                        try
                        {
                            Command.CommandText = "UPDATE USERSISTEMA SET SENHA_USR = '" + Senha+"' WHERE ID_USR = '"+Id_Usr+"'";
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
                            message = str.ToString();
                            conectar.Close();//Fecha a conexão
                        }
                    }
                    else
                    {
                        message = "Usuário não encontrado\nVerifique os campos";
                    }
                    
                }
                else
                {
                    message = "Erro ao atualizar\nVerifique os campos";
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
                message = ("Erro ao atualizar\n" + str.ToString() + "\nEntre em contato com o Administrador do Sistema");
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                message = ("Erro ao atualizar\n" + str.ToString() + "\nEntre em contato com o Administrador do Sistema");
            }

        }



        public void setAtualizarPosto()
        {
            try
            {
                /*Comandos de Conexão e banco*/
                MySqlCommand Command = new MySqlCommand();
                conectar = new MySqlConnection(connectionString);
                conectar.Open();

                if (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Senha))
                {
                    /*Comandos e conexões*/
                    Command.Connection = conectar;
                    Command.CommandType = CommandType.Text;

                    /*Verificar se o usuário existe*/
                    Command.CommandText = "SELECT ID_USR FROM POSTOSISTEMA WHERE LOGIN_USR = '" + User + "';";
                    int Id_Usr = (int)Command.ExecuteScalar();


                    if (Id_Usr > 0)
                    {

                        try
                        {
                            /*Comando para atualizar senha de usuário*/
                            Command.CommandText = "UPDATE POSTOSISTEMA SET SENHA_USR = '" + Senha + "' WHERE ID_USR = '" + Id_Usr + "'";
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
                            message = str.ToString();
                            conectar.Close();//Fecha a conexão
                        }
                    }
                    else
                    {
                        message = "Usuário não encontrado\nVerifique os campos";
                    }

                }
                else
                {
                    message = "Erro ao atualizar\nVerifique os campos";
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
                message = ("Erro ao atualizar\n" + str.ToString() + "\nEntre em contato com o Administrador do Sistema");
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                message = ("Erro ao atualizar\n" + str.ToString() + "\nEntre em contato com o Administrador do Sistema");
            }
        }
        #endregion
    }
}
