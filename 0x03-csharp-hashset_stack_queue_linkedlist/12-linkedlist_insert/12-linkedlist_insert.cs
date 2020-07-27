using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;

        if (current == null)
        {
            myLList.AddFirst(newNode);
            return (newNode);
        }
        if (current.Value > n)
        {
            myLList.AddBefore(current, newNode);
            return (newNode);
        }
        while (current.Next != null)
        {
            if (current.Next.Value >= n)
                break;
            current = current.Next;
        }
        myLList.AddAfter(current, newNode);
        return (newNode);
    }
}
