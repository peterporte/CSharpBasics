using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test_Creating_List()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add("Test");
            myArray.Add(1);
            myArray.Add(9);
            Console.WriteLine(myArray.Count);
            myArray.Remove(9);
            Console.WriteLine(myArray.Count);

        }

        [TestMethod]
        public void Testing_Array_List()
        {
            ArrayList myArrayList = new ArrayList();
            Fill_list(myArrayList);


            int sum = Total_Array(myArrayList);
            Console.WriteLine(sum);
            
            Assert.AreEqual(15, sum);

        }

        public void Fill_list(ArrayList myArrayList)
        {
            for (int i = 0; i <= 5 ; i++)
            {
                myArrayList.Add(i);
            }
        }

        public int Total_Array(ArrayList myArrayList)
        {
            int sum = 0;
            foreach (int value in myArrayList)
            {
                sum += value;
            }

            return sum;
        }

        [TestMethod]
        public void ArrayList_Practice()
        {
         ArrayList myList = new ArrayList();
            myList.Add(99);
            myList.Add(1);
            myList.Add(75);
            myList.Add(18);
            myList.Add(55);
            myList.Add(32);

            Console.WriteLine("Count: {0}", myList.Count);
            Console.WriteLine($"Capacity: {myList.Capacity}");

            foreach (int i in myList)
            {
                Console.WriteLine(i + " ");
            }

            myList.Sort();
            foreach (int i in myList)
            {
                Console.WriteLine(i + " ");
            }
        }

        

    }
}
