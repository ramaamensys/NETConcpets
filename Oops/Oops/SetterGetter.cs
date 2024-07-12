using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    class SetterGetter
    {
        //private properties
        private string privatename;
        private int age;
        private string country;
        private string county;

        //Constructor, default constructor
        public SetterGetter()
        {
            country = "USA";
            Console.WriteLine("I am inside the construcot");
        }

        //parameterized constructor
        public SetterGetter(int param1)
        {
            country = "USA";
            Console.WriteLine("I am parameterized constructor with intgers");
        }

        public SetterGetter(string param1)
        {
        
            Console.WriteLine("I am inside the constructor with string data type");
        }

        public string PublicName
        {
            get { return privatename; }
            set { privatename = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //readonly access
        public string Country
        {
            get { return country; }
        }

        //auto-impmemented properties
        public string PhoneNumber { get; set; }
        public string City { get; }

        //County just write only
        public string County 
        {
            set { county = value; }
         }

        //assigning the values to private propeties
        public void setDefaultValues()
        {
            country = "USA";
        }

        public void checkValidation()
        {
            Console.WriteLine("Insde the checkValidation ");
        }
    }
}
