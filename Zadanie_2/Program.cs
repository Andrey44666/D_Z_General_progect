// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arrayA = new string[4] {"hello", "2", "world", ":-)"};
string[] arrayB = new string[arrayA.Length];

void ResultArray(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA [i].Length <= 3)
        {
        arrayB [count] = arrayA[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArray(arrayA, arrayB);
PrintArray(arrayB);