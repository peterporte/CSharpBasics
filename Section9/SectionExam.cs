using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section10
{
    [TestClass]
    public class SectionExam
    {
        [TestMethod]
        public void List_Cleaner()
        {
            ArrayList dataList = new ArrayList();
            dataList.Add("Someday");
            dataList.Add(2);
            dataList.Add("app");
            dataList.Add(13.5);
            dataList.Add("red");
            dataList.Add(8);
            dataList.Add(99);
            dataList.Add("6");
            dataList.Add("Meatball Soup");
            dataList.Add(18M);
            dataList.Add("pieces");
            dataList.Add("14");

            ArrayList goodValues = CheckList(dataList);

            List_Good_Values(goodValues);

            int sum = Total_Data(goodValues);
          
            Assert.AreEqual(147, sum);

        }


        public ArrayList CheckList(ArrayList list)
        {
            ArrayList goodVals = new ArrayList();

            foreach (var item in list)
            {
                int aValue;
                if (int.TryParse(Convert.ToString(item), out aValue) == true)
                {
                    goodVals.Add(aValue);
                }
            }

            return goodVals;
        }

        public int Total_Data(ArrayList list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }

            return sum;
        }

        public void List_Good_Values(ArrayList list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
