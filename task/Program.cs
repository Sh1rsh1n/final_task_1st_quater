/*
    Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
    длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
    либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
    лучше обойтись исключительно массивами.
*/



/*
    метод GetArrayStringsLessThanThreeLetters()
    принимает массив строк, возвращает массив строк длина к-рых меньше, либо равна 3 символам

    в первом цикле, проверяем условие нахождения длины строки меньше, либо равна 3 символам,
    если условие выполняется, увеличиваем переменную счётчик(count) на 1.

    после подсчёта строк, инициализируем новый массив, размер к-рого будет равен переменной count.

    во втором цикле мы вновь проходим по входящему массиву и если условие выполняется,
    то записываем в новый массив найденное значение.
*/
string[] GetArrayStringsLessThanThreeLetters(string[] array)
{
    int size = array.Length;
    int count = 0;
    string[] tempArray;

    for (int i = 0; i < size; i++)
    {
        if (array[i] != null && array[i].Length <= 3 && array[i].Length > 0)
        {
            count++; 
        }
    }

    tempArray = new string[count];

    for(int i = 0, j = 0; i < size; i++)
    {
        if (array[i] != null && array[i].Length <= 3 && array[i].Length > 0)
        {
            tempArray[j] = array[i];
            j++; 
        }
    }

    return tempArray;
}

/*
    вспомогательный метод, для вывода в консоль элементов массива
*/
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}]");
    }
    Console.WriteLine();
}


Console.Write("Исходный массив: ");
string[] stringArray = { "", "M", "2", "apple", null, "3.14", "4", "1986", "1", null, "ILikeCoding...", "B", "B", "Alexey", "67", "RUS", "", "" };
printArray(stringArray);
Console.WriteLine();

string[] targetArray = GetArrayStringsLessThanThreeLetters(stringArray);
Console.Write("Массив после обработки: ");
printArray(targetArray);
Console.WriteLine();
