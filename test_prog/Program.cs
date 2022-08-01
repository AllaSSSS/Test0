// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3. Первоначальный массив ввести с клавиатуры или
// задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string item = array[i];
        if (item.Length <= 3) Console.Write ($"{item} ");
    }
    Console.WriteLine();
}

string[] stringArray = {"hello", "2", "world", ":-)"};
PrintArray (stringArray);
PrintNewArray (stringArray);
