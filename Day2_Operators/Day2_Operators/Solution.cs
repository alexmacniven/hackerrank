using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Operators
{
    class Solution
    {
        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            // Calculate tip_percent value as double
            double tip_value;
            tip_value = meal_cost * (double)tip_percent / 100;

            // Calculate tax_percent value as double
            double tax_value;
            tax_value = meal_cost * (double)tax_percent / 100;

            double total;
            total = meal_cost + tip_value + tax_value;

            Console.WriteLine((int)Math.Round(total, MidpointRounding.AwayFromZero));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Solve(meal_cost, tip_percent, tax_percent);

            Console.ReadLine();
        }
    }
}

