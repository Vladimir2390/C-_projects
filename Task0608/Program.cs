/*
На "5" нужно сделать минимум 3 задачки. **
**Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Введите первое число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    System.Console.WriteLine(FirstNumber + " - максимальное число" + ", а " + SecondNumber + " - минимальное число");
}
else
{
    System.Console.WriteLine(SecondNumber + " - максимальное число" + ", а " + FirstNumber + " - минимальное число");
}
*/
/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Введите первое число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (FirstNumber > SecondNumber)
{
    max = FirstNumber;
}
else
{
    max = SecondNumber;
}
Console.WriteLine(max + " - максимальное из первых двух чисел");
if (max > ThirdNumber)
{
    max = max;
}
else
{
    max = ThirdNumber; 
}
Console.WriteLine(max + " - максимальное из трёх чисел");
*/
/*
Задача 6: Напишите программу, которая на вход принимает число и
выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 2 == 0)
{
    System.Console.WriteLine(Number + " - чётное число");
}
else
{
    System.Console.WriteLine(Number + " - НЕ чётное число");
}