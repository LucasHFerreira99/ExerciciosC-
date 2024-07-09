using System;
using System.Globalization;

namespace EncapsulamentoEx
{
    class Program
    {
      static void Main(string[] args)
        {
            double deposito = 0, retirar;
            int numero;
            string nome;
            char opcao;
            Conta c1; 

            Console.Write("Entre o número da conta: ");
            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(nome, numero, deposito);
            }
            else
            {
                c1 = new Conta(nome, numero);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito:");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            retirar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(retirar);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);


        }
    }
}