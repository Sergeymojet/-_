void Chisla(int a)
{

    if (a == 0) return;
    if (a % 2 == 0)
    {
        Chisla(a - 2);
        Console.Write($" {a} ");
    }
    else
    {
        a = a - 1;
        Chisla(a - 2);
        Console.Write($" {a} ");

    }
}
Chisla(8);