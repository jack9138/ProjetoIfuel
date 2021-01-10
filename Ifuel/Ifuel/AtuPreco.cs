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
    public partial class AtuPreco : Form
    {
        public AtuPreco()
        {
            InitializeComponent();
        }

        /*Caixa para selecionar combustíveis*/
        private void selecComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar opções de seleção
        }

        /*Caixa para digitar valor do combustível*/
        private void textValor_TextChanged(object sender, EventArgs e)
        {
           //Criar método para converter valor da caixa de texto para formato igual do banco. 
        }

        /*Botão para salvar o o novo valor*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Close();//Criar método de verificação dos dados antes de salvar no banco.
        }

        /*Botão para voltar ao Menu do Posto*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPosto menu = new MenuPosto();
            menu.Show();
            Hide();
        }

      
    }
}
