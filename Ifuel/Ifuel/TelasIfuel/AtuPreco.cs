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

        /*Carrega o Form AtuPreco */
        private void AtuPreco_Load(object sender, EventArgs e)
        {
            //Colocar parte do código aqui. 
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
