// не принимаемый и не возвращаемый метод.

void metod1()
{
    System.Console.WriteLine("Avtor: ");
}
metod1();

// принимаемый но не возвращаемый метод.

void metod2(string msg)
{
    System.Console.WriteLine(msg);
}
metod2(msg: "текст сообщения");

void metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
metod21(msg: "Text", count: 4);

// метод ничего не принимает, но возвращает.

int metod3()
{
    return DateTime.Now.Year;
}
int year = metod3();
System.Console.WriteLine(year);

// метод который что-то принимает и что-то возвращает.

string metod4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = metod4(10, "qwerty");
System.Console.WriteLine(res);

