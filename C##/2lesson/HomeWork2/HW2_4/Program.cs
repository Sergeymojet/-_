//Задача 4:
//Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.


void Week(int num)
{
    string text = "not_weekend";

    if (num == 7 || num == 6) text = "weekand!";
    Console.WriteLine($"{num} {text}");
}

Week(int.Parse(Console.ReadLine()));