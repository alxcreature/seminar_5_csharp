// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    int[] retVal = new int[rndGenVal.Next(2, 11)];

    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = (int)rndGenVal.Next(-99, 100);

    return retVal;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 9 && array[i] < 100)
            count++;

    return count;
}
// -----------------

int[] myArray = FillArrayRnd();
PrintArray(myArray);
Console.WriteLine(CountElements(myArray));