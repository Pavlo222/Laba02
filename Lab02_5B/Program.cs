using System;

namespace Lab02_5B
{
    class Program
    {
        static void In1(out int n, out int m)
        {
            Console.Write("Введiть кiлькiсть рядкiв цiлочисельного масиву: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Введiть кiлькiсть стовпцiв цiлочисельного масиву: ");
            n = int.Parse(Console.ReadLine());
        }
        static void In2(out int[,] a, int n, int m)
        {
            int max = 100, min = -100;
            Random realRnd = new Random();
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = realRnd.Next(min, max + 1);
                }
            }
        }
        static void Out(int[,] a, int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);
                }
                Console.Write("\n");
            }
        }
        static void Max(int n, int m, int[,] a, out int k, out int l)
        {
            k = 0;
            l = 0;
            int max = a[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == max)
                    {
                        Console.WriteLine("max = a[{0}][{1}] = {2}", i, j, a[i, j]);
                        k = i;
                        l = j;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int k, l, m, n;
            In1(out n, out m);
            int[,] a = new int[m, n];
            In2(out a, n, m);
            Console.WriteLine("Введений цiлочисельний масив:");
            Out(a, n, m);
            Console.WriteLine("Знаходимо перший максимальний елемент масиву:");
            Max(n, m, a, out k, out l);
            Console.WriteLine("Масив пiсля замiни першого максимального елемента нулем:");
            a[k, l] = 0;
            Out(a, n, m);
            Console.WriteLine("Знаходимо другий максимальний елемент масиву:");
            Max(n, m, a, out k, out l);
            Console.WriteLine("Масив пiсля замiни другого максимального елемента нулем:");
            a[k, l] = 0;
            Out(a, n, m);
        }
    }
}
