namespace InheritanceApp
{
    class Car : Vehicle
    {
        string chasisNo = "";
        string modelName = string.Empty;

        public Car() : base("White", "")
        {
            Console.WriteLine("default ctor of Car");
        }

        public Car(string color, string make, string chasisNo, string modelName) : base(color, make)
        {
            //this.color = color;
            //this.make = make;
            //this.Color = color;
            //this.Make = make;
            this.chasisNo = chasisNo;
            this.modelName = modelName;
            Console.WriteLine("parameterized ctor of Car");
        }

        public string ChasisNo { get => chasisNo; set => chasisNo = value; }
        public string ModelName { get => modelName; set => modelName = value; }
    }
}
