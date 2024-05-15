/* Считать с консоли строку, состоящую из цифр и латинских букв.
Сформировать новую строку, состоящую из букв исходной строки.
123passw0rd*/

string GetLettersFronString(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

Console.WriteLine("Введите исходную строку и нажмите Enter...");
string str = Console.ReadLine();
string result = GetLettersFronString(str);
Console.WriteLine(result);