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
    public partial class AtuCadUser : Form
    {
        AtualizarCadUs at = new AtualizarCadUs();
        public int Id_usr;
        public AtuCadUser()
        {
            InitializeComponent();
        }

        private void AtuCadUser_Load(object sender, EventArgs e)
        {
           
             at.getCadastro(Id_usr);
             textNome.Text = at.NomeUser;
             textCPF.Text = at.CPF;
             textEmail.Text = at.Email;
             textBairro.Text = at.Bairro;
             textCidade.Text = at.Cidade;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            at.upCadastro(Id_usr);
            if (at.Atualizou == true)
            {
                MessageBox.Show("Dados atualiazados com sucesso !");
            }
            else
            {
                MessageBox.Show(at.message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuUser menu = new MenuUser();
            menu.Show();
            Hide();
        }
    }
}
