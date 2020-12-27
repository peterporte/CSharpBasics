using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section6
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void Using_String_Class()
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
        }

        [TestMethod]
        public void Joining_Strings_Together()
        {
            char[] chars = {'H', 'e', 'l', 'l', 'o'};
            string joinChar = new string(chars);
            Console.WriteLine(joinChar);
        }
    }
}
