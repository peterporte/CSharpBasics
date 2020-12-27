using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Car
    {
        //private variables to help define properties of car
        string color;
        int numberOfDoor;
        bool isConvertible;


        //Contructor - factory for creating objects for a class
        public Car(string carColor, int doors, bool convertible)
        {
            Color = carColor;
            NumberOfDoor = doors;
            IsConvertible = convertible;

        }


         //Get and Set Accessors - properties that define noun-like properties of a class
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int NumberOfDoor
        {
            get { return numberOfDoor; }
            set
            {
                if (numberOfDoor <= 4)
                {
                    numberOfDoor = value;
                }
                else
                {
                    //give user some error
                }
            }
        }

        public bool IsConvertible
        {
            get; set;
        }


        //Method - verb attributes that tell what a class can do
        public void Accelerating()
        {
            Console.WriteLine("I am accelerating");
        }

        public bool FamilyCar()
        {
            if (NumberOfDoor >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
