
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

Console.WriteLine("Введите все элементы или пустую строку для прекращения ввода");
Console.Write($"Введите {i + 1} строку - ");
string str = Console.ReadLine();

//Вводим первичный массив
while (i < arrayLen)
{
    if (str == "")
    {
        if (i == 0)
        {
            Console.WriteLine("  Должен быть введен хотя бы 1 элемент  ");
            Console.Write($"Введите {i + 1} строку - ");
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
//Если нет подходящих элементов прерываем выполнение
if (countMaxLen == 0)
{
    Console.Write("  В массиве нет подходящих элементов  ");
    return;
}

string[] B = new string[countMaxLen];
Console.WriteLine($"\n Число строк c длинной <={maxLen} равно {countMaxLen}");

int countElements=i;
int j=0;
for (i=0;i<countElements;i++){
    if (A[i].Length<=maxLen){
        B[j]=A[i];
       Console.WriteLine(B[j]); 
       j++;
    }    
}
