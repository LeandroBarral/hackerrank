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

    private const int SEA_LEVEL = 0;
    private const char UPHILL = 'U';
    private const char DOWNHILL = 'D';

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        Console.WriteLine("[ROUND] :: steps {0}", s);

        var valleys = 0;

        var steps = s.ToCharArray();

        var currentLevel = 0;

        var isInTheValley = false;

        foreach (var step in steps)
        {
            SetLevel(step, ref currentLevel);
            Console.WriteLine("step {0} | currentLevel {1}", step, currentLevel);

            if (currentLevel <= -1)
            {
                isInTheValley = true;
            }
            else if (currentLevel == 0 && isInTheValley)
            {
                isInTheValley = false;
                valleys++;
            }
        }

        return valleys;
    }

    private static void SetLevel(char step, ref int currentLevel)
    {
        if (step.Equals(UPHILL))
        {
            currentLevel++;
        }
        else if (step.Equals(DOWNHILL))
        {
            currentLevel--;
        }
    }

    static void Main(string[] args)
    {
        int n = 8;

        string s = "UDDDUDUU";

        int result = countingValleys(n, s);

        Console.WriteLine(result);

        n = 12;

        s = "DDUUDDUDUUUD";

        result = countingValleys(n, s);

        Console.WriteLine(result);

        n = 10;
        s = "DUDDDUUDUU";

        result = countingValleys(n, s);

        Console.WriteLine(result);
    }
}
