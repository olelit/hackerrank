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

    static bool inMatrix(int[][] arr, int x, int y)
    {
        int[] leftTop = { 0, 0 };
        int[] rightBottom = { arr.GetLength(0) - 1, arr[0].Length - 1 };

        if(x > leftTop[0] && x < rightBottom[0] && y > leftTop[1] && y < rightBottom[1])
        {
            return true;
        }

        return false;
    }

    static int summSmallMatrix(int[][] arr, int x, int y)
    {
        int sum = 0;
        int[][] smallMatrix =
        {
            new int[3] { arr[y-1][x-1], arr[y-1][x], arr[y-1][x+1] },
            new int[1] { arr[y][x] },
            new int[3] { arr[y+1][x-1], arr[y+1][x], arr[y+1][x+1] },
        };
        foreach (int[] row in smallMatrix)
        {
            foreach(int col in row)
            {
                sum += col;
            }
        }
        return sum;
    }

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        int result = 0;

        for (int y = 1; y < arr.GetLength(0); y++)
        {
            for (int x = 1; x < arr[y].Length; x++)
            {
                if (inMatrix(arr, x, y))
                {
                    int sum = summSmallMatrix(arr, x, y);
                    if (sum > result || (x==1 && y == 1))
                    {
                        result = sum;
                    }

                    
                }
            }
        }
        return result;

    }

    static void Main(string[] args)
    {
        int[][] arr = new int[6][] 
        { 
            new int[6] { -1,1,-1,0,0,0}, 
            new int[6] { 0,-1,0,0,0,0}, 
            new int[6] { -1,-1,-1,0,0,0}, 
            new int[6] { 0,-9,2,-4,-4,0}, 
            new int[6] { -7,0,0,-2,0,0}, 
            new int[6] { 0,0,-1,-2,-4, 0}, 
        };
        int result = hourglassSum(arr);
        Console.WriteLine(result);
    }
}
