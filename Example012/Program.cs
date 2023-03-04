
// цикл for

string metod4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    
    for (i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = metod4(10, "qwerty");
//System.Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}
