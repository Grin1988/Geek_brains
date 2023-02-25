// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Print(int num)
{
    if(num < 1)
    {
        return;
    }
    Print(num - 1);
    System.Console.Write(num + "\t");
}

Print(n);