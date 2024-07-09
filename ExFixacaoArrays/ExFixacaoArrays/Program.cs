using System;

namespace ExFixacaoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] pensionato = new Quarto[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i=0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                pensionato[quarto] = new Quarto { Nome = nome, Email = email, Numero = quarto }; 
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (pensionato[i] != null)
                {
                    Console.WriteLine(pensionato[i]);
                }
            }



        }
    }
}