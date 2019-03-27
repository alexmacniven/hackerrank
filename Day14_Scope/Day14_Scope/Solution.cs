using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        Array.Sort(this.elements);
        for(int i = 0; i < this.elements.Length - 1; i++)
        {
            int difference = Math.Abs(this.elements[i] - this.elements[this.elements.Length - 1]);
            if(difference > this.maximumDifference)
            {
                this.maximumDifference = difference;
            }
        }
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}