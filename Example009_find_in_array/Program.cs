//programma nahogdeniya chisla v zadannom massive

int[] array = {199,24,553,74,95,26,73,553};

int n = array.Length;
int find = 553;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}