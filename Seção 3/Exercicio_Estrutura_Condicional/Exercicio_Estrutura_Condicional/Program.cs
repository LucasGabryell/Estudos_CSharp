using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 

            Console.WriteLine("Digite um número:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Número positivo!");
            }
            else
            {
                Console.WriteLine("Número negativo!");
            }

            //Exercicio 2

            Console.WriteLine("Digite um número:");
            int par_impar = int.Parse(Console.ReadLine());
            if (par_impar % 2 == 0)
            {
                Console.WriteLine("Número par!");
            }
            else
            {
                Console.WriteLine("Número impar!");
            }

            //Exercicio 3 
            Console.WriteLine("Digite dois números:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double div = num1 / num2;
            if (div % 2 == 0)
            {
                Console.WriteLine("Número multiplo!");
            }
            else
            {
                Console.WriteLine("Número não multiplo!");
            }

            //Exercicio 4
            Console.WriteLine("Digite dois horarios:");
            int h1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int duracao;
            if (h1 < h2)
            {
                duracao = h2 - h1;
            }
            else
            {
                duracao = 24 - h1 + h2;
            }


        }
    }
}
