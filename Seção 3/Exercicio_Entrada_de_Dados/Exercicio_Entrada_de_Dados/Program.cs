using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] info = Console.ReadLine().Split(' ');
            string sobrenome = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2], CultureInfo.InvariantCulture);

            Console.WriteLine("nome: " + nome + "\nquantidade de quartos" + quartos +
                "\npreço do produto: " + preco.ToString("F2",CultureInfo.InvariantCulture) + "\nsobrenome: " + sobrenome +
                "\nidade: " + idade + "\naltura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
