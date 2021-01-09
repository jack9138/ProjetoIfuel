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
    public partial class MenuUser : Form
    {
        public MenuUser()
        {
            InitializeComponent();
        }

        /*Botão para Pesquisar valor*/
        private void btnPesqPreco_Click(object sender, EventArgs e)
        {
            Close();//Deve chamar tela de pesquisa
        }

        /*Botão para Avaliar Posto*/
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            Close();//Deve chamar tela de avaliação
        }

        /*Botão para atualizar cadastro do usuário*/
        private void btnAtuCad_Click(object sender, EventArgs e)
        {
            Close();//Deve chamar tela de cadastro do Usuário;
        }

        /*Botão para sair(Fecha programa)*/
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
