using System;
using System.Collections;

namespace CollectionsDemAss
{
    class BitArrayDemo
    {
        BitArray BA = new BitArray(10);
        
    }
    class ArrayBit
    {
        public void PrintBitArray(IEnumerable IE)
        {
            System.Collections.IEnumerator IEN = IE.GetEnumerator();
            while(IEN.MoveNext())
            {
                Console.Write("\t{0}", IEN.Current);
            }
        }
    }
}
