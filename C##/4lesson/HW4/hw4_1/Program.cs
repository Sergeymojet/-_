//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Без модуля Math, используем цикл for.
double PNum(int a, int b)
{
    double npow = 1;
    int b_abs = Math.Abs(b);

    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            npow *= a;
        else
            npow /= a;

    }
    return npow;
}

Console.WriteLine("Введите число 1: ");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numb2 = int.Parse(Console.ReadLine());

Console.WriteLine(PNum(numb1, numb2));