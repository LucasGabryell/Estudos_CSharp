using System;
using System.Globalization;
using Exercicio_Membros_Estaticos;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.Converter(cotacao, qtd).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
