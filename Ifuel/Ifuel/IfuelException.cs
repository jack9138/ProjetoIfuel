using System;

namespace Ifuel
{
    class IfuelException : Exception
    {
        /*Clase para tratamento de exceções personalizadas*/
        public IfuelException(string mensage) : base(mensage)
        {
        }
    }
}
