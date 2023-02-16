// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N

System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N>=0){
    for(int i = 0; i<=N; i=i+2)
    {
        System.Console.Write(i + " "); // Выводим весь ряд четных чисел от 0 до N
    }
}
else {
    System.Console.Write("Задача невыполнима!");
}