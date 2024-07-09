using System;
using System.Globalization;
using System.Xml;

namespace CoursePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal());

            if (a.Aprovado() == true) Console.WriteLine("APROVADO");
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

        }
    }
}