// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет
// находить произведение двух матриц.

DateTime dt = DateTime.Now; //Время работы нашего кода

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
            matrix[i, j] = rand.Next(3, 11);
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

int[,] MatrixMultiplication(int[,] myMatrix, int[,] array)
{
    int newRows = 0;
    int newCols = 0;
    newRows = (myMatrix.GetLength(0) < array.GetLength(0)) ?
                myMatrix.GetLength(0) : array.GetLength(0);

    newCols = (myMatrix.GetLength(1) > array.GetLength(1)) ?
                array.GetLength(1) : myMatrix.GetLength(1);

    Random rand = new Random();
    int[,] newArray = new int[newRows, newCols];


    string num1 = 0;
    for (int i = 0; i < myMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < myMatrix.GetLength(0); j++)
        {
            num1 += myMatrix[i,j];
        }
    }

    string num2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            num2 += array[i,j];
        }
    }

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            num2 += array[i,j];
        }
    }



    return newArray;
}



int rows1 = ReadInt("Введите количество строк 1-ой матрицы: ");
int cols1 = ReadInt("Введите количество столбцов 1-ой матрицы: ");
System.Console.WriteLine();
int rows2 = ReadInt("Введите количество строк 2-ой матрицы: ");
int cols2 = ReadInt("Введите количество столбцов 2-ой матрицы: ");

int[,] myMatrix = GenerateMatrix(rows1, cols1);
int[,] array = GenerateMatrix(rows2, cols2);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(array);
System.Console.WriteLine();
PrintMatrix(MatrixMultiplication(myMatrix, array));
System.Console.WriteLine();
System.Console.WriteLine($"Время работы нашего кода = {(DateTime.Now - dt).TotalMilliseconds}");
System.Console.WriteLine();

