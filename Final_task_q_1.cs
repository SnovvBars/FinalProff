void PrintMatrix(string[] matrix) // Печатаем массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("{0, 4} |  ", matrix[i]); // Форматируем вывод по шаблону |  24 |  18 |  34 |  76 |
    }
}

// string[] arrayStr = new string[] {"Russia", "Denmark", "Kazan"};
// string[] arrayStr = new string[] {"1234", "1567", "-2", "computer science"};
string[] arrayStr = new string[] {"Hello", "2", "world", ":-)"};    // Задаем массив

Console.WriteLine("\nЗаданные значения:");
PrintMatrix(arrayStr);                                              // Печать заданных значений

int count = 0;
for (int i = 0; i < arrayStr.Length; i++)                            // Подсчитываем число эдементов меньше равно 3х
if (arrayStr[i].Length <= 3) count++;

string[] newArray = new string[count];                              // Создаем массив подсчитанной размерности

if (count > 0)
{
    count = 0;
    for (int i = 0; i < arrayStr.Length; i++)                       // Опять прогоняем заданные значения 
    {
        if (arrayStr[i].Length <= 3)
        {
            newArray[count] = arrayStr[i];                          // и присваиваем найденные значения в новый массив
            count++;
        }
    }
    Console.WriteLine("\n\nНовые значения:");
    PrintMatrix(newArray);
    Console.WriteLine("\n");
}
else Console.WriteLine("\n\nНе найдено!\n");