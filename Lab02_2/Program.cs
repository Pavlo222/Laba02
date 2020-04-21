using System;

namespace Lab02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|  X:  | Y=f(X): |");
            double a = 1, b = 6, dx = 0.2, y,x=a;
            while(x<=b)
            {
                y = Math.Log10(x);
                y = Math.Round(y, 4);
                Console.WriteLine("| {0,-4} | {1,-7} |",x,y);
                x += dx;
                x = Math.Round(x, 1);
            }
        }
    }
}
