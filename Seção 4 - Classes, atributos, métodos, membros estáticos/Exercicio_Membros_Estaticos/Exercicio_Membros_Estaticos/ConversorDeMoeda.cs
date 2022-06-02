using System;
using System.Globalization;

namespace Exercicio_Membros_Estaticos
{
    internal class ConversorDeMoeda
    {
        public static double Converter(double dolar, double qtdDolar)
        {
            double conversao = (dolar * qtdDolar);
            return conversao + ((conversao * 6.00)/100.00);
        }
        
    }
}
