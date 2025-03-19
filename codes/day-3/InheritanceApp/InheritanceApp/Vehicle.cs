namespace InheritanceApp
{
    class Vehicle
    {
        //protected string color = "";
        //protected string make = string.Empty;
        string color = "";
        string make = string.Empty;

        public Vehicle()
        {
            Console.WriteLine("default ctor of Vehicle");
        }

        public Vehicle(string color, string make)
        {
            this.color = color;
            this.make = make;
            Console.WriteLine("parameterized ctor of Vehicle");
        }

        public string Color { get => color; set => color = value; }
        public string Make { get => make; set => make = value; }
    }
}
