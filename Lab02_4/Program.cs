using System;

namespace Lab02_4
{
    public class Program
    {
        static public int Sum(int[] a, int n)
        {
            int l = 0, s;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                s = 0;
                if (a[i] > 0 && l == 1)
                {
                    l++;
                }
                while (l == 1 && s == 0)
                {
                    sum += a[i];
                    s = 1;
                }
                if (a[i] > 0)
                {
                    l++;
                }
            }
            return sum;
        }
        static public int Max(int[] a, int n)
        {
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть додатнiх елементiв одновимiрного масиву:");
            int n = int.Parse(Console.ReadLine());
            int max, sum;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool some = true;
                while (some)
                {
                    Console.Write("Введiть елемент одновимiрного масиву,a[{0}]=", i);
                    string S1 = Console.ReadLine();
                    if (double.Parse(S1) % 1 == 0)
                    {
                        a[i] = int.Parse(S1);
                        some = false;
                    }
                    else
                    {
                        Console.WriteLine("Введiть цiле число");
                    }
                }
            }
            max = Max(a, n);
            sum = Sum(a, n);
            Console.WriteLine("\nМаксимальний елемент масиву ={0}", max);
            Console.WriteLine("Сума елементiв масиву, розташованих мiж першим i другим додатними елементами масиву={0}", sum);
        }
    }
}
