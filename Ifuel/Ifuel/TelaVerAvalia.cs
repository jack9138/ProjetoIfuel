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
    public partial class TelaVerAvalia : Form
    {
        public TelaVerAvalia()
        {
            InitializeComponent();
        }

        /*Seleciona o periodo de tempo para mostrar as avaliações*/
        private void selectPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método para tratar seleção
        }

        /*Caixa de texto para mostrar avaliações*/
        private void richMostraAvali_TextChanged(object sender, EventArgs e)
        {
            //Criar método para mostrar avaliações
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
