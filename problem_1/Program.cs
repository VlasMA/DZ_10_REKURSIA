// Задача 64: Решение с помощью рекупсии. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1
// N = 5 -> "5, 4, 3, 2, 1";
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1";


int n = InputInt("Задайте число n: ");
int m = 1;
Console.WriteLine(NumbersNatural(n, m));

int NumbersNatural(int n, int m)
{
    if (n == m)
    {
    return m;
    }
        if (n > m)
        {
        Console.Write($"{NumbersNatural(n, m + 1)}, ");
        }
            if (n < m)
            {
                Console.WriteLine();
            }
return m;
}

int InputInt(string output)
{
Console.Write(output);
return int.Parse(Console.ReadLine());
}


