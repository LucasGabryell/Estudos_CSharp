using System;
using System.Globalization;
using Exercicio3_Classes;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo teste = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Largura: ");
            teste.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            teste.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(teste);

        }
    }
}
