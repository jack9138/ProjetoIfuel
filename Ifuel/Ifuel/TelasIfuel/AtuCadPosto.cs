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
    public partial class AtuCadPosto : Form
    {
        AtualizarCadPT atu = new AtualizarCadPT();
        int Id_Usr = 0;
        public AtuCadPosto()
        {
            InitializeComponent();
        }
        private void AtuCadPosto_Load(object sender, EventArgs e)
        {
            atu.getCadastro(Id_Usr);
            txtNomePosto.Text = atu.NomeP;
            txtUF.Text = atu.UF;
            txtCidade.Text = atu.Cidade;
            txtBairro.Text = atu.Bairro;
            txtEndereco.Text = atu.Rua;
            txtCep.Text = atu.Cep;
            txtCnpj.Text = atu.CNPJ;
            txtAlvara.Text = atu.Alvara;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            atu.upCadastro(Id_Usr);
            if (atu.Atualizou == true)
            {
                MessageBox.Show("Cadasreo atualizado com sucesso!");
            }
            {
                MessageBox.Show("Ocorreu um erro " +atu.message+ "\nEntre em contato com o Administrador do Sistema!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuPosto menu = new MenuPosto();
            menu.Show();
            Hide();
        }

       
    }
}
