// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

void SearchElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++) // проходим по всем числам массива
    {
        if (element == array[i]) // Проверяем условие на нахождение нашего элемента
        {
            System.Console.Write("Такое значение есть5"); ; // Складываем отрицательньные в 0 ячейку
        }
        else
        {
            System.Console.Write("Нет такого значения");  // 
        }
    }
}

int elementsear = GetNumber("Введите искомое число: ");
int[] myArray = GenerateArray(20, -9, 9);
PrinArray(myArray);
SearchElement(myArray, elementsear);

