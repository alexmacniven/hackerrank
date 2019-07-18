using System;
using System.Collections.Generic;
using System.IO;

namespace Day26_Nested_Logic
{
    public class Solution
    {
        public static int CalculateFine(Dictionary<string, int> returnDate, Dictionary<string, int> dueDate)
        {
            if(returnDate["year"] < dueDate["year"])
            {
                return 0;
            }
            else // return year is either the same or equal
            {
                if(returnDate["year"] == dueDate["year"])
                {
                    if (returnDate["month"] <= dueDate["month"])
                    {
                        if (returnDate["day"] <= dueDate["day"])
                        {
                            return 0;
                        }
                        else
                        {
                            return 15 * (returnDate["day"] - dueDate["day"]);
                        }
                    }
                    else
                    {
                        return 500 * (returnDate["month"] - dueDate["month"]);
                    }
                }
                else
                {
                    return 10000;
                }
            }
        }

        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            Dictionary<string, int>[] datesArray = new Dictionary<string, int>[2];
            for(int i = 0; i < 2; i++)
            {
                string input = Console.ReadLine();
                string[] valArray = input.Split(' ');
                datesArray[i] = new Dictionary<string, int>();
                datesArray[i]["day"] = Convert.ToInt32(valArray[0]);
                datesArray[i]["month"] = Convert.ToInt32(valArray[1]);
                datesArray[i]["year"] = Convert.ToInt32(valArray[2]);
            }
            int fine = CalculateFine(datesArray[0], datesArray[1]);
            Console.WriteLine(Convert.ToString(fine));
        }
    }
}
