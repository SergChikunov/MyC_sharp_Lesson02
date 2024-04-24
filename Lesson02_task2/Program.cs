int n = 10;
int[] arr = new int[n];
int i = 0;

Console.Write("Массив заполнен следующими значениями элементов: ");
while (i < n)
{
    arr[i] = i + 1;
    Console.Write($"{arr[i]} ");
    i = i + 1;
}
