// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

void Sum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($" {sum} "); 
        return;
    }
    sum = sum + (m++);
    Sum(m, n, sum);
}

Sum(1, 15, 0);