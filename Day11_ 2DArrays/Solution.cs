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



    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int best_score = -99;
        int current_score = 0;

        for(int yaxis = 0; yaxis <= arr.Length - 3; yaxis++)
        {
            for(int xaxis = 0; xaxis <= arr[yaxis].Length - 3; xaxis++)
            {
                current_score = arr[yaxis][xaxis] + arr[yaxis][xaxis + 1] + arr[yaxis][xaxis + 2] + 
                    arr[yaxis + 1][xaxis + 1] + arr[yaxis + 2][xaxis] + arr[yaxis + 2][xaxis + 1] + 
                    arr[yaxis + 2][xaxis + 2];
                if(current_score > best_score)
                {
                    best_score = current_score;
                }
            }
        }

        Console.WriteLine(Convert.ToString(best_score));
        Console.ReadLine();
    }
}