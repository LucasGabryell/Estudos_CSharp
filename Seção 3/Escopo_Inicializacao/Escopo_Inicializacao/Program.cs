using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            if (preco < 100)
            {
                double desconto = preco * 0.1;
            }
            //Console.WriteLine(desconto); não pode pois desconto é uma variavel local

        }
    }
}
