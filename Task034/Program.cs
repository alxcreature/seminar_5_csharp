/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите 
программу, которая покажет количество чётных чисел в 
массиве. 
[345, 897, 568, 234] -> 2
*/


int[] FillArrayRnd()
{
    int arrSizeRnd = new Random().Next(2, 11);
    int[] retVal = new int[arrSizeRnd];
    Random rndGenVal = new Random();
    for (int i = 0; i < arrSizeRnd; i++) retVal[i] = (int)rndGenVal.Next(100, 1000);
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

int EvenCount(int[] arr)
{
    int evenCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) evenCount++;
    }
    return evenCount;
}

int[] tarray = FillArrayRnd();
//FillArrayRnd(tarray);
PrintArray(tarray);
Console.WriteLine($" -> {EvenCount(tarray)}");