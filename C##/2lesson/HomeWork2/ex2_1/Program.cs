//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string Number(int num)
{   
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "The number is not three-digit!";
}

Console.WriteLine(Number(int.Parse(Console.ReadLine())));