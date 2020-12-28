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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        int i = 0;
        int[] result = new int[a.Length];
        while (i < d)
        {
            i++;
            int[] elem = new int[] { a[0] };
            Array.Copy(a,1,result, 0, a.Length-1);
            Array.Copy(elem,0, result, a.Length - 1, elem.Length);
            a = result;
        }
        return result;
    }

    static void Main(string[] args)
    {
        string path = Path.GetFullPath(@"..\..\..\");

        string[] lines = File.ReadAllLines(path + "data.txt");
        string[] nd = lines[0].Split();

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);
        int i = 0;
        string[] data = lines[1].Split();
        int[] a = new int[data.Length];
        foreach (string item in data)
        {
            a[i] = int.Parse(item);
            i++;
        }
        DateTime start = DateTime.Now;
        int[] result = rotLeft(a, d);
        DateTime end = DateTime.Now;
        Console.WriteLine(string.Join(" ", result));
        Console.WriteLine(end - start);
    }


}