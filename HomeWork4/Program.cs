// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.Write("Enter a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int num = a;

for (int i = 1; i < b; i++)
{
num = num * a;
}
Console.WriteLine("A to the power of B is equal to: " + num);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while ( n > 0)
{
int num = n % 10;
n = n / 10;
sum = sum + num;
}
Console.WriteLine("The sum of all digits in a number is " + sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int [] CreateRandomArray = new int[8];
Console.Write("[");
for (int i = 0; i < CreateRandomArray.Length; i++)
 {
    CreateRandomArray [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return CreateRandomArray[a];
}
*/