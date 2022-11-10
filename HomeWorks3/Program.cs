// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая принимает на вход число и проверяет, является ли оно палиндромом..==");
void  Palindrom (long number)
{
    long save = number;
    long revers = 0;
    long temp = 0;
    while (number > 0)
    {
        temp = number % 10;
        number = number / 10;
        revers = revers * 10;
        revers = revers + temp;
    }
    
    if (revers == save) 
    {
        Console.WriteLine ($"Число {save} палиндром");
    }
    else 
    {
        Console.WriteLine ($"Число {save} не палиндром");
    }
}

Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());
Palindrom(num);








///////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.==");
// double TwoTochki(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
// }

// Console.SetCursorPosition(0, 10);
// Console.Write("Введите координаты Х первой точки: ");
// double xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y первой точки: ");
// double yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Z первой точки: ");
// double zA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Х второй точки: ");
// double xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y второй точки: ");
// double yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Z второй точки: ");
// double zB = Convert.ToInt32(Console.ReadLine());

// double dist = TwoTochki(xA, yA, zA, xB, yB, zB);
// Console.WriteLine($"Расстояние между точками {dist} ");

///////////////////////////////////////////////////////////////////////////////////////////////
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.==");
// void Kub(int num)
// {   
//     int current = 1;
//     while (current <= num)
//     {
//         Console.Write(current * current * current + " ");
//         current++;
//     }
// }

// Console.SetCursorPosition(0, 10);
// Console.Write("Введите число: ");
// int k = Convert.ToInt32(Console.ReadLine());
// Kub(k);