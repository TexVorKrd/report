
Console.Clear();

Console.Write("Введите размерность массива ");
int arrayLen = Convert.ToInt32(Console.ReadLine());

// Первичный массив строк
string[] A = new string[arrayLen];
int i = 0;

//Максимальная длинна строки при отборе
int maxLen = 3;

//Число строк с длиннов не больше макмимального значения
int countMaxLen = 0;

Console.Write($"Введите {i + 1} строку - ");
string str = Console.ReadLine();

//Вводим первичный массив
while (i < arrayLen)
{
    if (str == "")
    {
        if (i == 0)
        {
            Console.Write("  Должен быть введен хотя бы 1 элемент  ");
            Console.Write($"Введите {i + 1} строку");
            str = Console.ReadLine();
            continue;
        }
        else
        {
            break;
        }
    }
    A[i] = str;
    if (str.Length <= maxLen) countMaxLen++;
    i++;

    Console.Write($"Введите {i + 1} строку - ");
    str = Console.ReadLine();
}
