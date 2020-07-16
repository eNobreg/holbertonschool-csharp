using System;
using System.Collections.Generic;

class List 
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int counter = 0;
        List<bool> result = new List<bool>();

        for (counter = 0; counter <= myList.Count - 1; counter++) {
            result.Add((myList[counter] % 2 == 0) ? true : false);
        }
        return (result);
    }
}
