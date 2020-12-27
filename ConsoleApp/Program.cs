using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static int solveMeFirst(int a, int b)
    {
        // Hint: Type return a+b; below  
        a = 2;
        b = 3;
        return a + b;

    }

    static void Main(String[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(a, b);
        Console.WriteLine(sum);
    }
}