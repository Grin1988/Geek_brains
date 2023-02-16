// напишите программу, которая принимает на вход трехначное число
//и на выходе показывает вторую цифру этого числа

//456->5
//782->8
//918->1

System.Console.Write("Введите трехначное число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine())); //С использование отрицательных трехзначных чисел
// int num = Convert.ToInt32(Console.ReadLine());

if(num>=100 & num<=999)
{
    int twoDigit = num/10;
    int result = twoDigit%10;
    System.Console.WriteLine($"Вторая цифра трехначного числа {num} -> {result}");
}
else
{
    System.Console.WriteLine($"Введеное число {num} не является трехзначным");
}