//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти 
//(x и y).

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}

string [] array = {"x > 0 и y > 0", "x < 0 и y > 0", "x < 0 и y < 0", "x < 0 и y < 0", "Начало координат"};

void FindQuarter(int a)
{
    if(a == 1)
    {
        System.Console.WriteLine(array[0]);
    }
    else if(a == 2)
    {
        System.Console.WriteLine(array[1]);
    }
    else if(a == 3)
    {
        System.Console.WriteLine(array[2]);
    }
    else if(a == 4)
    {
        System.Console.WriteLine(array[3]);
    }
    else 
    {
        System.Console.WriteLine(array[4]);
    }
}
    


int num = InputNumber("Введите номер четверти: ");
FindQuarter(num); 

