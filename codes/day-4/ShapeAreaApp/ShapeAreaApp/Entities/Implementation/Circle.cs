using ShapeAreaApp.Entities.Contract;

namespace ShapeAreaApp.Entities.Implementation
{
    public class Circle : IShape
    {
        //automatic or auto-implemented property
        //public double Radius { get; set; }

        private double _radius;
        //if set and get have more than on line of code (assignmemt or retrin value of data member) choose regular property over automatic property
        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                    _radius = value;
            }
        }

        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea() => Math.PI * Radius * Radius;
    }
}
