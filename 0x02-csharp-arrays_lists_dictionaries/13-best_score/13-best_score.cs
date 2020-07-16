using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string stored_key = "None";
        int stored_value = 0;
        foreach(KeyValuePair<string, int> entry in myList) {
            if (stored_value < entry.Value)
                stored_key = entry.Key;
        }
        return (stored_key);
    }
}
