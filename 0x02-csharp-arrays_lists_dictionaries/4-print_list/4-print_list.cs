﻿using System;
using System.Linq;
using System.Collections.Generic;

class List 
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        List<int> num_list = Enumerable.Range(0, size).ToList();
        Console.WriteLine(string.Format("{0}", string.Join(" ", num_list)));;
        return (num_list);
    }
}
