//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] Random (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return newArray;
// }

// void Print(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int Chet(int[] array)
// {
//     int chet = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) chet++;
//     }
//     return chet;
// }

// Console.Clear();
// Console.Write("Введите значение размера массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = Random(size, 100, 999);
// Print(myArray);
// Console.WriteLine($"Количество четных чисел в массиве: {Chet(myArray)}");

// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Random (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue +1);
//     }
//     return newArray;
// }

// void Print(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int NeChet(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 0) sum += array[i];
//     }
//     return sum;
// }

// Console.Clear();
// Console.Write("Введите значение размера массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возможное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = Random(size, min, max);
// Print(myArray);
// Console.WriteLine($"Сумма элементов под нечетными индексами: {NeChet(myArray)}");

// ///////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Random(int size, int minValue, int maxValue)
{
    double[] newArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1) + new Random().NextDouble();
    }
    return newArray;
}

void Print(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MinMax(double[] array)
{
    double raznica = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
        if(max < array[i]) max = array[i];
    }
    raznica = max - min;
    return raznica;
}

Console.Write("Введите значение размера массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = Random(size, min, max);
Print(myArray);
Console.WriteLine($"Разница между Max и Min элементов массива: {MinMax(myArray)}");