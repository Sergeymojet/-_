//Задача 2:
//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

string Number(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} {num / 100 * 10 + num % 10}";
    return "Число не 3-х значное";
}

Console.WriteLine(Number(int.Parse(Console.ReadLine())));
