// Собрать строку с числами от a до b, a ≤ b


string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++) // Запускаем цикл, который запускает счетчик от а до <= b
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    // if (a <= b) return $"{a} " + NumbersRec(a + 1, b); //если условие выполняется, то мы собираем строку со значением {a}, 
                                                       // при этом создается копия "NumbersRec(a + 1, b)" c увеличенным а+1
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";  // при данном исполнение кода вызов функции на 1 раз меньше
    else return String.Empty; // возвращаем пустую строку если условие не выполнилось
}
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10