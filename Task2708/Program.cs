/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
System.Console.WriteLine("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во колонок n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

ArrayDouble(array);

void ArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
}

PrintArray(array);
void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            System.Console.Write(array[i,j]+"\t"); // \t - табуляция
        }
        System.Console.WriteLine();
    }
}
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
Console.WriteLine("Введите номер строчки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер колонки");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [5,5];
int[,] GetArray(int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
    return array;
}
int[,] resultMatrix = GetArray(n, m);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            System.Console.Write(inputMatrix[i, j] + "\t"); // \t - табуляция
        }
        System.Console.WriteLine();
    }
}
if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("элемента нет в массиве");
}
else
{
    Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}");
}
*/
/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

System.Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            System.Console.Write(inputMatrix[i, j] + "\t"); // \t - табуляция
        }
        System.Console.WriteLine();
    }
}
double meanrows = 0;
for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        meanrows = (meanrows + resultMatrix[i, j]);
    }
    meanrows = meanrows / columns;
    Console.Write(meanrows + "; " + "\t");
}
System.Console.WriteLine();