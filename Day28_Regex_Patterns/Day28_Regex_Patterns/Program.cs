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
    class RegexCheck
    {
        public Regex rgx;

        public RegexCheck()
        {
            this.rgx = new Regex(@".+@gmail.com$");
        }

    }

    static void Main(string[] args)
    {
        RegexCheck regexCheck = new RegexCheck();
        List<string> results = new List<string>();

        int N = Convert.ToInt32(Console.ReadLine());

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstNameEmailID = Console.ReadLine().Split(' ');

            string firstName = firstNameEmailID[0];

            string emailID = firstNameEmailID[1];

            if (regexCheck.rgx.IsMatch(emailID))
            {
                results.Add(firstName);
            }
        }
        results.Sort();
        foreach(string s in results)
        {
            Console.WriteLine(s);
        }
    }
}
