using System;
using System.Globalization;
using Exercicio5_Classes;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(); 
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(perc);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
