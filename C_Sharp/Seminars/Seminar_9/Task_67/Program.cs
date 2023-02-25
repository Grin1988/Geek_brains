// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Sum(num));

// int Sum(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     return n % 10 + Sum(n / 10);
// }

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int n, int m)
{

    if (m == 1)
    return n;
    return n * Power(n, m - 1);

}

int n = ReadInt("Введите N: ");
int m = ReadInt("Введите M: ");


System.Console.WriteLine(Power(n, m));