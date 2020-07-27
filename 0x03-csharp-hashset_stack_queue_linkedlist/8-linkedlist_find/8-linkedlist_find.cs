using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        List<int> myList = new List<int>(myLList);
        return (myList.IndexOf(value));
    }
}
