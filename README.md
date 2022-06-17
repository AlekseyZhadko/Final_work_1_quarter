# Итоговая проверочная работа.

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок схемой содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектов (не должно быть так что все залито одном коммитом, как минимум этапы 2,3, и 4 должны быть расположены в разных комитах)

## Задача:

Написать программу, которая из имеющегося массива строк формирует
массив из строк, длина которых меньше либо равна 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

## Решение задачи:

1. Размер изначального массива по умолчанию задаем равным 10:<br/><br/>
    > int SizeArray = 10;<br/>
2. Минимальное значение размера строки в массиве по умолчанию равно 1:<br/><br/>
    > int MinValueStringArray = 1;<br/>
3. Максимальгле значение размера строки в массиве по умолчанию равно 1:<br/><br/>
    > int MaxValueStringArray = 5;<br/>
4. Создаём изначальный массим, заполняя его методом FillArray:<br/><br/>
    > string[] Array = FillArray(SizeArray, MinValueStringArray, MaxValueStringArray);

5. Метод FillArray заполняет массив указанной размерности, случайными строками указанной длины: <br/><br/>
    >string[] FillArray(int SizeArray, int MinValue, int MaxValue)<br/>
{<br/>
    string[] result = new string[SizeArray];<br/>
    for (int i = 0; i < SizeArray; i++)<br/>
    {<br/>
        int StringSize = new Random().Next(MinValue, MaxValue);<br/>
        for (int j = 0; j < StringSize; j++)<br/>
        {<br/>
            result[i] += Convert.ToChar(new Random().Next(1, 255));<br/>
        }<br/>
    }<br/>
    return result;<br/>
}

6. Выводим на экран заполненный массим для проверки: <br/><br/>
    >Write("Изначальный массив: ");<br/>
PrintArray(Array);

7. Метод PrintArray печатает переданный в него массив <br/><br/>
    >void PrintArray(string[] array)<br/>
{<br/>
    for (int i = 0; i < array.Length; i++)<br/>
    {<br/>
        Write($"{array[i]}   ");<br/>
    }<br/>
    WriteLine();<br/>
}

8.  Задаём длину строки, для отбора строк из массива, изначально равна 3:<br/><br/>
    > int FilterSizeString = 3;<br/>
9.  Формируем новый массив, с подходящими под наши требования строками c помощью метода:<br/><br/>
    >string[] NewArray = FilterLengthStringArray(Array, FilterSizeString);

10. Метод FilterLengthStringArray перебирает переданный в него массив строк, из подходящих строк формирует новый массив и возвращает его: <br/><br/>
    >string[] FilterLengthStringArray(string[] Array,int FilterSize)<br/>
{<br/>
    string[] result = new string[Array.Length];<br/>
    int count = 0;<br/>
    for (int i = 0; i < Array.Length; i++)<br/>
    {<br/>
        if (Array[i].Length <= FilterSize)<br/>
        {<br/>
            result[count] = Array[i];<br/>
            count++;<br/>
        }<br/>
    }<br/>
    return result;<br/>
}<br/>
11. Печатаем для проверки новый сформированный массив строк, отвечающий требованиям:<br/><br/>
    >Write("Результат: ");<br/>
PrintArray(NewArray);

<br/><br/>
### P.S. Работу выполнил: Учащийся Жадько Алексей Алексеевич на программе Разработчик в группе 2248.
