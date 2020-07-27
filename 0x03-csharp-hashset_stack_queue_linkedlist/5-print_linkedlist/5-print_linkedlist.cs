using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        
        LinkedList<int> newLinked = new LinkedList<int>(Enumerable.Range(0, size).ToArray());
        foreach (int entry in newLinked)
            Console.WriteLine(entry);
        return (newLinked);
    }
}
