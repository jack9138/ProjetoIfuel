using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifuel
{
    class Combustivel
    {
        #region Declaração de variaveis
        string NomeComb;
        double ValorComb;
        #endregion

        #region Contrutor
        public Combustivel(string nomeComb, double valorComb)
        {
            NomeComb = nomeComb;
            ValorComb = valorComb;
        }
        #endregion


    }
}
