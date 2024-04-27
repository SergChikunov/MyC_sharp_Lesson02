/* Задание_4 Ссылочный тип данных. Передача массива в метод

Создать функции FillArray, PrintArray, GetSumOfElements,
GetProductOfElements. Добиться работоспособности
приведённого кода */

// int n = 10;
int[] arr = new int[10];

void FillArray(int[] arr)
{
	Random rnd1 = new Random();
	for(int i = 0; i < arr.Length; i++)
	{
		arr[i] = rnd1.Next(1, 16);
	}
}

void PrintArray(int[] arr)
{
	Console.Write("[");
    // foreach(int d in arr)
    for(int i = 0; i < arr.Length; i++)
	{
		if(i == arr.Length - 1)
		{
		Console.Write($"{arr[i]}");
		}
		else
		{
			Console.Write($"{arr[i]}, ");
		}
		
	}
    Console.Write("]");
	Console.Write("\n");
}

int GetSumOfElements(int[] arr)
{
	int i = 0;
	int sum = 0;
	while(i < arr.Length)
	{
		sum = sum + arr[i];
		i++;
	}
	return sum;
}

int GetProductOfElements(int[] arr)
{
	int i = 0;
	int product = 1;
	while(i < arr.Length)
	{
		product = product * arr[i];
		i++;
	}
	return product;
}

FillArray(arr);
Console.Write("\n");
Console.WriteLine("Заданный массив элементов: ");
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.Write("\n");
Console.WriteLine($"Сумма элементов массива равна: {sum}\n");
Console.WriteLine($"Произведение элементов массива равно: {product}\n");
