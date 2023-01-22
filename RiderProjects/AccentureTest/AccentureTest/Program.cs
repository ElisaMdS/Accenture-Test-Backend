 using System;
 using System.Collections.Generic;
 using System.Linq;

IDictionary<string, int> dict = new Dictionary<string, int>()
{
    { "A", -50 },
    { "C", -13500 },
    { "S", 200 },
    { "P", 13000 },
    { "M", 550 },
    { "K", -20 },
    { "B", 40 },
    { "N", 0 }
};

var intTemp = Convert.ToInt32(Console.ReadLine());
if(intTemp <= 0) Console.WriteLine($"{0} {0}");

var entry = Console.ReadLine().Split(" ");
if (entry.All(item => item == "N")) Console.WriteLine($"{0} {0}");

var currentSum = 0;
var currentNegativeSum = 0;
var maxNegativeInterval = 0;
var maxPositiveInterval = 0;
foreach (var item in entry)
{
    currentSum = Math.Max(dict[item], currentSum + dict[item]);
    maxPositiveInterval = Math.Abs(maxPositiveInterval) > Math.Abs(currentSum) ? maxPositiveInterval : currentSum;

    currentNegativeSum = Math.Min(dict[item], currentNegativeSum + dict[item]);
    maxNegativeInterval = Math.Min(maxNegativeInterval, currentNegativeSum);
}

Console.WriteLine($"{maxPositiveInterval} {maxNegativeInterval}");