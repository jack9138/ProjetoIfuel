using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ifuel
{
    public partial class CadUsuario : Form
    {
        /*Variaveis*/
        string NomeUser;
        string CPF;
        string Email;
        string Cemail;
        string Senha;
        string Csenha;
        /**************/

        /*Dados do Endereço*/
        string Cidade;
        string Bairro;
        /*******************/
        public CadUsuario()
        {
            InitializeComponent();
        }

        /*Botão para voltar para tela de Login do Uusário*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }

        /*Botão para salvar o cadastro no Banco*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            NomeUser = textNome.Text;
            CPF = textCPF.Text;
            Email = textEmail.Text;
            Cemail = textConfEmail.Text;
            Senha = textSenha.Text;
            Csenha = textConfSenha.Text;
            Bairro = textBairro.Text;
            Cidade = textCidade.Text;

            if (Senha == Csenha && Email == Cemail)
            {

                try
                {
                    CadastroU cadastro;
                    cadastro = new CadastroU(NomeUser,CPF,Email,Senha,Cidade,Bairro);
                    cadastro.setCadastroU();
                    bool Cadastrar;
                    Cadastrar = cadastro.Cadastrar;
                    if (Cadastrar == true)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                    }
                    else if(Cadastrar == false)
                    {
                        MessageBox.Show("Erro ao realizar cadastro\nTente novamente.");
                    }
                    else
                    {
                        MessageBox.Show(cadastro.messageErro);
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
                    MessageBox.Show(str.ToString());
                }

                /*Trata erro do Programa*/
                catch (IfuelException erro)
                {
                    StringBuilder str = new StringBuilder();
                    str.AppendLine(erro.Message);
                    str.AppendLine("\n");
                    str.AppendLine(erro.StackTrace);
                    MessageBox.Show(str.ToString());
                }
            }
            else if(Senha != Csenha && Email == Cemail)
            {
                MessageBox.Show("Erro ao cadastrar\nSenha e Confirmação de Senha não são iguais\nTente Novamente.");
            }
            else if (Senha == Csenha && Email != Cemail)
            {
                MessageBox.Show("Erro ao cadastrar\nEmail e Confirmação de Email não são iguais\nTente Novamente.");
            }
            
        }
    }
}
