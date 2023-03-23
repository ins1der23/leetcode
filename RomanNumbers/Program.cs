using static Shared;


string romanNumber = "CCXLVIII";
char[] romanArray = ToCharAray(romanNumber);
Console.WriteLine(ArrayJoinToString(romanArray));
int[] toArabic = RomanToIntArray(romanArray);
Console.WriteLine(ArrayJoinToString(toArabic));
int arabic = SumOfRoman(toArabic);
Console.WriteLine(arabic);



