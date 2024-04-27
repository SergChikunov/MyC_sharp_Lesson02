void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e}, ");
    }
}

int[] array = { 1, 2, 3, 4, 5 };
Console.Write("Исходный массив: "); // здесь нельзя плюсовать вывод функции, выдает ошибку, т.е. так делать можно не во всех случаях!!!
PrintArray(array);
Console.Write("\n");
ZeroEvenElements(array);
Console.Write("\n");
Console.Write("Обработанный массив: ");
PrintArray(array);
