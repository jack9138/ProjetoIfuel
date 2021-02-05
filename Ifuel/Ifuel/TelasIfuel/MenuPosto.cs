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
        public int Id_posto = 0;
        public int logado = 1; 
        public MenuPosto()
        {
            InitializeComponent();
        }

        /*Botão para Atualizar valores dos combustiveis*/
        private void btnAtuPreco_Click(object sender, EventArgs e)
        {
            AtuPreco atualiza = new AtuPreco();
            atualiza.Show();
            atualiza.ID_posto = Id_posto;
            Hide();
        }

        /*Botão para ver as avaliações do Posto*/
        private void btnverAvaliacao_Click(object sender, EventArgs e)
        {
            //Criar metódo para mostrar avaliações na tela de Avaliações
            TelaVerAvalia telaAvali = new TelaVerAvalia();
            telaAvali.Show();
            telaAvali.Id_posto = Id_posto;
            Hide();
        }

        /*Botão para Atualizar cadastro do Posto*/
        private void btnAtuCad_Click(object sender, EventArgs e)
        {
            AtuCadPosto atu = new AtuCadPosto();
            atu.Show();
            Hide();
        }

        /*Botão para sair(Fecha programa)*/
        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaInicial tela = new TelaInicial();
            tela.Show();
            Hide();
        }
    }
}
