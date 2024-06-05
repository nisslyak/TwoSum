

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
    public static int[] TwoSum(int[] nums, int target)
    { 

        var numMap = new Dictionary<int, int>();

        var result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            int rightNum = target - nums[i];
            if (!numMap.ContainsKey(rightNum))
            {
                numMap[nums[i]] = i;
                rightNum = 0;
            }
            else 
            {
                result[0] = numMap[rightNum];
                result[1] = i;
                return result;
            }
        }
        return null;
    }
}

 class Solution
    {
    public static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

        int target = Convert.ToInt32(Console.ReadLine());

        int[] result = Result.TwoSum(arr, target);
    }
}