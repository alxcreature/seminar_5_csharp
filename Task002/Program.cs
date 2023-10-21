/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
 */


using System.Reflection.Metadata.Ecma335;

int[] FillArrayRnd()
{
    int arrSizeRnd = new Random().Next(2, 11);
    int[] retVal = new int[arrSizeRnd];
    Random rndGenVal = new Random();
    for (int i = 0; i < arrSizeRnd; i++)
        retVal[i] = (int)rndGenVal.Next(-9, 10);
    
    return retVal;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        Console.Write(",");

    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

void ArrayReplaceNegPos(int[] array){
    
    for(int i=0; i<array.Length; i++)
        array[i]=-array[i];
 }


int [] myArray = FillArrayRnd();
PrintArray(myArray);
ArrayReplaceNegPos(myArray);
Console.WriteLine();
PrintArray(myArray);

/* void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
} */