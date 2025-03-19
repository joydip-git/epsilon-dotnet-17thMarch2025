using PayRollApp.Entities;

namespace PayRollApp
{
    internal class Program
    {
        static void Main()
        {
            PrintMenu();
            int choice = GetChoice();

            Employee? emp = Create(choice);
            PrintSalary(emp);
            //emp?.CalculateSalary();
            //Console.WriteLine($"Total salary of {emp?.Name} is {emp?.TotalPay}");
        }
        static void PrintSalary(Employee? emp)
        {
            emp?.CalculateSalary();
            Console.WriteLine($"Total salary of {emp?.Name} is {emp?.TotalPay}");
        }
        //static void PrintSalary(Developer developer)
        //{
        //    developer.CalculateSalary();
        //}
        //static void PrintSalary(Hr hr)
        //{
        //    hr.CalculateSalary();
        //}

        static int GetChoice()
        {
            Console.Write("\nenter choice[1/2]: ");
            return int.Parse(Console.ReadLine() ?? "1");
        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Developer \n2. Hr");
        }

        static Employee? Create(int choice)
        {
            Console.Write("enter name: ");
            string name = Console.ReadLine() ?? "";

            Random rand = new Random();
            int id = rand.Next(100, 500);

            Console.Write("enter basic payment: ");
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal basic);

            Console.Write("enter da payment: ");
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal da);

            Console.Write("enter hra payment: ");
            decimal.TryParse(Console.ReadLine() ?? "0", out decimal hra);

            Employee? employee = null;

            switch (choice)
            {
                case 1:
                    Console.Write("enter incentive payment: ");
                    decimal.TryParse(Console.ReadLine() ?? "0", out decimal incentive);
                    employee = new Developer(name: name, id: id, basicPay: basic, daPay: da, hraPay: hra, incentivePay: incentive);
                    break;

                case 2:
                    Console.Write("enter gratuity payment: ");
                    decimal.TryParse(Console.ReadLine() ?? "0", out decimal gratuity);
                    employee = new Hr(name: name, id: id, basicPay: basic, daPay: da, hraPay: hra, gratuityPay: gratuity);
                    break;

                default:
                    break;
            }
            return employee;
        }
    }
}
