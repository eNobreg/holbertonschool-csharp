using System;
using System.Linq;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string stored_key = "None";
        int stored_value = -999;
        foreach(KeyValuePair<string, int> entry in myList) {
            if (stored_value < entry.Value)
            {
                stored_value = entry.Value;
                stored_key = entry.Key;
            }
        }
        if (stored_value = -999)
            stored_key = "None";
        return (stored_key);
    }
}
