// Итоговая работа
// Написать программу, которая из имеющегося массива строк формирует
// массив из строк, длина которых маньше либо равна 3 символа.

Console.WriteLine("Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());
string[] handArray = new string[num];
FillStringArray(handArray);
Console.Write("[" + string.Join(", ", handArray) + "]");
Console.WriteLine();
int numLen = 3; // определение максимальной длины строки для вхождения в новый массив
int NewArrayLen = CountNewArrayLenght(handArray, numLen);
Console.WriteLine(NewArrayLen);

if (NewArrayLen == 0) Console.WriteLine("[]");
else
{
    string[] newArray = new string[NewArrayLen];
    FillNewStringArray(handArray, newArray, numLen);
    Console.Write("[" + string.Join(", ", newArray) + "]");
    Console.WriteLine();
}

void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}. Введите значение массива");
        array[i] = Console.ReadLine();
    }
}

int CountNewArrayLenght(string[] arr, int numLenght)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= numLenght) counter++;
    }
    return counter;
}