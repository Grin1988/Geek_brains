// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int MultiplicationOfNumbers(int num)
{
    int Da = 1;
    for (int i = 1; i <= num; i++)
    {
        Da = Da * i;
    }
    return Da;
}

int mult = GetNumber("Введите число N: ");
int res = GetNumber("Введите число : ");
System.Console.WriteLine($"Произведение чисел от 1 до {mult} = {MultiplicationOfNumbers(mult)}");
System.Console.WriteLine($"Произведение чисел от 1 до {res} = {MultiplicationOfNumbers(res)}");

