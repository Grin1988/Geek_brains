// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string GetNumber(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}


int Length(string b)
{
    int len = b.Length;
    return len;
}

string a = GetNumber("Введите число А: ");
System.Console.WriteLine($"{Length(a)}");