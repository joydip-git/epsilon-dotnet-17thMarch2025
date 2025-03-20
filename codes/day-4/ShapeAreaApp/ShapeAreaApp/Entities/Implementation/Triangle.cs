using ShapeAreaApp.Entities.Contract;

namespace ShapeAreaApp.Entities.Implementation
{
    public class Triangle : IShape
    {
        public Triangle() { }
        public Triangle(double tBase, double tHeight)
        {
            TBase = tBase;
            THeight = tHeight;
        }

        public double TBase { get; set; }
        public double THeight { get; set; }

        public double CalculateArea() => 0.5 * TBase * THeight;
    }
}
