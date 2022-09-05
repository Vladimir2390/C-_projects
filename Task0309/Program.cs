/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString(); 
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine($"Числа от {M} до {N}: {PrintNumbers(M, N)}");
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
GetSumNumbers(M, N, 0);

void GetSumNumbers (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
   GetSumNumbers(M, N, sum);
}

