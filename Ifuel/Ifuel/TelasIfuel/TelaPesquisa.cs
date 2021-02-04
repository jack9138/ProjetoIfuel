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
        private void TelaPesquisa_Load(object sender, EventArgs e)
        {
            vRolagemP.Hide();
            btnFechar.Hide();
            txtMResult.Hide();
            selectComb1.Text = "Gasolina";
            selectComb2.Text = "Diesel";
            selectComb3.Text = "Etanol";
            
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
            string cidade = null;
            string bairro = null;
            string combSelec = null;
            if (selectComb1.Checked)
            {
                cidade = txtCidade.Text;
                bairro = txtBairro.Text;
                combSelec = selectComb1.Text;
            }
            else if (selectComb2.Checked)
            {
                cidade = txtCidade.Text;
                bairro = txtBairro.Text;
                combSelec = selectComb2.Text;
            }
            else if (selectComb3.Checked)
            {
                cidade = txtCidade.Text;
                bairro = txtBairro.Text;
                combSelec = selectComb3.Text;
            }
            else
            {
                MessageBox.Show("Selecione um combustível para continuar a pesquisa!");
            }

            //VScrollBar vScrollBar1 = new VScrollBar();
            PesquisarValor pesq = new PesquisarValor(cidade, bairro, combSelec);
            pesq.getValor();
            txtMResult.Text = pesq.resultValor.ToString();
            txtMResult.Show();
            btnFechar.Show();
            txtMResult.Controls.Add(vRolagemP);
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            btnFechar.Hide();
            txtMResult.Hide();
            txtBairro.Clear();
            txtCidade.Clear();
            txtMResult.Clear();
        }
    }
}
