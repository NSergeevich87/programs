/* 
string path = "/Users/Professional/Documents/Домашка GeekBrains/C#Lection1/programs";

DirectoryInfo di = new DirectoryInfo (path);
System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
} 
*/

/* string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal (int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        Console.Write($"{tree[pos]} ");
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal(); */

/* double Message (string mes)
{
    System.Console.Write(mes);
    string answ = Console.ReadLine();
    double result = int.Parse(answ);
    return result;
}

void Fibo (double number)
{
    double[] array = new double[number];
    array[0] = 1;
    array[1] = 1;
    double result = 0;
   for (double i = 2; i < array.Length; i++)
   {
      array[i] = array[i - 1] + array[i - 2];
      result = array[i];
      System.Console.Write($"{result} ");
   }
} */

/* double c = Message("Vvedite chislo: ");
Fibo(c); */
//double result = Fibo(c);
//System.Console.WriteLine(result);

int NewMessage (string mensaje)
{
    System.Console.Write(mensaje);
    string answer = Console.ReadLine();
    int num = int.Parse(answer);
    return num;
}

int Fibo (int number)
{
    if ( (number == 0) || (number == 1)) return number;
    return Fibo (number - 1) + Fibo (number - 2);
}

int num = NewMessage ("Введите число: ");
int result = Fibo(num);
System.Console.WriteLine($"{result} ");




