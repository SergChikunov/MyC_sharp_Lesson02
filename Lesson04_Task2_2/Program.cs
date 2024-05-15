/* Задача 2. Назовём число «интересным» если его сумма цифр чётная
Создать двумерный массив, состоящий из целых чисел. Вывести на экран «интересные»
элементы массива */
int[,] CreateMatrix(int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];

    Random rnd = new Random(); //подобные операции лучше всего выносить за пределы цикла!!!
    for (int i = 0; i < matrix.GetLength(0); i++) //заполнение массива данными, в i цикле заполняем первое измерение - перебираем строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //заполнение массива данными, в j цикле заполняем второе измерение - перебираем элеинты в строках
        {
            //Random rnd = new Random(); //подобные операции лучше всего выносить за пределы цикла, для оптимизации быстродействия кода!!!
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if(sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value /= 10;
    }
    return sum;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //заполнение массива данными, в i цикле заполняем первое измерение - перебираем строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //заполнение массива данными, в j цикле заполняем второе измерение - перебираем элеинты в строках
        {
            Console.Write($"{matrix[i, j]}\t"); //подобный вывод называется интерполяция строк
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);
Console.WriteLine("\nСформированный массив:");
ShowMatrix(matrix);
Console.WriteLine("\nИнтересные числа в заданном массиве:");

foreach(int e in matrix)
{
    if(IsInteresting(e))
    {
        Console.WriteLine(e);
    }
}