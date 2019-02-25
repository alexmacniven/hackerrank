using System;
using System.Collections.Generic;
using System.Text;


class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.
        int ii;
        double dd;
        string ss;

        // Read and save an integer, double, and String to your variables.
        ii = Convert.ToInt32(Console.ReadLine());
        dd = Convert.ToDouble(Console.ReadLine());
        ss = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(ii + i);

        // Print the sum of the double variables on a new line.
        // (double).ToString(...) formats the double as a string with 1 floating point digit
        Console.WriteLine((dd + d).ToString("F1"));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + ss);

    }
}
