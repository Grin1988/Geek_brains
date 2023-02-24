System.Console.Write("Введите трехначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num <1000)
{
System.Console.WriteLine(num%10 + "  последняя цифра"); // N%10 Выводит последнюю цифру числа
}
else{
    System.Console.WriteLine("Введено не трехначное число");
}


