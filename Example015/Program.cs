// Двумерные массивы
/*
string[,] table = new string[2, 3];
int[,] matrix = new int[5, 8];
*/

//string[,] table = new string[2, 5];
// String.Empty
// table [0, 0]  table [0, 1] ... table[0, 4];
// table [1, 0]
/*
table[1, 2] = "slovo";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        System.Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/

/*
int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
};



void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row -1, col);
        FillImage(row, col -1);
        FillImage(row +1, col);
        FillImage(row, col +1);
    }
}

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
{
       for (int j = 0; j < image.GetLength(1); j++)
       {
           //Console.Write($"{image[i, j]} ");
           if (image[i, j] == 0) System.Console.Write($" ");
           else System.Console.Write($"+");
       }
   Console.WriteLine();
}
}
*/
/*
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
*/

//int[,] matr = new int[3, 4];
//PrintArray(matr);
//FillMatrix(matr);
//System.Console.WriteLine();
//PrintArray(matr);

//PrintArray(pic);
//FillImage(1, 1);
//PrintArray(pic);

/*
double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

for (int i = 1; i < 40; i++)
{
System.Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
/*
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return (Fibonacci(n - 1) + Fibonacci(n - 2));
}

for (int i = 1; i < 50; i++)
{
    System.Console.Write($"f({i}) = {Fibonacci(i)} ");
}
*/

int NewMessage(string message)
{
    System.Console.Write(message);
    int answer = int.Parse(Console.ReadLine());
    return answer;
}

int[,] Matrix(int a, int b, int c, int d)
{
    int[,] NewMatrix = new int[a,b];
    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            NewMatrix[i,j] = new Random().Next(c,d+1);
        }
    }
    return NewMatrix;
}

void PrintMatrix(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        System.Console.Write($"{matrix[i,j]} ");
      }
    System.Console.WriteLine();
   }
   
}


int strok = NewMessage("Введите количество строк в матрице: ");
int stolb = NewMessage("Введите количество столбцов в матрице: ");
int minnumber = NewMessage("Введите диапазон чисел ОТ: ");
int maxnumber = NewMessage("Введите диапазон чисел ДО: ");

int[,] Mat = Matrix(strok, stolb, minnumber, maxnumber);
PrintMatrix(Mat);