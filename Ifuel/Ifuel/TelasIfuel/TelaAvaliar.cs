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
            string nota = textNota.Text;
            string coment = txtComent.Text;
            string nomePosto = txtNomePosto.Text;
            DateTime date = new DateTime();


            try
            {
                Avaliacao av = new Avaliacao(coment,nomePosto,nota,date.ToLocalTime());
                av.setAvaliacao();

                if (av.Avaliou == true)
                {
                    MessageBox.Show("Sua avaliação foi salva com sucesso !\nObrigada por avaliar.");
                    txtComent.Clear();
                    txtNomePosto.Clear();
                    textNota.Clear();
                }
                else if (av.Avaliou == false)
                {
                    MessageBox.Show("Ocorreu um erro na hora de avaliar" + av.messageErro);
                }
                else
                {
                    MessageBox.Show(av.messageErro + "\nEntre em contato com o Administrador do Software");
                }
            }
            /*Trata erro do Programa*/
            catch (IfuelException erro)
            {
                StringBuilder str = new StringBuilder();
                str.AppendLine(erro.Message);
                str.AppendLine("\n");
                str.AppendLine(erro.StackTrace);
                 MessageBox.Show(str.ToString());
            }
        }
    }
}
