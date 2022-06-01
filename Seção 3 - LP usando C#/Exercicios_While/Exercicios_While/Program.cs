using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!\n");


            //Exercicio 2

            Console.WriteLine("1 - Alcool \n2 - Gasolina \n3 - Disel \n4 - Sair");
            int menu = int.Parse(Console.ReadLine());

            int cont_alcool = 0;
            int cont_gasolina = 0;
            int cont_disel = 0;
            while (menu != 4)
            {
                if (menu == 1)
                {
                    cont_alcool++;
                }
                else if(menu == 2)
                {
                    cont_gasolina++;
                }
                else if(menu == 3)
                {
                    cont_disel++;
                }
                Console.WriteLine("1 - Alcool \n2 - Gasolina \n3 - Disel \n4 - Sair");
                menu = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO" +
                "\nAlcool: " + cont_alcool + "\nGasolina: " + cont_gasolina +
                "\nDisel: " + cont_disel);
        }
    }
}
