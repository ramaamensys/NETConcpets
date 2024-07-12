using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcpets
{
    //class declaration, it will start class keyword followed by classname
    class OppsBasics
    {   //beign of the class

        //property will hold the data
        //data type and property name

        public String Color;
        int NoofDoors;
        public double price;

        //create a method
        //it will have void then methodname
        //create a method with vood is nothing but method with no retuen value
        public void printHelloWorld()
        {     //begin of method

            Console.WriteLine("From printHelloWorld method");
        }     //end of method

        public void Addition() {

        }

        public void Mutliply()
        {
            Color = "red";
            NoofDoors = 10;
            price = 550.45;
        }

        //create a method with parameter
        //declaring paramter is simllar to property
        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("printing num1 " + num1 + " and num2 " + num2);
            //assign the value to prperty
            Color = "green";
            NoofDoors = 3;
            price = 450.45;

            //assign the value to paramter
            num1 = 20;
            num2 = 40;

            Console.WriteLine("printing num1 " + num1 + " and num2 " + num2);

        }

        //create a method with retuen value
        //return data type and method name
        //return keyword should return the value of return data type
        public int CombineTwoValues()
        {

            return 10;
        }

        public String ParseString()
        {

            return "test";
        }

        public void printColor()
        {
            Console.WriteLine("Color value is " + Color);
        }

    }   //end of the class
}
