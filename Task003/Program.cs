/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив[6, 7, 19, 345, 3]->нет
- 3; массив[6, 7, 19, 345, -3]->да */

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
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int ReadInt(){
    Console.Write("Введите искомый элемент: ");
    return Convert.ToInt32(Console.ReadLine());
}

void FindNumber (int [] array, int fnum){
    for (int i=0; i<array.Length; i++)
    {
        if (fnum == array[i])
        {
            Console.WriteLine(" -> да");
            return;
        }


    }
    Console.WriteLine(" -> нет");
}

int [] myArray = FillArrayRnd();
PrintArray(myArray);

int findNumber = ReadInt();
FindNumber(myArray, findNumber);


