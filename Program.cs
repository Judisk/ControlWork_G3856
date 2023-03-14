string [] Result = {""};

void LongWordThree(string word,ref string[] Result )
{
    int Long = word.Length;
    if (Long < 4) AppEnd(ref Result, word);
}

void AppEnd(ref string[] Result,string word)
{
    string[] Res = new string[Result.Length+1];
    Res[Res.Length - 1] = word;
    Result = Res;
}

void ShowArray(string[] testArray)
{
    string[] showArray = testArray;
    var str = string.Join(" ", showArray);
    Console.WriteLine(str);
}