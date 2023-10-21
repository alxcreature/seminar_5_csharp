/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76 */

double[] FillArray(int elementsNum)
{
    double[] filledArray = new double[elementsNum];
    for (int i = 0; i < elementsNum; i++)
    {
        System.Console.Write($"Введите {i} элемент массива: ");
        filledArray[i] = (double)Convert.ToInt32(Console.ReadLine());

    }
    return filledArray;
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) System.Console.Write($"{array[i]} ");
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.Write("]");
}

double DiffMinMax(double[] array){
    if (array.Length<2) return 0;
    double min=array[0];
    double max=array[1];
    if (min>max) {
        max=min;
        min=array[1];
    }

    for (int i=2; i<array.Length;i++){
        if (min>array[i]) min=array[i];
        if (max<array[i]) max=array[i];

    }

    return max-min;
}

System.Console.Write("Введите количество элементов мссива: ");
double[] diffarr = FillArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(diffarr);
System.Console.WriteLine($" -> {DiffMinMax(diffarr)}");