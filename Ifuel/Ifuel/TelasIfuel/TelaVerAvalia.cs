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
        public int Id_posto = 0;
        public TelaVerAvalia()
        {
            InitializeComponent();
        }

        private void TelaVerAvalia_Load(object sender, EventArgs e)
        {
            textAvaliacoes.Hide();
            btnFechar.Hide();
        }
        /*Botão para voltar ao Menu do Posto*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPosto menu = new MenuPosto();
            menu.Show();
            Hide();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            
            string dataIni = textData1.Text;
            string dataFim = textData2.Text;
            Avaliacao av = new Avaliacao();
            av.getAvaliacao(dataIni,dataFim,Id_posto);
            textAvaliacoes.Text = av.ListaAvali.ToString();
            textAvaliacoes.Show();
            btnFechar.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            textAvaliacoes.Hide();
            btnFechar.Hide();
        }

        
    }
}
