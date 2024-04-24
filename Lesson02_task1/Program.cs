// знакомство с массивами

int[] arr = new int[5];
arr[0] = 5;
arr[1] = 7;
arr[2] = 5;
arr[3] = 4;
arr[4] = 3;

Console.WriteLine("Вывод элементов массива в строку:");
Console.Write(arr[0] + "\t");
Console.Write(arr[1] + "\t");
Console.Write(arr[2] + "\t");
Console.Write(arr[3] + "\t");
Console.Write(arr[4] + "\t");

// Console.Write(arr[5] + "\t"); выход за пределы области памяти отведенной для массива, или проще: несуществующий индекс элемента массива

int[] arr2 = new int[5] { 1, 2, 5, 6, 8 };

Console.WriteLine("\t");
for ( int i = 0; i <= arr2.Length - 1; i++)
{
    Console.Write(arr2[i] + "\t"); 
}

Console.WriteLine("\t");

int[] arr3 = { 1, 2, 3, 4, 5 };
for ( int i = 0; i <= arr3.Length - 1; i++)
{
    Console.Write(arr3[i] + "\t"); 
}
