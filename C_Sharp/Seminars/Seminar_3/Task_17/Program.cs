﻿//Задача №17. Напишите программу, которая принимает 
//на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, 
//в которой находится эта точка.




// System.Console.WriteLine("Введите координату x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0)
// {
//     System.Console.WriteLine("Номер четверти 1");
// }
// else if(x < 0 && y > 0)
// {
//     System.Console.WriteLine("Номер четверти 2");
// }
// else if(x < 0 && y < 0)
// {
//     System.Console.WriteLine("Номер четверти 3");
// }
// else if(x > 0 && y < 0)
// {
//     System.Console.WriteLine("Номер четверти 4");
// }
// else 
// {
//     System.Console.WriteLine("Точка лежит в начале координат");
// }


int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}


void FindQuarter(int a, int b)
{
    if(a > 0 && b > 0)
    {
        System.Console.WriteLine("Номер четверти 1");
    }
    else if(a < 0 && b > 0)
    {
        System.Console.WriteLine("Номер четверти 2");
    }
    else if(a < 0 && b < 0)
    {
        System.Console.WriteLine("Номер четверти 3");
    }
    else if(a > 0 && b < 0)
    {
        System.Console.WriteLine("Номер четверти 4");
    }
    else 
    {
        System.Console.WriteLine("Точка лежит в начале координат");
    }
}
    


int x = InputNumber("Введите координату х: ");
int y = InputNumber("Введите координату y: ");
FindQuarter(x, y); 

