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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int diagonalSum = 0;
        int revDiagonalSum = 0;
        int noOfRows = arr[0].Count;
        
        int diagDiff = 0;
        
        for(int i = 0; i < arr[0].Count; i++)
        {
            for(int j = 0; j < arr[1].Count; j++)
            {
                if(i == j)
                {
                    diagonalSum += arr[i][j];
                }
                if((i + j) == (noOfRows - 1))
                {
                    revDiagonalSum += arr[i][j];
                }
            }
        }
        
        diagDiff = Math.Abs(diagonalSum - revDiagonalSum);
        
        return diagDiff;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
