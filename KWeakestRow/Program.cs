using System.Collections.ObjectModel;
using System.Diagnostics;

int[][] CreateArray(int m, int n)
{
    int[][] someArray = new int[m][];
    for (int i = 0; i < m; i++) someArray[i] = new int[m];
    return someArray;
}

void FillArrayRandomRec(int[][] anyArray)
{
    int height = anyArray.Length;
    for (int i = 0; i < height; i++)
    {
        int length = anyArray[i].Length;
        void FillString(int j = 0)
        {
            int onesLength = new Random().Next(1, length + 1);
            if (j >= onesLength) return;
            anyArray[i][j] = 1;
            FillString(j + 1);
        }
        FillString();
    }
}

void FillArrayRandomIter(int[][] anyArray)
{
    int height = anyArray.Length;
    for (int i = 0; i < height; i++)
    {
        int length = anyArray[i].Length;
        int onesLength = new Random().Next(1, length + 1);
        
        for (int j = 0; j < onesLength; j++) anyArray[i][j] = 1;
    }
}


void ArrayToConsole(int[][] anyArray)
{
    int height = anyArray.Length;
    for (int i = 0; i < height; i++) Console.WriteLine(String.Join(" ", anyArray[i]));
}

int[][] someArray = CreateArray(10,10);
Stopwatch sw = new Stopwatch();
int[][] anotherArray = CreateArray(10,10);
sw.Start();
FillArrayRandomIter(anotherArray);
sw.Stop();
ArrayToConsole(anotherArray);
Console.WriteLine($"{sw.ElapsedMilliseconds}");
sw.Reset();
sw.Start();
FillArrayRandomRec(someArray);
sw.Stop();
ArrayToConsole(someArray);
Console.WriteLine($"{sw.ElapsedMilliseconds}");

