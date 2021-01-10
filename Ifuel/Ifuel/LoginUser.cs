using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ifuel;
using Microsoft.SqlServer;
using MySqlConnector;

namespace Ifuel
{
    public partial class LoginUser : Form
    {
        /*Conexão do Banco*/
       // string connectionString = @"Server= localhost;Initial Catalog= IFUEL;Integrated Security=True;";
      
        public LoginUser()
        {
            InitializeComponent();
        }

        /*Botão para fazer LoginUser*/
        private void btnLogar_Click(object sender, EventArgs e)
        {
            /*Deve chamar um método que busca o usuário no Banco e trata qualquer execeção*/
            // Close();
            MenuUser menuUser = new MenuUser();
            menuUser.Show();
            Hide();
            #region Código de Teste não considerar


            //string user = textUser.ToString(); /*Convert o textbox User em string para verificação*/
            //string senha = textSenha.ToString();/*Convert a senha em string para verificação*/

            /*Verifica se o usuário preenchue os campos*/
            // if (user == " " && senha == " " || user == " " || senha == " ")
            //{
            //  MessageBox.Show("Dados não preenchidos");
            //}
            //else
            // {
            // string sql = "(SELECT * FROM USERPOSTO WHERE LoginUser_USR = '" + textUser + "' AND SENHA_USR'" + textSenha + ")";

            /*Verifica os dados e tenta realizar a leitura dos dados de LoginUser*/
            //  MySqlConnection conect = new MySqlConnection(connectionString);
            // MySqlCommand cmd = new MySqlCommand(sql, conect);

            //   cmd.CommandType = CommandType.Text;
            //  MySqlDataReader reader;
            //  conect.Open();

            //  reader = cmd.ExecuteReader();
            // try
            // {
            //     if (!reader.Read())
            //     {
            //        MessageBox.Show("Login ou Senha Incorretos !");
            //    }
            //   else
            //   {
            //      this.Hide();

            //         //Menu do Posto, falta criar 

            //   }
            //}
            // catch (Exception ex)
            // {
            //   MessageBox.Show("Erro: " + ex.ToString());
            // }
            // }
            #endregion

        }

        /*Botão para fazer Voltar a Tela Inicial*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {

            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Hide();
        }

        /*Botão para fazer Cadastro*/
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadUsuario cadastro = new CadUsuario();
            cadastro.Show();
            Hide();
            //Close(); //Falta criar tela de cadastro para usuário
        }

        private void linkPerdaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Criar método para enviar senha do usuário no email e mostrar mensagem que foi enviado. 
        }
    }
}
