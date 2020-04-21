using System;

namespace Lab02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер у списку групи: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + n.ToString() + "-ий в списку:");
            switch (n)
            {
                case 1: Console.WriteLine("Борщовецький Дмитро"); break;
                case 2: Console.WriteLine("Вульчак Павло"); break;
                case 3: Console.WriteLine("Горечий Юрiй"); break;
                case 4: Console.WriteLine("Грозовський Владислав"); break;
                case 5: Console.WriteLine("Захарчук Петро"); break;
                case 6: Console.WriteLine("Iванова Ангелiна"); break;
                case 7: Console.WriteLine("Кузьмiнський Вiталiй"); break;
                case 8: Console.WriteLine("Кутасевич Владислав"); break;
                case 9: Console.WriteLine("Лакус Михайло"); break;
                case 10: Console.WriteLine("Мальгiн	Павло"); break;
            }
        }
    }
}
