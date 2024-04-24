int n = 10;
int[] array = { 1, 5, 3, 7, 9, 35, 1, 3, 11, 5 };
int i = 0;
int count = 0;

Console.WriteLine("Четные элементы массива имеют такие значения: ");
while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        count++;
    }
    i++;
}

if(count == 0)
{
    Console.Write("в массиве нет четных элементов");
}
