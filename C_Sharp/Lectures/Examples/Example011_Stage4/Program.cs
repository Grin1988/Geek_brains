//Имется одномерный массив array из n элементов, 
//требуется найти элемент массива равнй find

//1.Устагновить счетчик index в позиции 0
//2.Если array[index] = find, алгоритм завершит работу успешно
//3.Увеличить индекс на 1
//4.Если index < n , то перейти к шагу 2.
//В противном случае алгоритм завершил работу безуспешно



void FillArray(int[] collection) // Метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col) // Метод печати массива на экран
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}



int IndexOf(int[] collection, int find)   // Метод описания, при котором будет возвращаться индекс
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // "-1 а не 0"Ставится искусственно для того, если мы будем искать несуществующий элемент, то выдает "-1"
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // если мы ставим break, то получаем первое число, если его нет, то последнее число
        }
        index++;
    }
    return position;
}



int [] array = new int[10];
FillArray(array);
PrintArray(array);

System.Console.WriteLine(); 
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);

