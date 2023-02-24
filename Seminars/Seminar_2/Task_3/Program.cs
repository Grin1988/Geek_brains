// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если число не кратно числу 1, то программа выводит 
// остаток от деления

//34, 5->не кратно, остаток 4
//16, 4->кратно

System.Console.WriteLine("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());

int residue = num1%num2;
if(residue == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"не кратно, остаток {residue}");
}
