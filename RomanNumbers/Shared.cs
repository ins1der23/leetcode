using System.Linq;
public class Shared
{
// преобразоваине string в char[];
    public static char[] ToCharAray(string text)
    {
        char[] someArray = new char[text.Length];
        int size = someArray.Length;
        for (int i = 0; i < size; i++)
        {
            someArray[i] = text[i];
        }
        return someArray;
    }
    // создание римского числового алфавита
    public static (char[], int[]) RomanAlhabet()
    {
        char[] romanNumbers = ToCharAray("IVXLCDM");
        int[] romanMeanings = { 1, 5, 10, 50, 100, 500, 1000 };
        return (romanNumbers, romanMeanings);
    }
    // преобразование римского массива в арбаский
    public static int[] RomanToIntArray(char[] romanArray)
    {
        var alphabet = RomanAlhabet();
        char[] romans = alphabet.Item1;
        int[] meanings = alphabet.Item2;
        int size = romanArray.Length;
        int[] romanIntArray = new int[size];
        int alphabetSize = romans.Length;
        for (int i = 0; i < size; i++)
        {
            for (int k = 0; k < alphabetSize; k++)
            {
                if (romanArray[i] == romans[k]) romanIntArray[i] = meanings[k];
            }
        }
        return romanIntArray;
    }
    // сложение значений чисел в римской записи
    public static int SumOfRoman(int[] anyArray, int i = 0, int sum = 0)
    {
        int size = anyArray.Length;
        if (i == size - 1) return sum + anyArray[i];
        if (anyArray[i] >= anyArray[i + 1]) sum += anyArray[i];
        else sum -= anyArray[i];
        sum = SumOfRoman(anyArray, i + 1, sum);
        return sum;
    }

    //  char массив в строку
    public static string ArrayJoinToString(char[] array)
    {
        return $"[{String.Join(' ', array)}]";
    }

    //  int массив в строку
    public static string ArrayJoinToString(int[] array)
    {
        return $"[{String.Join(' ', array)}]";
    }
}