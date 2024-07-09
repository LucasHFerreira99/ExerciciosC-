using System.Diagnostics.Contracts;
using System.Globalization;
using ExInterface.Entities;
using ExInterface.Services;

namespace ExInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Entities.Contract cont = new Entities.Contract(number, data, value);
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(cont, months);

            Console.WriteLine("Installments:");
            foreach(Installment inst in cont.Installments)
            {
                Console.WriteLine(inst);
            }

        }
    }
}