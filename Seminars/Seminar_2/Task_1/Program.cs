// напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает наибольшу цифру числа

// например:
//78->8
//12->2
//85->8


Random rand = new Random(); // способ описания функции Random


int number = rand.Next(10, 100); // new Random() класс позволяет 
//генерировать рандомные числа
// Next(10, 100) ФУНКЦИЯ генерирует случайные числа от 10(включаЯ) до 99 (100 не включая)
System.Console.WriteLine($"Число {number}");
int num1 = number / 10;
int num2 = number % 10;

if (num1 > num2) 
{
    System.Console.WriteLine($"Левое число больше и равно {num1}");
}
else if(num2 > num1)
{
    System.Console.WriteLine($"Правое число больше и равно {num2}");
}
else {
    System.Console.WriteLine($"Правое и левое числа равны {num1} = {num2}");
}



// System.Console.WriteLine($"Случайное число: {number}");