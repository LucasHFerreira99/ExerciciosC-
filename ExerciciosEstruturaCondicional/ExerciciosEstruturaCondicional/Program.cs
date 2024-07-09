using System;
using System.Globalization;
using System.Net.WebSockets;

namespace ExerciciosEstruturaCondicional
{
    class Program
    {
        public static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0.0;
            if (salario <= 2000)
            {
                imposto = 0;
            }
            else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            }
            else if (salario <= 4500)
            {
                imposto = (1000 * 0.08) + ((salario - 3000) * 0.18);
            }
            else
            {
                imposto = (1000 * 0.08) + (1500 * 0.18) + ((salario - 4500) * 0.28);
            }
            if (imposto == 0)
            {
                Console.WriteLine("Isento");
            }
            else Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

        }


    }
}