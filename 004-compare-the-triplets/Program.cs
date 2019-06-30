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
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var result = new List<int>();

        var aWins = 0;
        var bWins = 0;

        for (int i = 0; i < a.Count; i++)
        {
            var aScore = a[i];
            var bScore = b[i];

            if (IsValidScore(aScore, bScore))
            {
                if (aScore > bScore)
                {
                    aWins++;
                }
                else if (aScore < bScore)
                {
                    bWins++;
                }
            }
        }

        result.Add(aWins);
        result.Add(bWins);

        return result;
    }

    static bool IsValidScore(int score1, int score2)
    {
        return score1 > 0 && score1 <= 100 && score2 > 0 && score2 <= 100;
    }

    static void Main(string[] args)
    {
        List<int> a = new List<int> { 5, 6, 7 };

        List<int> b = new List<int> { 3, 6, 10 };

        List<int> result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));

        a = new List<int> { 17, 28, 30 };

        b = new List<int> { 99, 16, 8 };

        result = compareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}
