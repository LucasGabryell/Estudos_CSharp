using System;
using System.Globalization;

namespace Exercicio5_Classes
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public override string ToString()
        {
            if (NotaFinal() >= 60)
            {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\nAPROVADO";
            }
            else
            {
                return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO" 
                    + "\nFALTARAM " + (60.00 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) ;
            }
        }
    }
}
