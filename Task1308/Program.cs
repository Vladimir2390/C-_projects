/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
System.Console.WriteLine("Введите координату A по оси оХ: ");
int xA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату A по оси оY: ");
int yA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату A по оси оZ: ");
int zA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату B по оси оХ: ");
int xB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату B по оси оY: ");
int yB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату B по оси оZ: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xA-xB),2)+Math.Pow((yA-yB),2)+Math.Pow((zA-zB),2));
System.Console.WriteLine("расстояние между точками А и B в 3D = " + Math.Round(distance),2);
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица квадратов для N: ");
int n = 1;
double PowN =0;
while (n <= number)
{
    PowN = Math.Pow(n, 3);
    n++;
Console.WriteLine(PowN);
}
*/
/*
Задача 19
Напишите программу, которая принимает на вход
 пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
System.Console.WriteLine("Введите пятизначное число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int reverseNumber = Convert.ToInt32(Console.ReadLine());
if (inputNumber == reverseNumber)
{
    Console.WriteLine(inputNumber + "-" + "число палиндром");
}
Console.WriteLine(inputNumber + "-" + "НЕ ЯВЛЯЕТСЯ" + "числом палиндромом");
