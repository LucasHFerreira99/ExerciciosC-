
namespace ExMetodosAbstratos.Entities
{
    internal class Company : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public Company(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            if (NumberEmployees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
