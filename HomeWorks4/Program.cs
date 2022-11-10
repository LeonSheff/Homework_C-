// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int AB(int a1, int b1)
// {
//     int step = 1;
//     for (int i = 0; i < b1; i++)
//     {
//         step = step * a1;
//     }
//     return step;
// }

// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(циклом)==");
// Console.SetCursorPosition(0, 10);
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число степени: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {a} в степени {b} = {AB(a,b)}");

/////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
//     int sum = 0;
//     int temp = 0;
//     while (num > 0)
//     {
//         temp = num % 10;
//         num = num / 10;
//         sum = sum + temp;
//     }
//     return sum;
// }
// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход число и выдаёт сумму цифр в числе.==");
// Console.SetCursorPosition(0, 10);
// Console.Write("Введите число: ");
// int chislo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр {Sum(chislo)} числа {chislo}");

/////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int size) 
{
    int[] newArray = new int[size]; 
    int num = 1;
    for (int index = 0; index < size; index++)
    {    
        Console.Write($"Введите {num} элемент массива: ");
        newArray[index] = Convert.ToInt32(Console.ReadLine()); 
        num++;
    }
    return newArray;
}
void PrintArray (int[] col) 
{
    for (int position = 0; position < col.Length; position++) 
    {    
        Console.Write($"{col[position]} ");
    }
    Console.WriteLine();
}
Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая запрашивает размер массива и элементы массива и выводит их на экран.==");
Console.SetCursorPosition(0, 10);
Console.Write("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(s));