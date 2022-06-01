using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.Write("Digite quantos valores serão passados: ");
            int valores = int.Parse(Console.ReadLine());

            int count_in = 0;
            int count_out = 0;
            for(int i = 1; i <= valores; i++)
            {
                Console.Write("Digite um número: ");
                int num = int.Parse(Console.ReadLine());
                if (num < 10 || num > 20)
                {
                    count_out++;
                }
                else if (num > 10 && num < 20)
                {
                    count_in++;
                }
            }
            Console.WriteLine($"{count_in} in \n{count_out} out");

            //Exercicio 2
            Console.Write("Digite quantos valores serão passados: ");
            int valores1 = int.Parse(Console.ReadLine());

            for(int i = 1;i <= valores1; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
