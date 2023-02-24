// Задача 45: Напишите программу,
// которая будет создавать копию 
// заданного массива с помощью 
// поэлементного копирования.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] CopyPaste(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;

}


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int[] arr = GenerateArray(5, 0, 100);
PrintArray(arr);
int[] arrCopy = CopyPaste(arr);
PrintArray(arrCopy);