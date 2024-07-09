using ExMetodosAbstratos.Entities;
using System.Collections.Generic;
using System.Globalization;


namespace ExMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> taxpayers = new List<Taxpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual indv = new Individual(healthExpenditures, name, anualIncome);
                    taxpayers.Add(indv);
                }
                else
                {
                    Console.Write("Number of employees:");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    Company comp = new Company(name, anualIncome, numberEmployees);
                    taxpayers.Add(comp);
                }
            }

            double totalTaxes = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");

            foreach(Taxpayer taxpayer in taxpayers)
            {
                Console.WriteLine(taxpayer.ToString());
                totalTaxes += taxpayer.Tax();
            }

            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
