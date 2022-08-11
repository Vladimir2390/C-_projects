/*
**Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Write("Введите трёхзначное число:");
string inputNumber = Console.ReadLine();
Console.WriteLine($"{inputNumber[1]}");
*/
/*
Задача 13: Напишите программу, которая выводит
 третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число:");
string inputNumber = Console.ReadLine();
Console.WriteLine($"{inputNumber[2]}");
if (Number<100)
{
   Console.WriteLine("третьей цифры нет"); 
}


/*
Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Введите число:");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber == 1) Console.WriteLine("нет");
if (DayNumber == 2) Console.WriteLine("нет");
if (DayNumber == 3) Console.WriteLine("нет");
if (DayNumber == 4) Console.WriteLine("нет");
if (DayNumber == 5) Console.WriteLine("нет");
if (DayNumber == 6) Console.WriteLine("да");
if (DayNumber == 7) Console.WriteLine("да");
*/