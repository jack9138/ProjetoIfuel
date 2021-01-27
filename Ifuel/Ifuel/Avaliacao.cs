using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Avaliacao
    {
        #region Declaração de Variaveis
        /*Dados da avaliação*/
        string Comentario;
        string NomePosto;
        int Nota;
        DateTime DataAva;
        /*****************/
        #endregion

        #region Construtor
        /*Construtor Avaliacao*/
        public Avaliacao(string comentario, string nomePosto, int nota, DateTime dataAva)
        {
            Comentario = comentario;
            NomePosto = nomePosto;
            Nota = nota;
            DataAva = dataAva;
        }
        #endregion


        #region Métodos
        public  void setAvaliacao()
        {
            //criar código para salvar avaliação
        }


        public void getAvaliacao()
        {
            //Criar código para salvar avaliação
        }
        #endregion
    }
}
