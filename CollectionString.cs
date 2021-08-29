using System;
using System.Collections;
using System.Collections.Specialized;

namespace CollectionsDemAss
{
    class CollectionString
    {
        static void Main(string[] args)
        {
            StringCollection SC = new StringCollection();
            SC.Add("Vivek");
            SC.Add("Krunal");
            SC.Add("Nirbhay");
            SC.Add("Abhi");
            Console.WriteLine("Number of Items :"+SC.Count);
            StringCollectionDemo SCD = new StringCollectionDemo();
            SCD.PrintStrngCollection(SC);
        }
    }
    class StringCollectionDemo
    {
        public void PrintStrngCollection(IEnumerable IE)
        {
            System.Collections.IEnumerator IEN = IE.GetEnumerator();
            while (IEN.MoveNext())
            {
                Console.WriteLine(IEN.Current);
            }
        }
    }
}
