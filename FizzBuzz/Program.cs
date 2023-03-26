IList<string> FizzBuzz(int n)
{
string[] someList = new string[10000];
int i = someList.Length - 1;

void FizzBuzzRec(string[] stringArray, int i = 0)
{
    if (i < 0) return;
    if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0) stringArray[i] = "FizzBuzz";
    else
    {
        if ((i + 1) % 5 == 0) stringArray[i] = "Buzz";
        else if ((i + 1) % 3 == 0) stringArray[i] = "Fizz";
        else stringArray[i] = (i + 1).ToString();
    }
    FizzBuzzRec(stringArray, i - 1);
}
FizzBuzzRec(someList, i);
return someList;
}

IList<string> lst1 = FizzBuzz(20);

Console.WriteLine(lst1[19]);