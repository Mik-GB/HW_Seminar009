// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем сумму натуральных элементов в промежутке от M до N.
/// </summary>
/// <param name="numberM">M = start</param>
/// <param name="numberN">N = end</param>
/// <returns></returns>
int SumNumbers(int numberM, int numberN)
{
  //Базовый
  if (numberM == numberN) return numberM;
  //Рекурсивный
  return (numberM + SumNumbers(numberM + 1, numberN));
}

Console.WriteLine(SumNumbers(M, N));