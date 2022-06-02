using System;
using System.Globalization;
using Exercicio5_Classes;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();
            Console.Write("Quantos alunos serão vizualizados? ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("\nNome do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite as três notas do aluno:");
                aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(aluno);
            }
        }
    }
}
