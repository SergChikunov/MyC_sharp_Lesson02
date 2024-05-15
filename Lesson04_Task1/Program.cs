/* Задача 1. Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел
Вывести его элементы на экран */

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

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);
