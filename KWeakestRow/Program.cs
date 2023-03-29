using System.Collections.ObjectModel;
using System.Diagnostics;

int[][] CreateArray(int m, int n)
{
    int[][] someArray = new int[m][];
    for (int i = 0; i < m; i++) someArray[i] = new int[m];
    return someArray;
}


void FillArrayRandomIter(int[][] anyArray)
{
    int height = anyArray.Length;
    for (int i = 0; i < height; i++)
    {
        int length = anyArray[i].Length;
        int onesLength = new Random().Next(0, length + 1);

        for (int j = 0; j < onesLength; j++) anyArray[i][j] = 1;
    }
}

void ArrayToConsole(int[][] anyArray)
{
    int height = anyArray.Length;
    for (int i = 0; i < height; i++) Console.WriteLine(String.Join(" ", anyArray[i]));
}

int[] KWeakestRows(int[][] mat)
{
    int sumsLength = mat.Length;
    int[] sumOfRow = new int[sumsLength];
    for (int i = 0; i < sumsLength; i++)
    {
        int length = mat[i].Length;
        int j = 0;

        for (j = 0; j < length; j++)
            if (mat[i][j] != 1) break;
        sumOfRow[i] = j;
    }
    Console.WriteLine();
    Console.WriteLine(String.Join(" ", sumOfRow));

    int k = 5;
    var weakest = new List<int>();
    for (int i = 0; i < k; i++)
    {
        int max = sumOfRow.Max();
        int pivot = Array.IndexOf(sumOfRow, max);
        for (int j = 0; j < sumsLength; j++)
        {

            if (!weakest.Contains(j) && sumOfRow[j] < sumOfRow[pivot])
                pivot = j;
        }
        weakest.Add(pivot);
    }





    int[] aInt = weakest.ToArray();
    return aInt;
}

int[][] someArray = CreateArray(5, 5);
Stopwatch sw = new Stopwatch();
sw.Start();
FillArrayRandomIter(someArray);
ArrayToConsole(someArray);
var result = KWeakestRows(someArray);
Console.WriteLine();
Console.WriteLine(String.Join(" ", result));
sw.Stop();
Console.WriteLine($"{sw.ElapsedMilliseconds}");


