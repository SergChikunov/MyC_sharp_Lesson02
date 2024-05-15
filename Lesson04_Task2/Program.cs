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
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void IntrestingNumbers(int[,] matrix)
{
    int count = 0;
    Console.WriteLine("\nИнтересные числа в заданном массиве, согласно их строк:");
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if(matrix[i, j] % 2 == 0)
            {
                Console.Write($"{matrix[i, j]}\t");
                count++;
            }
        }
        Console.WriteLine();
    }
    if(count == 0)
    {
        Console.WriteLine("\nЗаданный массив не содержит интересных чисел!");
    }
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

Console.Write("Задайте число строк в массиве: ");
int rowCount = int.Parse(Console.ReadLine());
Console.Write("\nЗадайте число столбцов в массиве: ");
int columnsCount = int.Parse(Console.ReadLine());
int[,] matrix = CreateMatrix(rowCount, columnsCount);
Console.WriteLine("\nСформированный массив:");
ShowMatrix(matrix);
IntrestingNumbers(matrix);
