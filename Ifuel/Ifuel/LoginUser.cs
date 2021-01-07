using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ifuel;

namespace Ifuel
{
    public partial class Login : Form
    { 
        
        public Login()
        {
            InitializeComponent();
        }

        /*Botão para fazer Login*/
        private void btnLogar_Click(object sender, EventArgs e)
        {
            Close(); //Ainda não possui a função de logar,Precisa conectar no Banco e fazer verificações
        }

        /*Botão para fazer Voltar a tela de menu*/
        private void btnVoltar_Click(object sender, EventArgs e)
        {

            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            Hide();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Close(); //Ainda não tem tela de cadastro
        }
    }
}
