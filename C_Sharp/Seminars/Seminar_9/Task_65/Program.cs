// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Metka:
System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= m)
{
    System.Console.WriteLine("Нет чисел в промежутке от M до N! Повторите ввод!");
    goto Metka;
}

Print(m, n);

void Print(int numM, int numN)
{
    if (numN < numM)
    {
        return;
    }
    Print(numM, numN - 1);
    System.Console.Write(numN + "\t");
}