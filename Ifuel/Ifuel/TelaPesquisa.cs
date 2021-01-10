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
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        /*Caixa que seleciona Cidade*/
        private void selecCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Utilizar como base, banco de dados de endereço do Posto
        }

        /*Caixa de seleção do Bairro, precisa mostrar os bairros das Cidades*/
        private void selecBairro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Utilizar como base, banco de dados de endereço do Posto
        }

        /*Caixa de seleção do Combstivel, precisa mostrar opções de combustíveis*/
        private void selecComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método para selecionar combustíveis
        }

        /*Volta para tela de Menu do Usuário*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuUser menu = new MenuUser();
            menu.Show();
            Hide();
        }

        /*Botão para pesquisar valores*/
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Precisar colocar os metodos de pesquisas e tratamento de exceções. 
            //Ao final da pesquisa, mrostar um MESSAGEBOX com os resultados.
        }
    }
}
