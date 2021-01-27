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
        public TelaVerAvalia()
        {
            InitializeComponent();
        }
        private void TelaVerAvalia_Load(object sender, EventArgs e)
        {
            //Carrega o form 
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
