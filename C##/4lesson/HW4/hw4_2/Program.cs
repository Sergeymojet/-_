//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Numb(int num)
{
    int numb = 0;

    for (int i = num; num != 0; num /= 10)
        numb += num % 10;

    return numb;
}
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine(Numb(num1));