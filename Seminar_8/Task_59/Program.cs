// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

void Minimum(int[,] matrix, out int minI, out int minJ)
{
    minI = 0;
    minJ = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[minI, minJ] < matrix[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
}

int[,] NewMatrix(int[,] matrix, int minI, int minJ)
{
    int[,] newMatr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minI)
        {
            l = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minJ)
                {
                    newMatr[k, l] = matrix[i, j];
                    l++;
                }
            }
            k++;
        }
    }
    return newMatr;
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
Minimum(myMatrix, out int minA, out int minB);

System.Console.WriteLine();
PrintMatrix(NewMatrix(myMatrix, minA, minB));