// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив 
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int ReadInt(string text) // Ввод данных
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols) // Задание рандомного двумерного массива
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t"); // "\t" Табуляция, позволяет сделать правильные отступы*\\
        }
        System.Console.WriteLine();
    }
}

void ReplacementMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i%2 != 0 && j%2 != 0)
            {
                matrix[i,j] = (matrix[i,j]) * (matrix[i,j]);
            }
        }
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество строк: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
ReplacementMatrix(myMatrix);
PrintMatrix(myMatrix);