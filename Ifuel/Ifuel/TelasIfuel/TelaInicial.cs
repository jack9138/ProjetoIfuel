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
    public partial class TelaInicial : Form
    {
        public int telaCad = 0; 
        public TelaInicial()
        {
            InitializeComponent();
        }

        /*Botão que chama a tela de LoginUser do Usuário*/
        private void usuario_Click(object sender, EventArgs e)
        {
            LoginUser LoginUser = new LoginUser();
            LoginUser.Show();
            Hide();
        }

        /*Botão que chama a tela de LoginUser do Posto*/
        private void posto_Click(object sender, EventArgs e)
        {
            LoginPosto LoginPosto = new LoginPosto();
            LoginPosto.Show();
            Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
