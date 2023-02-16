// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка)


System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N%2==0){
    System.Console.Write("Да");
}
else{
    System.Console.Write("Нет");
}