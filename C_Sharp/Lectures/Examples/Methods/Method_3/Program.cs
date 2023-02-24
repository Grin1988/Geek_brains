// 3 Группа Что-то возвращают, но могут принимать(Обязательно указывают тип данных которые возвращаем)

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3(); // Так вызывается Метод 3
System.Console.WriteLine();
