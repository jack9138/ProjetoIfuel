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
    public partial class TelaAvaliar : Form
    {
        public TelaAvaliar()
        {
            InitializeComponent();
        }

        /*Caixa de texto que recebe o nome do Posto*/
        private void txtNomePosto_TextChanged(object sender, EventArgs e)
        {
            //Criar método para receber e tratar informações
        }

        /*Caixa de seleção- Possui as notas para avaliar*/
        private void selectNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Criar método para mostrar e tratar as notas
        }

        /*Caixa de texto que recebe comentário do usuário */
        private void richTxtComent_TextChanged(object sender, EventArgs e)
        {
            //Criar método para tratar e salvar os dados do comentário
        }

        /*Botão para voltar ao menu*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuUser menu = new MenuUser();
            menu.Show();
            Hide();
        }

        /*Botão para salvar avaliação*/
        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            //Criar método para confirmar dados recebidos e salvar no Banco. 
            Close();
        }
    }
}
