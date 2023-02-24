// Перебор слов // Общее решение
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0) // (string alphabet метод)(char[] word массив из букв)( int length = 0 длина слова)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return; // собираем и показываем слово
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[2]);
