using System;
using System.Text;
// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".
// Example 1:
// Input: strs = ["flower","flow","flight"]
// Output: "fl"

// создать массив из 200 строк
// задать ячейки массиа
// выполнить сравнение ячеек

string LongestCommonPrefix(string[] strs)
{
    int size = strs.Length;
    int minLength = strs[0].Length;
    int minIndex = 0;
    for (int i = 1; i < size; i++)
    {
        if (strs[i].Length < minLength)
        {
            minLength = strs[i].Length;
            minIndex = i;
        }
    }
    string result = String.Empty;
    for (int i = 0; i < minLength; i++)
    {
        int count = 0;
        foreach (var item in strs)
        {
            if (item[i] == strs[minIndex][i]) count++;
        }
        if (count == size) result += strs[minIndex][i];
        else break;
    }
    return result;
}

string[] words = { "circle", "cir", "cifjs" };
Console.WriteLine(LongestCommonPrefix(words));