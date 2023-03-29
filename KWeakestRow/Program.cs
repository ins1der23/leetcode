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
    int height = mat.Length;
    int[] weakeatsRows = new int[height];
    for (int i = 0; i < height; i++)
    {
        int length = mat[i].Length;
        int j = 0;
        while (mat[i][j] == 1 && j < length - 1) j++;
        weakeatsRows[i] = j;
        if (mat[i][length - 1] == 1) weakeatsRows[i] = length;
    }
    return weakeatsRows;
}


int[][] someArray = CreateArray(10000, 10000);
Stopwatch sw = new Stopwatch();
sw.Start();
FillArrayRandomIter(someArray);
sw.Stop();
// ArrayToConsole(someArray);
sw.Start();
int[] result = KWeakestRows(someArray);
// Console.WriteLine(String.Join(" ", result));
sw.Stop();
Console.WriteLine($"{sw.ElapsedMilliseconds}");


