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

class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int count = 0;
        int amplitude = 0;
        foreach (char item in path)
        {
            if(item == 'U')
            {
                if (amplitude == -1)
                    count++;

                amplitude++;
            }
            else
            {
                amplitude--;
            }
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int steps = Convert.ToInt32(Console.ReadLine().Trim());

        //string path = Console.ReadLine();
        string path = "UDDDUDUU";
        int steps = 8;

        int result = Result.countingValleys(steps, path);
        Console.WriteLine(result);
        Console.ReadKey();
        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}