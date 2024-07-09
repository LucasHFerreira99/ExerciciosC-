using System;
using System.Globalization;

namespace ExerciciosEstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quadrado, cubo;

            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n ; i++)
            {
                quadrado = i * i;
                cubo = i * i * i;
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}
