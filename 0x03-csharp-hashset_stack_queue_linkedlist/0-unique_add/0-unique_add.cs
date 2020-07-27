using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        foreach (int entry in myList.Distinct().ToList()) {
            total += entry;
        }
        return(total);
    }
}
