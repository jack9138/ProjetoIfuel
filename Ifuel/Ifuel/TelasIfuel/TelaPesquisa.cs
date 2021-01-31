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
            string cidade = txtCidade.Text;
            string bairro = txtBairro.Text;
            string comb = txtComb.Text;

            PesquisarValor pesq = new PesquisarValor(cidade,bairro,comb);
            pesq.getValor();//Precisa criar outra tela para mostrar os resultados. 
        }
    }
}
