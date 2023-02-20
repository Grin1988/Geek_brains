// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            matrix[i, j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

int SumNumbersMainDiagonal(int[,] matrix)
{
    int result = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                result += matrix[i, j];
            }
        }
    }
    return result;
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество строк: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
SumNumbersMainDiagonal(myMatrix);
System.Console.WriteLine($"Сумма элементов главной диагонали: {SumNumbersMainDiagonal(myMatrix)}");
