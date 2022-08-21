/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] array = new int[17];
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine($"Array: [{String.Join(";", array)}]");
int ColvoChetNumber = 0;
for (int j = 0; j < arraySize; j++)
{
    if (array[j] %2 == 0) ColvoChetNumber++;
}
System.Console.WriteLine("Количество чётных в массиве = " + ColvoChetNumber);
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
SelectionSort(numbers);
PrintArray(numbers);
int min = numbers[0]; 
int max = numbers[numbers.Length-1];
System.Console.WriteLine($"минимальное число массива - {min}");
System.Console.WriteLine($"максимальное число массива - {max}");
int Sum = min+max;
System.Console.WriteLine($"сумма минимального и максимального числа массива = {Sum}");



void SelectionSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int minPOsition = i;
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[j] < numbers[minPOsition]) minPOsition = j;
        }
        int temporary = numbers[i];
        numbers[i] = numbers[minPOsition];
        numbers[minPOsition] = temporary;
    }
}
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}