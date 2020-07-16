using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        myDict = myDict.ToDictionary(p => p.Key, p => p.Value * 2);
        return (myDict);
    }
}
