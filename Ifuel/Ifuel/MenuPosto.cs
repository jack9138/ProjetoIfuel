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
    public partial class MenuPosto : Form
    {
        public MenuPosto()
        {
            InitializeComponent();
        }

        /*Botão para Atualizar valores dos combustiveis*/
        private void btnAtuPreco_Click(object sender, EventArgs e)
        {
            AtuPreco atualiza = new AtuPreco();
            atualiza.Show();
            Hide();
        }

        /*Botão para ver as avaliações do Posto*/
        private void btnverAvaliacao_Click(object sender, EventArgs e)
        {
            Close();//Deve chamar tela de avaliações-Falta criar tela
        }

        /*Botão para Atualizar cadastro do Posto*/
        private void btnAtuCad_Click(object sender, EventArgs e)
        {
            Close(); //Deve chamar tela de Cadastro para fazer atualização
        }

        /*Botão para sair(Fecha programa)*/
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
