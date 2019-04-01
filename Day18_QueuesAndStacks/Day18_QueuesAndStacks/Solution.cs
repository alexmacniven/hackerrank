using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    // Instance variables
    private Queue<Char> aQueue = new Queue<char>();
    private Stack<Char> aStack = new Stack<char>();

    // Enqueues 'c' into aQueue
    public void enqueueCharacter(char c)
    {
        aQueue.Enqueue(c);
    }

    // Pushes 'c' into aStack
    public void pushCharacter(char c)
    {
        aStack.Push(c);
    }

    // Dequeues the first char in aQueue
    public char dequeueCharacter()
    {
        return aQueue.Dequeue();
    }

    // Pops the top char from aStack
    public char popCharacter()
    {
        return aStack.Pop();
    }



    static void Main(String[] args)
    {
        // read the string s.
        string s = Console.ReadLine();

        // create the Solution class object p.
        Solution obj = new Solution();

        // push/enqueue all the characters of string s to stack.
        foreach (char c in s)
        {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }

        bool isPalindrome = true;

        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (obj.popCharacter() != obj.dequeueCharacter())
            {
                isPalindrome = false;

                break;
            }
        }

        // finally print whether string s is palindrome or not.
        if (isPalindrome)
        {
            Console.Write("The word, {0}, is a palindrome.", s);
        }
        else
        {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}