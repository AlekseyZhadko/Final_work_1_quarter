using System;
using static System.Console;

Clear();

int SizeArray = 10;
int MinValueStringArray = 1;
int MaxValueStringArray = 5;
string[] Array = FillArray(SizeArray, MinValueStringArray, MaxValueStringArray);

string[] FillArray(int SizeArray, int MinValue, int MaxValue)
{
    string[] result = new string[SizeArray];
    for (int i = 0; i < SizeArray; i++)
    {
        int StringSize = new Random().Next(MinValue, MaxValue);
        for (int j = 0; j < StringSize; j++)
        {
            result[i] += Convert.ToChar(new Random().Next(1, 255));
        }
    }
    return result;
}

Write("Изначальный массив: ");
PrintArray(Array);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}   ");
    }
    WriteLine();
}

int FilterSizeString = 3;
string[] NewArray = FilterLengthStringArray(Array, FilterSizeString);

string[] FilterLengthStringArray(string[] Array,int FilterSize)
{
    string[] result = new string[Array.Length];
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= FilterSize)
        {
            result[count] = Array[i];
            count++;
        }
    }
    return result;
}

Write("Результат: ");
PrintArray(NewArray);

