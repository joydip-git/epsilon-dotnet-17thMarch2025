using Microsoft.VisualBasic;

namespace ClassObjectApp
{
    internal class Program
    {
        static void Main()
        {
            //Person anilPersonRef = new Person();
            Console.Write("enter name: ");
            string personName = Console.ReadLine();

            Console.Write("enter id: ");
            int personId = int.Parse(Console.ReadLine());

            Console.Write("enter location: ");
            string personLocation = Console.ReadLine();

            Console.Write("enter mobile no: ");
            long personMobile = long.Parse(Console.ReadLine());

            Console.Write("enter date of birth in MM/DD/YYYY format: ");

            DateTime personDateOfBirth;
            //it will try to convert the string entered by user in the terminal and returned by the ReadLine() method and then if possible to convert the value to proper date time, that converted value will be assigned to the variable passed by out. if the conversion is NOT possible, then a default value will be assigned to that variable passed by out
            bool isPossible = DateTime.TryParse(
               Console.ReadLine(),
               out personDateOfBirth
               );
            Person? anilPersonRef = null;
            if (isPossible)
            {
                //anilPersonRef = new Person(personName, personLocation, personMobile, personDateOfBirth);
                //named arguments feature (passing the value of the argument with the name of the argument. it helps you to pass values in random order)
                anilPersonRef = new Person(
                    mobileNo: personMobile,
                    id: personId,
                    name: personName,
                    dateOfBirth: personDateOfBirth,
                    location: personLocation
                    );
            }
            else
            {
                Console.WriteLine("could not conver the value in proper date of birth...try providing value in correct format...");
                //anilPersonRef = new Person(personName,personId, personLocation, personMobile);
            }

            //if (anilPersonRef != null)
            //{
            //    string information = anilPersonRef.PrintInformation();
            //    Console.WriteLine(information);
            //}

            if (anilPersonRef != null)
            {
                anilPersonRef.Location = "Chennai";
                anilPersonRef.Name = "Anil Kumar";
                anilPersonRef.DateOfBirth = new DateTime(2000, 1, 13);
                anilPersonRef.MobileNo = 9090909091;
            }

            Console.WriteLine(anilPersonRef?.PrintInformation());

            Console.WriteLine($"Name: {anilPersonRef?.Name}");
            Console.WriteLine($"Location: {anilPersonRef?.Location}");

            //int a = 0;
            //int b = 0;
            //int c;
            //Swap(a, ref b, out c);
            //Console.WriteLine($"a={a}, b={b}, c={c}");
        }
        static void Swap(int x, ref int y, out int z)
        {
            x = 10;
            y = 20;
            //in this method the variable z (which stores the address of c, MUST BE assigned)
            z = 30;
            Console.WriteLine($"x={x}, y={y}, z={z}");
        }
    }
}
