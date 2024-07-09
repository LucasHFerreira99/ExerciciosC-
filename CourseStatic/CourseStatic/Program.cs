using System;
using System.Globalization;

namespace CourseStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtd, valorDolar;

            Console.Write("Qual a cotação do dólar: ");
            valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(valorDolar, qtd).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}