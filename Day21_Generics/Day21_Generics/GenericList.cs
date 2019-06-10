using System;
using System.Collections.Generic;
using System.Text;

namespace More_Generics
{
    public class GenericList<T>
    {
        private List<T> data;

        public GenericList()
        {
            data = new List<T>();
        }

        public void Add(T t)
        {
            data.Add(t);
        }

        public T Pop()
        {
            try
            {
                return data[0];
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
        }
       
    }

    //class TestGenerics
    //{
    //    static void Main(string[] args)
    //    {
    //        GenericList<int> IntList = new GenericList<int>();
    //        IntList.Add(23);
    //        Console.WriteLine(IntList.Pop());

    //        GenericList<string> StrList = new GenericList<string>();
    //        StrList.Add("Hello");
    //        StrList.Add("World");
    //        Console.WriteLine(StrList.Pop());
    //        Console.ReadLine();
    //    }
    //}
}