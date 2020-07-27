using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        List<int> myList = new List<int>(myLList);
        return (n > myList.Count - 1 || n < 0 ? 0 : myList[n]);
    }
}
