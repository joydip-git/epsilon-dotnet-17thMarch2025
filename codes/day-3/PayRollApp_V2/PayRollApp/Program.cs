using PayRollApp.Entities;

namespace PayRollApp
{
    internal class Program
    {
        static void Main()
        {
            Developer? developer = Create();
            developer?.CalculateSalary();
            Console.WriteLine($"Total salary of {developer?.Name} is {developer?.TotalPay}");

            Hr? hr = Create();
        }
        static Developer? Create()
        {
            Console.Write("enter name: ");
            string name = Console.ReadLine() ?? "";

            Random rand = new Random();
            int id = rand.Next(100, 500);

            Console.Write("enter basic payment: ");
            //decimal basic = decimal.Parse(Console.ReadLine() ?? "0");
            decimal basic;
            decimal.TryParse(Console.ReadLine() ?? "0", out basic);

            Console.Write("enter da payment: ");
            //decimal da;
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal da);

            Console.Write("enter hra payment: ");
            decimal hra;
            decimal.TryParse(Console.ReadLine() ?? "0", out hra);

            Console.Write("enter incentive payment: ");
            //decimal incentive = decimal.Parse(Console.ReadLine() ?? "0");
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal incentive);

            //Developer developer = new Developer();
            //Developer developer = new();

            Developer developer = new(
                name: name,
                id: id,
                basicPay: basic,
                daPay: da,
                hraPay: hra,
                incentivePay: incentive
                );

            return developer;
        }
    }
}
