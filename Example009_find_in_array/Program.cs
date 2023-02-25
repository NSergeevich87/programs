//programma nahogdeniya chisla v zadannom massive

int[] array = {199,24,553,74,95,26,73,84};

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}