using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        arr = arr.Reverse().ToArray();
        StringBuilder sb = new StringBuilder();
        foreach (int arrElement in arr)
        {
            sb.AppendFormat("{0} ", arrElement);
        }
        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}
