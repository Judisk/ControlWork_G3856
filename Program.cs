string [] Result = {""};

 while (true)
 {
    Console.WriteLine("Введите 0000 если хотите закончить ввод");
     string Word = Console.ReadLine();
     if (Word != "0000") LongWordThree(Word, ref Result);
     else {ShowArray(Result); return;}

}

// LongWordThree("sad",ref Result);
// ShowArray(Result);
// LongWordThree("sa",ref Result);

// ShowArray(Result);

void LongWordThree(string word,ref string[] Result )
{
    int Long = word.Length;
    if (Long < 4) AppEnd(ref Result, word);
}

void AppEnd(ref string[] Result,string word)
{
    string[] Res = new string[Result.Length+1];
    for (int i = 0; i < Result.Length; i++)
    {
        Res[i] = Result[i];
    }
    Res[Res.Length-1] = word;
    Result = Res;
}


void ShowArray(string[] testArray)
{
    string[] showArray = testArray;
    var str = string.Join(" ", showArray);
    Console.WriteLine(str);
}

