// Напишите пргграмму, которая на вход принимает два
// числа и выдает, какое число большее, а какое меньшее

System.Console.Write("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;
int min = numB;

if (numA > numB)
{
    System.Console.WriteLine("max=" + max);
    System.Console.WriteLine("min=" + min);
}
else {
    max = numB;
    min = numA;
    System.Console.WriteLine("max=" + max);
    System.Console.WriteLine("min=" + min);
}