using System;

namespace ExSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> total = new HashSet<int>(a);

            total.UnionWith(b);
            total.UnionWith(c);

            Console.WriteLine("Total students: " + total.Count);

        }
    }
}