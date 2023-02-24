// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int ReadInt(string text) //Вводим значения строк и столбцов
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols) // Генерируем матрицу
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) // Выводим матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Zamena(int[,] matr) // Заменяем в матрице 1ую строку на последнюю и наоборот
{
    int temp;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i]; // Кладем в переменную 1ую строку нашей матрицы
        matr[0, i] = matr[matr.GetLength(0) - 1, i]; // в нашу матрицу кладем в 1ую строку кладем последнюю
        matr[matr.GetLength(0) - 1, i] = temp; // в последнюю строку нашей матрицы кладем 1ую строку, которую положили в переменную
    }
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
Zamena(myMatrix);
PrintMatrix(myMatrix);