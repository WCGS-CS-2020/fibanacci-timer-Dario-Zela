using System;
using System.Diagnostics;

class MainClass
{
    public static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();


        for (int x = 5; x < 50; x = x + 5)
        {
            sw.Reset();
            sw.Start();
            int fib = fibrecurse(x, false);
            sw.Stop();
            Console.WriteLine("Recursive {1}th Fib={2}, Elapsed={0}", sw.Elapsed, x, fib);
        }

        Console.WriteLine("\n\n");

        for (int x = 5; x < 50; x = x + 5)
        {
            sw.Reset();
            sw.Start();
            int fib = fibiterate(x, false);
            sw.Stop();
            Console.WriteLine("Iterative {1}th Fib={2}, Elapsed={0}", sw.Elapsed, x, fib);
        }

    }

    //
    // Return the xth fibanacci number using recursion
    // If print set to true, print out debug 
    //
    static int fibrecurse(int x, bool print = false)
    {
        int fib = 0;

        if (x == 0)
        {
            return 0;
        }
        if (x == 1)
        {
            return 1;
        }
        if (x != 0)
        {
            fib = fibrecurse(x - 1, false) + fibrecurse(x - 2,false);
        }


        if (print == true)
            Console.Write("Fibanacci = {0}\n", fib);
        return (fib);
    }

    //
    // Return the xth fibanacci number using iteration
    // If print set to true, print out debug 
    //

    static int fibiterate(int x, bool print = false)
    {
        int num1 = 1;
        int num2 = 1;
        for (int i = 1; i < x; i++)
		{
            int temp = num2;
            num2 = num1 + num2;
            num1 = temp;
		}
        if (print == true)
            Console.Write("Fibanacci = {0}\n", num1);
        return (num1);
    }
}

