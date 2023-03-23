using System;
//   aa <=  b0cb

bool CanConstruct(string ransomNote, string magazine)
{
    if (ransomNote.Length > magazine.Length) return false;
    int ransomSize = ransomNote.Length;
    char[] alphabet = magazine.ToCharArray();
    int alphabetSize = alphabet.Length;
    int count = 0;
    for (int i = 0; i < ransomSize; i++)
    {
        for (int j = 0; j < alphabetSize; j++)
        {
            if (ransomNote[i] == alphabet[j])
            {
                count++;
                alphabet[j] = '0';
                break;
            }
        }
    }
    if(count == ransomSize) return true;
    else return false;
}

Console.WriteLine(CanConstruct("aa", "babc"));