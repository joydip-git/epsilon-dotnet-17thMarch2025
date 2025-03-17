﻿namespace CalculatorApp
{
    internal class Program
    {
        static void Main()
        {
            char toContinue = 'n';
            do
            {
                PrintMenu();
                int choice = GetChoiceFromUser();

                int firstNumber = GetValueFromUser();
                int secondNumber = GetValueFromUser();

                int? calculationResult = Calculate(choice, firstNumber, secondNumber);
                if (calculationResult.HasValue)
                {
                    Console.WriteLine("Result is " + calculationResult.Value);
                }
                else
                    Console.WriteLine("could not perform calculation");

                toContinue = DecideToContinue();
            }
            while (toContinue != 'n');
        }

        //User Interface or Presentation logic
        static void PrintMenu()
        {
            Console.WriteLine("1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        }

        static int GetChoiceFromUser()
        {
            Console.Write("\nenter choice[1/2/3/4]: ");
            return int.Parse(Console.ReadLine());
        }

        static int GetValueFromUser()
        {
            Console.Write("\nenter value: ");
            return int.Parse(Console.ReadLine());
        }

        static char DecideToContinue()
        {
            Console.Write("\nContinue?[y/Y/n/N]: ");
            char choice = char.Parse(Console.ReadLine());
            if (char.IsUpper(choice))
                choice = char.ToLower(choice);

            return choice;
        }

        //Business Logic Methods
        static int? Calculate(int choice, int firstValue, int secondValue)
        {
            int? result = null;
            switch (choice)
            {
                case 1:
                    result = Add(firstValue, secondValue);
                    break;

                case 2:
                    result = Subtract(firstValue, secondValue);
                    break;

                case 3:
                    result = Multiply(firstValue, secondValue);
                    break;

                case 4:
                    result = Divide(firstValue, secondValue);
                    break;

                default:
                    break;
            }
            return result;
        }
        
        static int Add(int first, int second)
        {
            return first + second;
        }
        static int Subtract(int first, int second)
        {
            return first - second;
        }
        static int Multiply(int first, int second)
        {
            return first * second;
        }
        static int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
