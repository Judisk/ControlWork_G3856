string [] Result = {""};

void AppEnd(ref string[] Result,string word)
{
    string[] Res = new string[Result.Length+1];
    Res[Res.Length - 1] = word;
    Result = Res;
}

