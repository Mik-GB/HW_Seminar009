// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int GetMatrix(int numberM, int numberN)
{
  if (numberM == 0) return numberN + 1;
  if (numberN == 0) return GetMatrix(numberM - 1, 1);
  return GetMatrix(numberM - 1, GetMatrix(numberM, numberN - 1));
  //return GetMatrix(numberM, numberN);
}
for (int i = 0; i <= 3; i++)
{
  for (int j = 0; j <= 5; j++)
  {
    Console.WriteLine($"Функция Аккермана для чисел ({i},{j}) = {GetMatrix(i, j)}");
  }
}