using System.Globalization;

namespace ExFixacaoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();  

            for (int i=0; i<qtd; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string nome =Console.ReadLine();
                Console.Write("Salary: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome ,valor));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Enter the employee id that will have salary increase:");
            int idFun = int.Parse(Console.ReadLine());

            Funcionario funcionarioID = funcionarios.Find(x => x.Id == idFun);

            if (funcionarioID != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarioID.increaseSalary(porcentagem);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine(func);
            }
        }
    }
}