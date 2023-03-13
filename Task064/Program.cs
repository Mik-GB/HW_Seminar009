// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печатаем все натуральные числа в промежутке от N до 1.
/// </summary>
/// <param name="start">N = start</param>
/// <param name="end">1 = end</param>
/// <returns></returns>
string PrintNumbers(int start, int end)
{
  //Базовый
  if (start == end) return start.ToString();
  //Рекурсивный
  return (start + ", " + PrintNumbers(start - 1, end));
}

Console.WriteLine(PrintNumbers(N, 1));