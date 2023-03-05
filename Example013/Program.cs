/*
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
*/

string text = "Before he could answer, I scrambled up from the couch and lurched my way up"
            + "the stairs. Someone had been in the house to leave a note for Charlie, a note"
            + "that would lead him to find me.";

string textedit(string text, char old, char mew)
{
    string result = string.Empty; 

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == old) result = result + $"{mew}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newtext = textedit(text, ' ', '!');

System.Console.WriteLine(newtext);

newtext = textedit(newtext, 'a', 'B');

System.Console.WriteLine(newtext);


