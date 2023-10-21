/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
 */

int[] FillArrayRnd()
{
    Random rndGenVal = new Random();
    int[] retVal = new int[rndGenVal.Next(2, 11)];

    for (int i = 0; i < retVal.Length; i++)
        retVal[i] = (int)rndGenVal.Next(-5, 6);

    return retVal;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] MultElementsInArray(int[] array)
{
    int[] resArray = new int[(array.Length + 1) / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        resArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1)
        resArray[resArray.Length - 1] = array[array.Length / 2];

    return resArray;
}

// -----------------

int[] myArray = FillArrayRnd();
PrintArray(myArray);
PrintArray(MultElementsInArray(myArray));