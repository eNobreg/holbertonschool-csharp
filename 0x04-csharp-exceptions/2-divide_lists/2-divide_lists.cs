using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();
        int i = 0;
        int result = 0;
        for (i = 0; i < listLength; i++) {
            try {
                result = list1[i] / list2[i];
                resultList.Add(result);
            } catch (DivideByZeroException) {
                Console.WriteLine("Cannot divide by zero");
                resultList.Add(0);
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Out of range");
            }
        }
        return(resultList);

    }
}
