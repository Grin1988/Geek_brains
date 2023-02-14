// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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

void ChangeNagativeAndPositive(int[] array)
{
    for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
    {
        if (array[i] < 0) // Проверяем условие на их отрицательность
        {
            array[i] = -array[i]; // Меняем местами отрицательное с положительным числом
        }
        else
        {
            array[i] = -array[i];
        }

    }
}


int[] myArray = GenerateArray(12, -9, 9);
PrinArray(myArray);
SumNegativePositive(myArray, out int sumPositive, out int sumNegative);
ChangeNagativeAndPositive(myArray);
PrinArray(myArray);
// System.Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");
// System.Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");


