using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newLinked = new LinkedList<int>( size > 0 ? Enumerable.Range(0, size).ToArray() : Enumerable.Range(0,0).ToArray());
        foreach (int entry in newLinked)
            Console.WriteLine(entry);
        return (newLinked);
    }
}
