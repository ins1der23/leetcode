int MaximumWealth(int[][] accounts)
{
    int size = accounts.Length;
    int maxSum = 0;
    for (int i = 0; i < size; i++)
    {
        int innerSize = accounts[i].Length;
        int currentSum = 0;
        for (int j = 0; j < innerSize; j++) currentSum += accounts[i][j];
        if(currentSum > maxSum) maxSum = currentSum;
    }
      
    return maxSum;
}

int[] list1 = new int[4] { 1, 2, 3, 4 };
int[] list2 = new int[4] { 5, 6, 7, 8 };
int[] list3 = new int[4] { 1, 3, 2, 1 };
int[] list4 = new int[4] { 5, 4, 3, 2 };
int[][] lists = new int[][] { list1, list2, list3, list4 };
Console.WriteLine(MaximumWealth(lists));
