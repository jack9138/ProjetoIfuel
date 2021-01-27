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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ifuel
{
    public partial class LoginUser : Form
    {
       

        public LoginUser()
        {
            InitializeComponent();
        }

        /*Botão para fazer LoginUser*/
        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                Login loginU = new Login();
                if (loginU.Logar == true)
                {
                    MenuUser menuUser = new MenuUser();
                    menuUser.Show();
                    Hide();
                }
                else if (loginU.Logar == false)
                {
                    MessageBox.Show("Erro Login\nVerificar campos");
                }
            }/*Trata erros do Banco*/
            catch (MySqlException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.Append(erro.SqlState);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);

                MessageBox.Show(str.ToString());
            }

            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                str.ToString();
                MessageBox.Show(str.ToString());
            }

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

        }

        private void linkPerdaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Ver melhor opção para tela de troca de senha
        }
    }
}
