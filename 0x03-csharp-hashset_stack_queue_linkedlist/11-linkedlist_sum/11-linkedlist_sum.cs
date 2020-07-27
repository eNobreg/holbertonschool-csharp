using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        // List<int> myList = new List<int>(myLList);
        // return (n > myList.Count - 1 || n < 0 ? 0 : myList[n]);
        LinkedListNode<int> current = myLList.First;
        int total = 0;
        while (current != null) {
            total += current.Value;
            current = current.Next;
        }
        return(total);
    }
}
