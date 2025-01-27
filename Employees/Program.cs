namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******The Employee Class Hierarchy********\n");

            SalesPerson fred = new SalesPerson
            {
                Age = 31,
                Name = "Fred",
                SalesNumber = 50
            };


            Console.WriteLine("\n");

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "123-354-6546", 9000);

            double cost = chucky.GetBenefitCost();

            Console.WriteLine($"Benefit Cost: {cost}\n");

            chucky.GiveBonus(300);

            chucky.DisplayStatus();
        }
    }
}
