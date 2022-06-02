using System;
using System.Globalization;
using Exercicio2_Classe;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos que serão adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos que serão removidos: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p1);

        }
    }
}
