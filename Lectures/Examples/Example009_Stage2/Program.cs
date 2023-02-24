int Max(int arg1, int arg2, int arg3) // описание функции
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;

    return result;
}

int [] array = {1,5,6,7,9,8,6,7,2}; //Создание массива

array [0] = 12; //В "0" ИНДЕКС ВМЕСТО 1 ЗАПИСЫВАЕМ 12
System.Console.WriteLine(array [4]); //ОБРАЩАЕМСЯ К МАССИВУ И ПОЛУЧАЕМ В ТЕРМИНАЛЕ ЗНАЧЕНИЕ С ИНДЕКСОМ 0 = 12

int result = Max(Max(array[0], array[1], array[2]),
                 Max(array[3], array[4], array[5]),
                 Max(array[6], array[7], array[8]));

System.Console.WriteLine(result);
                