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

    static string ConvertToBase2(int number)
    {
        Stack<string> numbers = new Stack<string>();
        string result = "";
        while(number > 0)
        {
            string remainder = Convert.ToString(number % 2);
            numbers.Push(remainder);
            number = number / 2;
        }
        while(numbers.Count > 0)
        {
            result = result + numbers.Pop();
        }
        return result;
    }

    static int CountConseqs(string binary)
    {
        int best = 0;
        int current = 0;

        foreach(Char c in binary)
        {
            if(c == '1')
            {
                current++;
            }
            else
            {
                if(current > best)
                {
                    best = current;
                }
                current = 0;
            }
        }
        return Math.Max(best, current);
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string binary = ConvertToBase2(n);
        int conseqs = CountConseqs(binary);
        Console.WriteLine(conseqs);
        Console.ReadLine();
    }
}