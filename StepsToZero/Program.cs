int NumberOfSteps(int num)
{
    int count = 0;
    if (num == 0) return count;
    while (num > 1)
    {
        if (num % 2 == 1)
        {
            num--;
            count++;
        }
        num = num / 2;
        count++;
    }
    return count + 1;
}
Console.WriteLine(NumberOfSteps(0));