using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        List<int> myList = new List<int>(myLList);
        return (myList.Capacity);
    }
}
