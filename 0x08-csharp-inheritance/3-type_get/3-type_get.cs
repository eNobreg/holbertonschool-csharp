using System;
using System.Collections.Generic;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type t = myObj.GetType();

        IEnumerable<PropertyInfo> propertyList = t.GetProperties();
        IEnumerable<MethodInfo> methodList = t.GetMethods();

        Console.WriteLine(t.Name + " Properties:");

        foreach(var entry in propertyList)
        {
            Console.WriteLine(entry.Name);
        }

        Console.WriteLine(t.Name + " Methods:");

        foreach(var entry in methodList)
        {
            Console.WriteLine(entry.Name);
        }
    }
}
