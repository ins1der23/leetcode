// IList<string> FizzBuzz(int n)
// {
string[] someList = new string[15];
for (int i = 0; i < 15; i++)
{
    if ((i + 1) % 5 == 0 && (i + 1) % 3 == 0) someList[i] = "FizzBuzz ";
    else
    {
        if ((i + 1) % 5 == 0) someList[i] = "Buzz ";
        else if ((i + 1) % 3 == 0) someList[i] = "Fizz ";
        else  someList[i] = (i + 1).ToString();
    } 
        
}
foreach (var item in someList)
{
    Console.Write(item);
}


// }