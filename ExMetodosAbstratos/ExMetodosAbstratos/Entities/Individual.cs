using System.Globalization;

namespace ExMetodosAbstratos.Entities
{
    internal class Individual : Taxpayer
    {
        public double HealthSpending { get; set; }
        
        public Individual(double healthSpending, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthSpending * 0.5;          
            }
            else
            {
                return AnnualIncome * 0.25 - HealthSpending * 0.5;
            }
        }


    }
}
