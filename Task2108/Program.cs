/*
Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
int[,] coeff = new int[2, 2];
int[] crossPoint = new int[2];

void InputCoeff()
{
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}
int[] Decision(int[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void Output(int[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}
InputCoeff();
Output(coeff);
*/
/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.Write($"Введите М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[m];
for (int i = 0; i < m; i++)
{
    System.Console.WriteLine($"Введите {i + 1} число: ");
    Numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int Comparison(int[] Numbers)
{
    int count = 0;
    for (int i = 0; i < Numbers.Length; i++)
    {
        if (Numbers[i] > 0) count++;
    }
    return count;
}

Console.WriteLine($"Введено чисел больше 0: {Comparison(Numbers)} ");
