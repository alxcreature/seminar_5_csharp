// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 -> (-9, 10)
    }

    return tempArray;
}

// -------------- Показавать 2й способ
void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        Console.Write(arrayForPrint[i] + " ");
    }
}

void SumPositiveAndNegativeNumbers(int[] array, out int sumPositive, out int sumNegative)
{
    sumNegative = 0;
    sumPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
}

// -----------------------------

int[] array = GenerateArray(5, -5, 5);
PrintArray(array);

SumPositiveAndNegativeNumbers(array, out int sumP, out int sumN);

System.Console.WriteLine($"\nСумма положительных чисел: {sumP}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumN}");