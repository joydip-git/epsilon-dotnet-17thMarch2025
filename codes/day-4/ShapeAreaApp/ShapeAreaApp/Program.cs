using ShapeAreaApp.Entities.Contract;
using ShapeAreaApp.Entities.Implementation;
using System.Diagnostics;

namespace ShapeAreaApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"1. {nameof(Circle)}\n2. {nameof(Triangle)}");

            Console.Write("enter choice[1/2]: ");
            int choice = int.Parse(Console.ReadLine() ?? "0");

            IShape? shape = Create(choice, out string? shapeName);
            Console.WriteLine($"Area of {shapeName} is {shape?.CalculateArea()}, as calcuated with the help of {nameof(IShape.CalculateArea)} method"); 
        }
        static IShape? Create(int choice, out string? shapeName)
        {
            IShape? shape = null;
            switch (choice)
            {
                case 1:
                    Console.Write($"enter radius for {nameof(Circle)}: ");
                    double radius = double.Parse(Console.ReadLine() ?? "0");
                    //object initializer
                    //shapeName = nameof(Circle);
                    Type circleType = typeof(Circle);
                    shapeName = circleType.Name;
                    shape = new Circle() { Radius = radius };
                    break;

                case 2:
                    Console.Write($"enter base for {nameof(Triangle)}: ");
                    double tBase = double.Parse(Console.ReadLine() ?? "0");
                    Console.Write($"enter height for {nameof(Triangle)}: ");
                    double tHeight = double.Parse(Console.ReadLine() ?? "0");
                    shape = new Triangle { TBase = tBase, THeight = tHeight };
                    Type triangleType = shape.GetType();
                    shapeName = triangleType.Name;
                    break;

                default:
                    shapeName = null;
                    break;
            }
            return shape;
        }
    }
}
