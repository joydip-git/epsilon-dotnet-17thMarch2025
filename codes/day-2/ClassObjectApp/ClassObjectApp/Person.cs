using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectApp
{
    class Person
    {
        //data members (characterestics)
        string name;
        string location;
        long mobileNo;
        DateTime? dateOfBirth;
        //allows this data member to be set ONLY using CONSTRUCTOR
        readonly int id;
        //const members MUST be assigned directly while declaring them
        public const string COMPANY = "Epsilon";

        //default ctor
        public Person() { }

        //parameterized ctor
        //Nullable<DateTime> dateOfBirth => optional argument with default value
        //optional arguments should be the last ones in the method's argument list
        public Person(string name, int id, string location = "", long mobileNo = 0, Nullable<DateTime> dateOfBirth = null)
        {
            this.name = name;
            this.id = id;
            this.location = location;
            this.mobileNo = mobileNo;
            this.dateOfBirth = dateOfBirth;
        }

        //Expression Body syntax
        //public string GetName() => name;
        //public void SetName(string name) => this.name = name;

        //read-only property
        //public int Id
        //{
        //    get => id;
        //    //set => id = value;
        //}

        //read-only property with expression body syntax
        public int Id => id;

        public string Name
        {
            set => name = value;
            get => name;
        }

        public long MobileNo
        {
            set => mobileNo = value;
            get => mobileNo;
        }

        public DateTime? DateOfBirth
        {
            set => dateOfBirth = value;
            get => dateOfBirth;
        }
        
        //property
        public string Location
        {
            //public string GetLocation() => location;
            
            //getter or get accessor
            get => location;

            //public void SetLocation(string location) => this.location = location;
            
            //setter or set accessor
            set => this.location = value;
        }

        public string PrintInformation()
        {
            //string interpolation
            return $"Name={this.name}, From={location}, Mobile={mobileNo}, Date Of Birth={dateOfBirth}";
        }
    }
}
