System.Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine()); //Получаем значение от терминала
System.Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine()); //Получаем значение от терминала

if (numB*numB == numA)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}