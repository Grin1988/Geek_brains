// // 2 Группа (Ничего не возвращают, но могут принимать)

// // 1) void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }

// //Method2("Текст сообщения"); // Так вызывается Метод 2

// //или

// Method2(msg: "Текст сообщения"); // Так вызывается Метод 2


// 2)
void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст", 4); // "4" Сколько раз хотим увидеть "Текст"