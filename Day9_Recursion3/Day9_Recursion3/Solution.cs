/*
 * factorial - the product of an integer and all the integers below it; e.g. factorial four ( 4! ) is equal to 24.
 * 
 * This solution solves Day 9 of HackerRanks 30 Days of Code.
 */
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static int Factorial(int n)
    {
        if(n == 1)
        {
            return n;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(n);

        // textWriter.WriteLine(result);
        Console.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
        Console.ReadLine();
    }
}
