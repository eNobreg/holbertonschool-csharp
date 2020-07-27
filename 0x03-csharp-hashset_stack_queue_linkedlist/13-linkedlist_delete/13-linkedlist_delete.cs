using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int i = 0;
        if (index > myLList.Count)
            return;
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }
        while (current.Next != null)
        {
            i++;
            current = current.Next;
            if (i == index)
                break;
        }
        myLList.Remove(current);
    }
}
