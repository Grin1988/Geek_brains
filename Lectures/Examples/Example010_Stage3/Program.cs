﻿//Имется одномерный массив array из n элементов, 
//требуется найти элемент массива равнй find

//1.Устагновить счетчик index в позиции 0
//2.Если array[index] = find, алгоритм завершит работу успешно
//3.Увеличить индекс на 1
//4.Если index < n , то перейти к шагу 2.
//В противном случае алгоритм завершил работу безуспешно

int [] array = { 8, 5, 6, 7, 9, 8, 6, 7, 2 }; //Создание массива

int n = array.Length; // определяет колличество элементов в массиве, к которому обращаются
int find = 8;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break; // как только выполняется условие, алгоритм сразу завершится
    }
    index = index + 1;
}
