// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет 
// строки на столбцы.

int ReadInt(string text) // Ввод данных
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols) // Задание рандомного двумерного массива
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //Вывод массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); // "\t" Табуляция, позволяет сделать правильные отступы*\\
        }
        System.Console.WriteLine();
    }
}

int[,] Average(int[,] array) // Создаем новый массив и переворачиваем в него старый и возвращаем его
{
    int[,] vertical = new int[array.GetLength(1), array.GetLength(0)]; // Выводим под новый массив память размерностью обратной старому массиву
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            vertical[i, j] = array[j, i];
        }
    }
    return vertical;
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

System.Console.WriteLine();

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();

PrintMatrix(Average(myMatrix));