using System;

namespace Lab02_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть кiлькiсть додатнiх елементiв одновимiрного масиву:");
            int n = int.Parse(Console.ReadLine());
            int maxx;
            int l = 0, s;
            int sum = 0;
            Random realRnd = new Random();
            int min = -100, max = 100;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = realRnd.Next(min, max+1);
            }
            maxx = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > maxx)
                {
                    maxx = a[i];
                }
            }
            Console.WriteLine("\nМаксимальний елемент масиву ={0}", maxx);
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
            Console.WriteLine("Сума елементiв масиву, розташованих мiж першим i другим додатними елементами масиву={0}", sum);
        }
    }
}
