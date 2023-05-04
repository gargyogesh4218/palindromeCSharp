using System;

class Program
{
    
    static void Main(string[] args)
    {
        primeOrNot();

        Console.WriteLine("enter a number which to be check if it is palindrome or not :");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = n;

        int m = 0;
        while (n > 0)
        {
            int r = n % 10;
            m = 10 * m + r;
            n = n / 10;
        }

        if (a == m)
            Console.WriteLine("palindrome");
        else
            Console.WriteLine("not palindrome");

        Console.ReadKey();
    }
}
