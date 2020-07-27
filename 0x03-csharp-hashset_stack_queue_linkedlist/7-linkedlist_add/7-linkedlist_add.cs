using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        myLList.AddFirst(newNode);
        return (newNode);
    }
}
