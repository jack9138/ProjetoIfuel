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

namespace Ifuel
{
    public partial class LoginPosto : Form
    {
        /*Conexão do Banco*/
        string connectionString = @"Server= localhost;Initial Catalog= IFUEL;Integrated Security=True;";
        public LoginPosto()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string user = textUser.ToString(); /*Convert o textbox User em string para verificação*/
            string senha = textSenha.ToString();/*Convert a senha em string para verificação*/

            /*Verifica se o usuário preenchue os campos*/
            if (user == " " && senha == " " || user == " " || senha == " ")
            {
                MessageBox.Show("Dados não preenchidos");
            }
            else
            {
                string sql = "(SELECT * FROM USERPOSTO WHERE LoginUser_USR = '" + textUser + "' AND SENHA_USR'" + textSenha + ")";
                /*Verifica os dados e tenta realizar a leitura dos dados de LoginUser*/
                SqlConnection conect = new SqlConnection(connectionString);
                SqlComand cmd = new SqlComand(sql, conect);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader;
                conect.Open();

                reader = cmd.ExecuteReader();
                try
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Login ou Senha Incorretos !");
                    }
                    else
                    {
                        this.Hide();

                        //Menu do Posto, falta criar 

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }

        /*Botão para fazer Cadastro*/
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Close();//Falta criar tela de cadastro do Posto
        }

        /*Botão para fazer Voltar a tela de menu*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Hide();
        }
    }
}
