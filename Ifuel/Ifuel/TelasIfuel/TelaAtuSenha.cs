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
    public partial class TelaAtuSenha : Form
    {

        /*Variavel de controle de telas de Login Posto e Usuário*/
        public int Logar;
        public TelaAtuSenha()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string user = textUser.Text;
            string senha = textSenha.Text;

            /*Verifica quem esta fazendo troca de senha Posto ou o Cliente*/
            if (Logar == 1)
            {
                AtualizarSenha atu = new AtualizarSenha(user,senha);
                atu.setAtualizarPosto();

                if (atu.Atualizou == true)
                {
                    MessageBox.Show("Atualização realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show(atu.message);
                }

            }
            else if (Logar == 2)
            {
                AtualizarSenha atu = new AtualizarSenha(user, senha);
                atu.setAtualizarUser();

                if (atu.Atualizou == true)
                {
                    MessageBox.Show("Atualização realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show(atu.message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            /*Verifica quem esta fazendo troca de senha Posto ou o Cliente*/
            if (Logar == 1)
            {
                LoginPosto loginPosto = new LoginPosto();
                loginPosto.Show();
                Hide();
            }
            else if (Logar == 2)
            {
                LoginUser loginUser = new LoginUser();
                loginUser.Show();
                Hide();

            }
        }
    }
}
