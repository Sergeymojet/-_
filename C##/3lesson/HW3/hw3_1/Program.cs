//


string Palindrome(int n)
{  
    int num = 10000;
    if (n > 100000 || n < 10000)
        return "неправильное число";
    else        
        while (num > 1)
        {
            if (n / num % 10 != n % 10)
                return "Not palindrome";
            n /= 10;
            num /= 100;
        }    
        return "Palindrome";
}

Console.WriteLine(Palindrome(int.Parse(Console.ReadLine())));


