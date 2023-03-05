
// Сортировка элементов в массиве.
/*
int [] arr = {0, 3, 6, 5, 8, 4, 1, 5, 9, 2, 3, 8, 5, 3, 7, 6, 5};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/
// В рамках домашней работы сделать упорядочивание элементов от большого к малому.

/*

int [] arr = new int[15];

void fillArray (int[] collection)
{
//int length = collection.Length;
for (int i = 0; i < collection.Length; i++)
{
    collection[i] = new Random().Next(0, 10);
}
}

void printArray (int[] collection)
{
   //int length = collection.Length;
    
    for (int i = 0; i < collection.Length; i++)
    {
        System.Console.Write($" {collection[i]}");
    }
}

void sortArray (int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
    
    int maxposition = i;

    for (int j = i + 1; j < collection.Length; j++)
    {
        if (collection[j] > collection[maxposition])
        {
            maxposition = j;
        }
    }
    
    int timeposition = collection[i];
    collection[i] = collection[maxposition];
    collection[maxposition] = timeposition;
    }
}

fillArray(arr);
sortArray(arr);
printArray(arr);

*/

int [] arr = new int[15];

void fillArray (int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0, 99);
    }
}

void printArray (int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        System.Console.Write($" {col[i]}");
    }
}

void placeArray (int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        int maxomin = i;

        for (int j = i + 1; j < col.Length; j++)
        {
            if (col[j] < col[maxomin]) maxomin = j;
        }

        int timeplace = col[i];
        col[i] = col[maxomin];
        col[maxomin] = timeplace;
    }
}

fillArray(arr);
placeArray(arr);
printArray(arr);