System.Console.Write("Введите целое число: "); // Выводим строку
int N = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Math.Abs применяем модуль числа

for(int i = -N; i<=N; i++) // задаем цикл, при котором некоторой переменной i присваиваем значение -N, и далее мы прибавляем +1 до  тех пор, пока i не станет <=N
{
    System.Console.Write(i + " "); // Выводим весь ряд чисел от -N до N
}