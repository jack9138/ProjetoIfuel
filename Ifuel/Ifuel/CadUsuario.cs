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
        public CadUsuario()
        {
            InitializeComponent();
        }
        /*Caixa para armazenar o nome*/
        private void textNome_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }
        /*Caixa que recebe o valor do CPF*/
        private void textCPF_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }
        /*Caixa que recebe a Cidade*/
        private void textCidade_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }
        /*Caixa que recebe o Bairro*/
        private void textBairro_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }
        /*Caixa que recebe o Email*/
        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }
        /*Caixa que recebe confirmação de email*/
        private void textConfEmail_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }

        /*Caixa que recebe senha*/
        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
        }

        /*Caixa que recebe confirmação de senha*/
        private void textConfSenha_TextChanged(object sender, EventArgs e)
        {
            //Criar metodo para receber os dados
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
            //Criar método para verificar dados e salvar
        }
    }
}
