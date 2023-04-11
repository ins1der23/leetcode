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
    int maxI = 0;
    for (int p = 0; p < sumsLength; p++)
    {
        if (sumOfRow[p] > sumOfRow[maxI]) maxI = p;
    }
    for (int i = 0; i < k; i++)
    {
        int pivot = maxI;
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

int[] KWeakestRows1(int[][] mat, int k)
{
    // Create a list of tuples where each tuple contains the number of soldiers and the index of the row
    List<(int soldiers, int index)> rows = new List<(int, int)>();
    for (int i = 0; i < mat.Length; i++)
    {
        int soldiers = 0;
        for (int j = 0; j < mat[i].Length; j++)
        {
            soldiers += mat[i][j];
        }
        rows.Add((soldiers, i));
    }
    // Sort the list of tuples by the number of soldiers (ascending) and then by the index of the row (ascending)
    rows.Sort((x, y) => x.soldiers == y.soldiers ? x.index - y.index : x.soldiers - y.soldiers);
    // Create an array with the indices of the k weakest rows
    int[] result = new int[k];
    for (int i = 0; i < k; i++)
    {
        result[i] = rows[i].index;
    }
    return result;
}

int[][] someArray = CreateArray(10000, 10000);
Stopwatch sw = new Stopwatch();
FillArrayRandomIter(someArray);
// ArrayToConsole(someArray);
sw.Start();
var result = KWeakestRows(someArray, 6);
// Console.WriteLine();
// Console.WriteLine(String.Join(" ", result));
sw.Stop();
Console.WriteLine($"{sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
var result1 = KWeakestRows1(someArray, 6);
sw.Stop();
Console.WriteLine($"{sw.ElapsedMilliseconds}");


