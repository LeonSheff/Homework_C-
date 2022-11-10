// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.==");
// int TwoCif(int num)
// {
//     int pervaya = num % 100;
//     int vtoraya = pervaya / 10;

//     return vtoraya;
// }

// Console.SetCursorPosition(0, 10);
// Console.Write("Введите трехзначное число: ");
// int chislo = Convert.ToInt32(Console.ReadLine());
// int resul = TwoCif(chislo);

// Console.WriteLine($"Вторая цифра {resul} от {chislo}");

////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.SetCursorPosition(40, 1);
Console.WriteLine("==Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.==");
int KolichestvoSimvolov(int num)
{   int n = 100;
    int current = 2;
    while (num / n > 1)
    {    n = n * 10;
        current++;
    }
    return current;
}

int Razryad(int num2)
{
    int x = 10;
        while (num2 - 1 > 0 )
    {
        x = x * 10;
        num2--;
    }
    
    return x;
} 
Console.SetCursorPosition(0, 10);
Console.Write("Введите число: ");
int vvod = Convert.ToInt32(Console.ReadLine());
int chislo = KolichestvoSimvolov(vvod);
//Console.WriteLine(chislo);
int finishnaya = Razryad(chislo);
//Console.WriteLine(proc);

int ostatok = finishnaya / 100;
int desyatki = finishnaya / 1000;
int fin= 0;
int fininsh = 0;
if (vvod / 100 == 0)
{   
    Console.WriteLine($"Третьей цифры нет у заданного числа {vvod}");
}
else
{
    fin = vvod % ostatok;
    fininsh = fin / desyatki;
    Console.WriteLine($"Третья цифра {fininsh} заданного числа {vvod}");
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.SetCursorPosition(40, 1);
// Console.WriteLine("==Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.==");
// void Vihodnoi(int num)
// {
//     if ( num >= 6 ) Console.WriteLine("Урааа, выходой!:)");
//     else Console.Write("Блин! Опять работать. :(");
// }

// Console.SetCursorPosition(0, 10);
// Console.Write("Введите цефру соответсрующему дню недели: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Vihodnoi(N);
