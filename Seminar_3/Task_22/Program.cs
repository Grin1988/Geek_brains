//Напишите программу, которая принимает 
//на вход число (N) и выдаёт таблицу квадратов 
//чисел от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int N = InputNumber("Введите число N: ");

// int num = 1;
// while(num <= N)
// {
//     System.Console.Write(Math.Pow(num, 2) + ",");
//     num++;
// }

for(int num = 1; num <= N; num++)
{
    System.Console.Write(Math.Pow(num, 2) + ",");
} 