// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] RandomArray2d() 
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество стобцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Мин значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Макс значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Полученная рандомно матрица: ");

    double[,] newArray = new double[rows, columns]; 
    
    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
        {
            newArray [i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(); 
            newArray[i, j] = Math.Round(newArray[i, j], 1); //сколько цифр отставить после запятой
        }
    return newArray;
}

void PrintArray2d(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
 
Console.Clear();
double[,] myArray = RandomArray2d();
PrintArray2d(myArray); 

///////////////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// int[,] RandomArray2d() 
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество стобцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Мин значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Макс значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     Console.WriteLine("Полученная рандомно матрица: ");

//     int[,] newArray = new int[rows, columns]; 
    
//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < columns; j++) 
//             newArray [i,j] = new Random().Next(minValue, maxValue + 1); 
//     return newArray;
// }

// void PrintArray2d(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Position(int [,] array) 
// {
//     Console.Write("Введите индекс строки: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите индекс стобца: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
 
//     if (rows >= array.GetLength(0) || columns >= array.GetLength(1)) Console.Write($"Числа с индексами [{rows}], [{columns}] = нет.");
//     else Console.Write($"Число c индексами [{rows}], [{columns}] = {array[rows, columns]}"); 
// }

// Console.Clear();
// int[,] myArray = RandomArray2d();
// PrintArray2d(myArray); 
// Position(myArray);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double[,] RandomArray2d() 
// {
//     Console.Write("Введите количество строк: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество стобцов: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Мин значение: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите Макс значение: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine();
//     Console.WriteLine("Полученная рандомно матрица: ");

//     double[,] newArray = new double[rows, columns]; 
    
//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < columns; j++) 
//             newArray [i,j] = new Random().Next(minValue, maxValue + 1); 
//     return newArray;
// }

// void PrintArray2d(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SredneeStolbec(double [,] array)
// {
//     int stolb = 1;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         double sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[j, i];
//         }
//         sum = sum / array.GetLength(1);
//         sum = Math.Round(sum, 1);
//         Console.WriteLine($" Cреднее арифметическое столбца {stolb} = {sum} ");
//         stolb++;
//     }    
// }

// Console.Clear();
// double[,] myArray = RandomArray2d();
// PrintArray2d(myArray); 
// SredneeStolbec(myArray);