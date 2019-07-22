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

public class Solution
{

    public static int FindMaxLegalValue(int size, int limit)
    {
        int maxLegal = 0;
        for(int i = 1; i < size; i++)
        {
            for(int j = i + 1; j <= size; j++)
            {
                int result = i & j;
                if((result < limit) && (result > maxLegal))
                {
                    maxLegal = result;
                }
            }
        }
        return maxLegal; 
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        int[] r = new int[t];
        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);
            r[tItr] = FindMaxLegalValue(n, k);
        }

        foreach(int i in r)
        {
            Console.WriteLine(i);
        }

    }
}

