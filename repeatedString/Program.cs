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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long result = 0;
        long aCount = s.Count(ch => ch == 'a');
        long limit = n / s.Length;
        decimal mul = aCount * limit;
        long fix = (n % s.Length);
        //result = (long)Math.Round(mul);

        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a')
            {
                result += limit;
                if(i < fix)
                {
                    result++;
                }
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(repeatedString("aba", 10));
        Console.WriteLine(repeatedString("jdiacikk", 899491));
        Console.WriteLine(repeatedString("ceebbcb", 817723));
        Console.WriteLine(repeatedString("a", 1000000000000));
        Console.WriteLine(repeatedString("gfcaaaecbg", 547602));


        Console.ReadKey();
    }
}
