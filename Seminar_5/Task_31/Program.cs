// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size]; //выделим память по массив
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9
    }
    return array;
}

void PrinArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

// int SumNegative(int[] array) // 1 метод описания нахождения положительных и отрицательных чисел массива
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
//     {
//         if (array[i] < 0) // Проверяем условие на их отрицательность
//         {
//             result += array[i]; // Складываем их
//         }
//     }
//     return result; // выводим результат
// }

// int SumPositive(int[] array) // 1 метод описания нахождения положительных и отрицательных чисел массива
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
//     {
//         if (array[i] > 0) // Проверяем условие на их положительность
//         {
//             result += array[i]; // Складываем их
//         }
//     }
//     return result; // выводим результат
// }

// int[] SumNegativePositive(int[] array) // 2 метод описания (находим сразу и отр и полож числа)
// {
//     int[] result = new int[2];
//     for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
//     {
//         if (array[i] < 0) // Проверяем условие на их отрицательность
//         {
//             result[0] += array[i]; // Складываем отрицательньные в 0 ячейку
//         }
//         else
//         {
//             result[1] += array[i];  // иначе складыаем положительные в 1 ячейку
//         }
//     }
//     return result; // выводим результат
// }

void SumNegativePositive(int[] array, out int sumPositive, out int sumNegative) // 3 метод описания (находим сразу и отр и полож числа)
{
    sumNegative = 0; // out означает, что мы можем вытаскивать из данного метода значения, неважно произошел return или нет
    sumPositive = 0;

    int[] result = new int[2];
    for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
    {
        if (array[i] < 0) // Проверяем условие на их отрицательность
        {
            sumNegative += array[i]; // Складываем отрицательньные в 0 ячейку
        }
        else
        {
            sumPositive += array[i];  // иначе складыаем положительные в 1 ячейку
        }
    }
}



int[] myArray = GenerateArray(12, -9, 9);
PrinArray(myArray);
SumNegativePositive(myArray, out int sumPositive, out int sumNegative);
System.Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
System.Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");

// System.Console.WriteLine($"Сумма отрицательных элементов равна {SumNegative(myArray)}");
// System.Console.WriteLine($"Сумма положительных элементов равна {SumPositive(myArray)}");

// int[] sums = SumNegativePositive(myArray);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {sums[0]}");
// System.Console.WriteLine($"Сумма положительных элементов равна {sums[1]}");


