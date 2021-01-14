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
    public partial class CadPosto : Form
    {
        public CadPosto()
        {
            InitializeComponent();
        }

        /*Caixa de texto- Recebe o nome do Posto*/
        private void textNomePosto_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto-Recebe o UF(Estado)*/
        private void textUF_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto- Recebe a Cidade do Posto*/
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto-Recebe o Bairro do Posto*/
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto-Recebe o endereço do Posto*/
        private void textEnd_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto-Recebe o CNPJ*/
        private void textCnpj_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto- Recebe o número do Alvará*/
        private void textAlv_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de verificação-Verifica se o Posto aceitou o acordo*/
        private void checkAcordo_CheckedChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Link para o termo de uso*/
        private void linkTermo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Precisa aparecer uma mensagem com os termos de usos
        }

        /*Caixa de Seleção - Para selecionar 1º combustível*/
        private void selctComb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto- Para receber o valor do 1º combustível */
        private void textValor1_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de Seleção - Para selecionar 2º combustível*/
        private void selectComb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto- Para receber o valor do 2º combustível */
        private void textValor2_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de Seleção - Para selecionar 3º combustível*/
        private void selectComb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar no Banco
        }

        /*Caixa de texto- Para receber o valor do 3º combustível */
        private void textValor3_TextChanged(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e 
        }

        /*Botão para salvar os dados*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Criar método de tratamento para receber os valores e salvar dos Bancos
        }

        public void btnVoltar_Click(object sender, EventArgs e)
        {

            LoginPosto login = new LoginPosto();
            login.Show();
            Hide();

        }
    }

}
