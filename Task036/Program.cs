/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

using System.Xml.Serialization;

int[] FillArrayRnd()
{
    int arrSizeRnd = new Random().Next(2, 11);
    int[] retVal = new int[arrSizeRnd];
    Random rndGenVal = new Random();
    for (int i = 0; i < arrSizeRnd; i++) retVal[i] = (int)rndGenVal.Next(-99, 100);
    return retVal;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]);
        Console.Write(",");

    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int OddSum(int[] arr)
{
    int oddSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) oddSum+=arr[i];
    }
    return oddSum;
}

int[] tarray = FillArrayRnd();
PrintArray(tarray);
Console.WriteLine($" -> {OddSum(tarray)}");