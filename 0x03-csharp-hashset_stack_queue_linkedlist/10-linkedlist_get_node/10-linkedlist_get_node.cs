using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // List<int> myList = new List<int>(myLList);
        // return (n > myList.Count - 1 || n < 0 ? 0 : myList[n]);
        LinkedListNode<int> current = myLList.First;
        int index = 0;
        if (n > myLList.Count - 1 || n < 0)
            return (0);
        while (current != null) {
            if (index == n)
                return (current.Value);
            index += 1;
            current = current.Next;
            
        }
        return(0);
    }
}
