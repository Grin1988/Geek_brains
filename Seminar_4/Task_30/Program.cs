// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] GetArray(int size)
{
    int[] arrN = new int[size]; // создает какой-то массив на size элементов
    for (int i = 0; i < size; i++)         //
    {                                      // рандомно заполняет массив
        arrN[i] = new Random().Next(0, 2); //
    }
    return arrN; // возвращает массив
}

void PrintArray(int[] array) // получает на вход массив
{
    // for (int i = 0; i < array.Length; i++) // заполняем массив
    // {
    //     System.Console.Write($"{array[i]}, "); // вывод массива
    // }

    System.Console.WriteLine(string.Join(", ", array));
}

int[] array1 = GetArray(8);
PrintArray(array1);

