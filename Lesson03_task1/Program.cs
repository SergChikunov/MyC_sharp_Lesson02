// Урок_3. Функции

//Задание_1

double CalculateFormula(int a, int b, int c, int d)
{
    int numenator = a * b;
    double denumenator = c + d;     // чтобы результат вернулся в вещественном виде, надо чтобы одна переменная имела вещественный тип данных
    double result = numenator / denumenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine("Результат вычисления выражения: " + result);
Console.WriteLine("Результат вычисления выражения: " + CalculateFormula(1, 2, 3, 4)); //так тоже работает!!!
