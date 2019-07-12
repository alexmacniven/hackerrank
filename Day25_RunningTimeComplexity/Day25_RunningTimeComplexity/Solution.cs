using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static bool PrintPrime(int number)
    {
        for(int i = number - 1; i > 1; i--)
        {
            if(number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool PrintPrimev2(int number)
    {
        if(number == 1)
        {
            return false;
        }
        for (int i = (int)Math.Sqrt(number); i > 1; i--)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main(String[] args)
    {
        /* Enter your code here. 
         * Read input from STDIN. 
         * Print output to STDOUT. 
         * Your class should be named Solution 
         */
        int T = Int32.Parse(Console.ReadLine());
        int[] numbers = new int[T];
        for(int i = 0; i < T; i++)
        {
            numbers[i] = Int32.Parse(Console.ReadLine());
        }

        for(int i = 0; i < T; i++)
        {
            if(PrintPrimev2(numbers[i]))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
        Console.ReadLine();
    }
}
