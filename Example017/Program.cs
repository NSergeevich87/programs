// Продолжение рекурсии в C#

int NewMessage (string mes)
{
    Console.Write(mes);
    string read = Console.ReadLine();
    int answer = int.Parse(read);
    return answer;
}

/* int SumNum (int num)
{
    if (num == 0) return 0;
    else return num + SumNum(num - 1);
} */

/* int Factorial (int num)
{
    if (num == 1) return 1;
    else return num * Factorial(num - 1);
} */

int AvN (int a, int n)
{
    return n == 0 ? 1: AvN (a, n - 1) * a;
    /* if (n == 0) return 1;
    else return AvN (a, n - 1) * a; */
}

void ConsolePrint (int num)
{
    System.Console.WriteLine(num);
}

int numberA = NewMessage ("Введите число a: ");
int numberN = NewMessage ("Введите число n: ");
//int showResult = SumNum (number);
//int showResult = Factorial (number);
int showResult = AvN (numberA, numberN);
ConsolePrint (showResult);