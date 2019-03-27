using System;


namespace Day3_Conditions
{
    class Solution
    {

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if ((N >= 6) && (N <= 20))
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.Write("Not Weird");
            }

            Console.ReadLine();
        }
    }
}
