
// Работа с текстом
// Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие буквы "к", заменить большими "К",
// а большие "С", заменить маленькими "с".

string text = "- Я думаю, - сказал Князь, улыбаясь, - что ,"
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
           result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newtext = replace(text, ' ', '_');

System.Console.WriteLine(newtext);

newtext = replace(newtext, 'к', 'К');

System.Console.WriteLine(newtext);

newtext = replace(newtext, 'с', 'С');

System.Console.WriteLine(newtext);
