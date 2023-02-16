// Напишите программу, которая принимает на вход три числа и 
// выдает максимальное из этих чисел

System.Console.Write("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число c: ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (numA > max){
    max = numA;
}
if (numB > max){
    max = numB;
}
if (numC > max){
    max = numC;
}
else{
    System.Console.WriteLine("max=" + max);
}
