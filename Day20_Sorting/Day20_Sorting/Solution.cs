using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        
        int numSwaps = 0;

        for(int i = 0; i < n; i++)
        {
            int numberOfSwaps = 0;

            for(int j = 0; j < n -1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    swap(ref a[j], ref a[j +1]);
                    numberOfSwaps++;
                    numSwaps++;
                }
            }

            if(numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine("Array is sorted in " + numSwaps.ToString() + " swaps.");
        Console.WriteLine("First Element: " + a[0].ToString());
        Console.WriteLine("Last Element: " + a[n -1].ToString());

    }
}

