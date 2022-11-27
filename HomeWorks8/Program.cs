
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] RandomArray2d() 
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

    int[,] newArray = new int[rows, columns]; 
    
    for(int i = 0; i < rows; i++) 
        for(int j = 0; j < columns; j++) 
            newArray [i,j] = new Random().Next(minValue, maxValue + 1); 
    return newArray;
}

void PrintArray2d(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Puzerek(int [,] array)
{
    for (int n = 1; n < array.GetLength(1) * (array.GetLength(1) - 1); n++)// повторять столько раз сколько вариаций пар в строке
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {   
                if (array[i, j] < array[i, j + 1]) //условие сортировки пузырьком
                {
                    int temp = array[i, j];
                    array[i, j] = array [i, j + 1];
                    array [i, j + 1] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] myArray = RandomArray2d();
PrintArray2d(myArray); 
Puzerek(myArray);
Console.WriteLine("Отсортированная матрица: ");
PrintArray2d(myArray); 

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

// void MinSumStr(int [,] array)
// {   
//     int str = 0;
//     int minSum = 0;
    
//     for(int i = 0; i < 1; i++)//находим Мин сумму 0 строки от которой будем отталкиваться
//     {   
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             minSum += array[i, j]; 
//         }
//     }

//     for(int i = 0; i < array.GetLength(0); i++) //перебераем все строки и находим номер строки
//     {   
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             sum = sum + array[i, j]; 
//         }
//         if (sum < minSum)
//         {
//            // minSum = sum;
//             str = i;
//         }
        
//     }
//     //Console.WriteLine($"Мин сумма {minSum}");
//     Console.WriteLine($"Номер строки {str + 1}");//чтоб понятней было какая строка нашлась добавил +1
     
       
// }

// Console.Clear();
// int[,] myArray = RandomArray2d();
// PrintArray2d(myArray); 
// MinSumStr(myArray);

//////////////////////////////////////////////////////////////////////////////////////////////////////
/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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
// int[,] Proizvedenie(int[,] array, int[,] array2)
// {
//     int[,] finArray = new int[array.GetLength(0), array2.GetLength(1)]; //создаем новую матрицу которая будет содержать кол строк от первой матрицы и кол столбцов от второй матрицы
    
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array2.GetLength(1); j++)
//         {    
//             for(int k = 0; k < array.GetLength(1); k++) 
//             {
//                 finArray[i, j] += array[i, k] * array2[k, j]; //заносим произведение двух матриц в новую матрицу, где i-сторока первой матрицы, j-столбец второй матрицы, а k-столбец первой матрицы и строка второй матрицы
//             }
//         }
//     }

//     return finArray;         
// }


// Console.Clear();
// int[,] myArray1 = RandomArray2d(); //создание первой матрицы
// PrintArray2d(myArray1);
// int[,] myArray2 = RandomArray2d();//создание второй матрицы
// PrintArray2d(myArray2); 
// int[,] fin = Proizvedenie(myArray1, myArray2);//результативная матрицы произведений двух матриц
// PrintArray2d(fin); 

///////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

// int[,,] RandomArray3d(int z, int x, int y) 
// {
//     int[,,] newArray = new int[z, x, y]; 
//     int count = 10;
//     for(int i = 0; i < z; i++) 
//     {
//         for(int j = 0; j < x; j++) 
//         {
//             for(int k = 0; k < y; k++)
//             {
//                 newArray [i, j, k] = count;
//                 count ++;
//                 int temp = newArray [i, j, k];
//                 newArray [k, j, i] = newArray [i, j, k];;
//                 newArray [i, j, k] = temp;
//             }
//         }
//     }
       
//     return newArray;
// }

// void PrintArray3d(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             for(int k = 0; k < array.GetLength(2); k++)
//         Console.WriteLine($"{array[i, j, k]}(z={i},x={j},y={k}) ");
        
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,,] myArray = RandomArray3d(2, 2, 2);
// PrintArray3d(myArray);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////
/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

// int[,] NumArray2d() 
// {   
//     Console.WriteLine("Программа, которая заполнит спирально симметричный массив");
//     Console.Write("Введите число которое будет значением количество строк и столбцов: ");
//     int sizeXY = Convert.ToInt32(Console.ReadLine());
//     int rows = sizeXY;
//     int columns = sizeXY;

//     int[,] newArray = new int[rows, columns]; 
    
//     int num = 1; 
        
//     for (int size = 0; size < rows / 2 + 1 && size < columns / 2 + 1; size++)
//     {

//         for(int j = 0 + size; j < columns - size; j++) 
//         {
//             newArray [size,j] = num ;
//             num ++;
//         }
//         for(int i = 1 + size; i < rows - size; i++) 
//         {
//             newArray [i,rows - 1 - size] = num;
//             num ++;
//         }
        
        
//         for(int j = columns - 2 - size; j >= 0 + size; j--)
//         {
//             newArray [columns - 1 - size,j] = num ;
//             num ++;
//         }
//         for(int i = rows - 2 - size; i >= 1 + size; i--)
//         {
//             newArray [i, size] = num ;
//             num ++;
//         }
        
//     }
//     return newArray;
// }

// void PrintArray2d(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write($"0{array[i, j]}  ");
//             else Console.Write(array[i, j] + "  ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Clear();
// int[,] myArray = NumArray2d(); 
// PrintArray2d(myArray);