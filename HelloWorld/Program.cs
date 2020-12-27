using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
            // string variable
            string userFirstName;
            string age;

            //ask the user a question
            Console.WriteLine("What is your name?");
            userFirstName = Console.ReadLine();
            Console.WriteLine(("How old are you?"));
            age = Console.ReadLine();

            //Concatenate the string
            //string response = "your name is " + userFirstName + " and you are " + age + " years old";

            //interpolate the string
            string response = $"Your name is {userFirstName} and your are {age} years old";

            //write out the response
            Console.WriteLine(response);         //Console.WriteLine("your name is " + userFirstName + " and you are " + age + " years old");
            */

            //==========================================================
            /*
            //variables
            string itemsName = "Widget";
            double pricePerOunce = 17.36;
            string outputString;

            //format output
            outputString = String.Format("{0,10} {1,10}", itemsName, pricePerOunce);

            //output to user
            Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));
            Console.WriteLine(outputString);
            */
            //==========================================================



            double givenFahrenheit;
            

            Console.WriteLine("Enter Fahrenheit temperature: ");
            
            givenFahrenheit = Convert.ToDouble(Console.ReadLine());

            double celToFahFormula = (givenFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"The temp in F {givenFahrenheit} is {celToFahFormula} in C");



        }
    }
}
