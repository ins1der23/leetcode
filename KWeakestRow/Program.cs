using System.Collections.ObjectModel;
using System.Diagnostics;

int[][] CreateArray(int m, int n)
{
    int[][] someArray = new int[m][];
    for (int i = 0; i < m; i++) someArray[i] = new int[n];
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

int[] KWeakestRows(int[][] mat, int k)
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
    var weakest = new List<int>();
    int pivot = 0;
    int min = 0;
    for (int p = 0; p < sumsLength; p++)
    {
        if (sumOfRow[p] > sumOfRow[pivot]) pivot = p;
    }
    for (int i = 0; i < k; i++)
    {
        for (int p = 0; p < sumsLength; p++)
        {
            if (sumOfRow[p] > sumOfRow[pivot]) pivot = p;
        }
        for (int j = sumsLength - 1; j >= 0; j--)
        {
            if (!weakest.Contains(j) && sumOfRow[j] < (sumOfRow[pivot] + 1))
                pivot = j;
        }
        weakest.Add(pivot);
    }
    int[] weakestArray = weakest.ToArray();
    return weakestArray;
}

int[][] someArray = CreateArray(7, 3);
Stopwatch sw = new Stopwatch();
sw.Start();
FillArrayRandomIter(someArray);
ArrayToConsole(someArray);
var result = KWeakestRows(someArray, 6);
Console.WriteLine();
Console.WriteLine(String.Join(" ", result));
sw.Stop();
Console.WriteLine($"{sw.ElapsedMilliseconds}");


