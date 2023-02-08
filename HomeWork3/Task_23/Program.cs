//Напишите программу, которая принимает 
//на вход пятизначноен число и проверяет,   
//является ли оно палиндромом.

//14212-> нет
//23432-> да
//12821-> да

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

int num = InputNumber("Введите пятизначное число: ");



