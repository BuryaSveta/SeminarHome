// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.Write("Enter a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("The second digit of this number: "+ stringNumber[1]);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.Write("Enter a number: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("The third digit of this number: " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("There is no third digit in this number!");
}

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.Write("Enter the day of the week as a number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(It's a day off) YES!");
  }
  else Console.WriteLine("(It's a working day) NO!");
}

CheckingTheDayOfTheWeek(dayNumber);

*/
