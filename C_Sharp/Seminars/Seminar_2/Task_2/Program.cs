﻿// Наишите программу, которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа

//456->46
//782->72
//918->98

Random rand = new Random(); // способ описания функции Random


int number = rand.Next(100, 1000); // new Random() класс позволяет 
//генерировать рандомные числа
// Next(10, 100) ФУНКЦИЯ генерирует случайные числа от 10(включаЯ) до 99 (100 не включая)
System.Console.WriteLine($"Случайное число {number}");

int num1 = number / 100;
int num3 = number % 10;

System.Console.WriteLine($"{num1}{num3}");

