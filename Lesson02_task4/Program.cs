Console.WriteLine("Введите число элементов массива, не более 150: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for(int j = 0; j < n - 1; j++)
{
    Random rnd1 = new Random(); // вызов метода Random для генерации случайного числа
    array[j] = rnd1.Next(0, n); // генерация случайного числа из диапазона от 0 до n и присвоение его элементу массива
    Console.Write(array[j] + " ");  //вывод элемента массива
}

int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}

Console.WriteLine("\n");
Console.WriteLine("Максимальный элемент массива равен: " + max);
