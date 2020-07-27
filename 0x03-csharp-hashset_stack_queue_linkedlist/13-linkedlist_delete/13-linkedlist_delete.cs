﻿using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int i = 0;

        if (current == null)
        {
            return;
        }
        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }
        while (current.Next != null)
        {
            if (i == index)
                break;
            i++;
            current = current.Next;
        }
        myLList.Remove(current);
    }
}
