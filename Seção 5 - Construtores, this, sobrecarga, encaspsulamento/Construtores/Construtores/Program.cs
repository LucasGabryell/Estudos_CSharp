﻿using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("Tv", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
