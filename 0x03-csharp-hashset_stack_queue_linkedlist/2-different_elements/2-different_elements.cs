using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int>();
        list1.ForEach(delegate(int entry) {if (!list2.Contains(entry)) {newList.Add(entry);}});
        list2.ForEach(delegate(int entry) {if (!list1.Contains(entry)) {newList.Add(entry);}});
        newList.Sort();
        return (newList);

    }
}
