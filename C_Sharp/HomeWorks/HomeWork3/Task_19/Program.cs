﻿// Напишите программу, которая принимает на вход пятизначное
//число и проверяет, является ли оно палиндромом

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int num = InputNumber("Введите пятизначное число: "); //Ввод данных

if(num < 10000 || num > 99999) //Проверка на пятизначность
{
    System.Console.WriteLine("Число не является пятизначным");
}
else //Проверка на палиндромность
{
    int a = num / 10000; //первая цифра числа
    int b = (num/1000)%10; //вторая цифра числа
    int с = (num/1000)%10; //третья цифра числа
    int d = (num/10)%10; //четвартая цифра числа
    int e = num%10; //пятая цифра числа

    if(a == e && b == d)
    {
        System.Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {num} не является палиндромом");
    }
};



