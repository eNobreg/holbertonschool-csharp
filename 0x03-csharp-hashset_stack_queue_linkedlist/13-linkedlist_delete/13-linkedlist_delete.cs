using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int i = 0;
        if (index == 0)
            myLList.RemoveFirst();
        while (current.Next != null)
        {
            i++;
            current = current.Next;
            if (i == index)
            {
                myLList.Remove(current);
                break;
            }
        }
        
    }
}
