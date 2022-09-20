// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

/*
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n);

void ShowNums(int m, int n)
{
    if(Math.Max(m,n) != Math.Min(m,n))
    ShowNums(Math.Max(m,n)-1, Math.Min(m,n));
    Console.Write($"{Math.Max(m,n)} ");
}
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

GapAmount(m, n);

void GapAmount(int m, int n)
{
    Console.Write(Sum(m - 1, n));
}

int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

/*
Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

FunctAkk(m,n);

void FunctAkk(int m, int n)
{
    Console.Write(Akk(m, n)); 
}

int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));
    }
}
*/