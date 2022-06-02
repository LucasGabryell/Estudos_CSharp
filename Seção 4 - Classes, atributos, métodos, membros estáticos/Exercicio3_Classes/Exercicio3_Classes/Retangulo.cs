using System;
using System.Globalization;


namespace Exercicio3_Classes
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {

            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Altura,2) + Math.Pow(Largura, 2)));
        }

        public override string ToString()
        {
            return "\nÁREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERÍMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                +"\nDIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
