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
        public int ID_posto = 0;
        public AtuPreco()
        {
            InitializeComponent();
        }

        /*Carrega o Form AtuPreco */
        private void AtuPreco_Load(object sender, EventArgs e)
        {
            selectComb1.Text = "Gasolina";
            selectComb2.Text = "Etanol";
            selectComb3.Text = "Diesel";
        }

        /*Botão para salvar o o novo valor*/
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Comb = null;
            double Valor = 0.0;
            if (selectComb1.Checked == true && !string.IsNullOrEmpty(txtValorN.Text))
            {
                Comb = selectComb1.Text;
                Valor = double.Parse(txtValorN.Text);
            }
            else if (selectComb2.Checked == true && !string.IsNullOrEmpty(txtValorN.Text))
            {
                Comb = selectComb2.Text;
                Valor = double.Parse(txtValorN.Text);
            }
            else if (selectComb3.Checked == true && !string.IsNullOrEmpty(txtValorN.Text))
            {
                Comb = selectComb3.Text;
                Valor = double.Parse(txtValorN.Text);
            }
            else
            {
                MessageBox.Show("Um dos valores não foi preenchido\nVerifique os campos");
            }

            AtualizarValor atu = new AtualizarValor(Comb,Valor,ID_posto);
            atu.setNValor();

            if (atu.Atualizou)
            {
                MessageBox.Show("Valor atualizado");
            }
            else if (atu.Atualizou)
            {
                MessageBox.Show("Ocorreu um erro\nVerifique os campos e tente novamente");
            }
            else
            {
                MessageBox.Show(atu.messageErro + "Entre em contato com o Suporte do Sistema");
            }
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
