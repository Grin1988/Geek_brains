// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int[] GetNumber(string text) //Ввод данных
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return array;
}


void SearchIntersection(int[] array) //Подсчет введенных чисел > 0 
{
    int b1 = array[0];
    int k1 = array[1];
    int b2 = array[2];
    int k2 = array[3];
    int x = (b2 - b1) / (k1 - k2);

    int y1 = k1 * x + b1;
    int y2 = k2 * x + b2;

    if (y1 == y2)
    {
        System.Console.WriteLine($"Точкой пересечения является ({x}, {y1})");
    }
    else
    {
        System.Console.WriteLine("Точки пересечения нет");
    }
}

int[] arr = GetNumber("Введите b1 k1 b2 k2");
SearchIntersection(arr);