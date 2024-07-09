using ExLinq.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Globalization;

namespace ExLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }


                    var emails = employees.Where(p => p.Salary > limit).OrderBy(p => p.Email).Select(p=> p.Email);
                    Console.WriteLine($"Email of people whose salary is more than {limit}:");
                    foreach ( string email in emails )
                    {
                        Console.WriteLine(email);
                    }

                    var soma = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + soma.ToString("F2", CultureInfo.InvariantCulture));

                }
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }




        }
    }
}