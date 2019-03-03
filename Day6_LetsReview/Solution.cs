using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void EvenOddSplit(string[] inputs)
    {
        foreach(string input_string in inputs)
        {
            string evens = "";
            string odds = "";

            for (int i = 0; i < input_string.Length; i++)
            {
                if ((i % 2 == 0) || (i == 0))
                {
                    evens = evens + input_string[i];
                }
                else
                {
                    odds = odds + input_string[i];
                }
            }
            Console.WriteLine(evens + " " + odds);
        }
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // Get the number of test cases
        int test_size = int.Parse(Console.In.ReadLine());
        string[] tests = new string[test_size];


        for(int i = 0; i < test_size; i++)
        {
            string input = Console.In.ReadLine();
            tests[i] = input;
        }

        EvenOddSplit(tests);
        Console.In.ReadLine();
    }
}


