using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printed = 0;
        for(int i = 0; i < n; i++) {
            try {
                printed++;
                Console.WriteLine("{0}", myList[i]);
            } catch {
                printed--;
            }
        }
        return(printed);
    }
}
