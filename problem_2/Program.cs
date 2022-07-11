// Задача 66: Решение с помощью рекурсии. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = InputInt("Введите m: ");
int n = InputInt("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

SummNatural(m, n, temp=0);

void SummNatural(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов : {summ} ");
    return;
  }
  SummNatural(m, n - 1, summ);
}

int InputInt(string output)
{
Console.Write(output);
return int.Parse(Console.ReadLine());
}