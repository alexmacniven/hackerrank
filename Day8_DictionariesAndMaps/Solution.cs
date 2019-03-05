using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int tests = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        for(int i = 0; i < tests; i++)
        {
            string input = Console.ReadLine();
            string[] elems = input.Split(' ');
            phoneBook.Add(elems[0], elems[1]);
        }

        string[] argarr= new string[tests];

        for(int i = 0; i < tests; i++)
        {
            string query = Console.ReadLine();
            argarr[i] = query;
        }

        foreach (string item in argarr)
        {
            try
            {
                Console.WriteLine(item + "=" + phoneBook[item]);
            }
            catch (KeyNotFoundException)
            {

                Console.WriteLine("Not found");
            }
        }
    }
}