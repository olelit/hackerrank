using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int result = 0;
        int[] countArr = new int[ar.Length];
        int i = 0;
        foreach (var item in ar)
        {
            if(countArr.Count(ch=>ch == item) == 0)
            {
                int elemCount = ar.Count(ch => ch == item);
                result += elemCount / 2;
                countArr[i] = item;
                i++;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        int n = 9;
        int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}