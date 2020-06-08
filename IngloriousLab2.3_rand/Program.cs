using System;

namespace IngloriousLab2._3_rand
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введіть кількість елементів масиву");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            const int initRnd = 77;
            Random realRnd = new Random();
            Random repeatRnd = new Random(initRnd);

            Console.WriteLine("Введіть мінімальне значення");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть мінімальне значення");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                a[i] = realRnd.Next(min, max);
                Console.WriteLine("Елемент масиву №" + i + " — " + a[i]);
            }

            int p = 1;

            for (int k = 1; k < n; k += 2)
            {
                p *= a[k];
            }

            Console.WriteLine("Добуток парних елементів масиву = " + p);


            int maxarr = a[0];
            int j = 0;

            for (int k = 0; k < n; ++k)
            {
                if (Math.Abs(a[k]) > maxarr)
                {
                    maxarr = a[k];
                    j = k;
                }
            }

            int sum = 0;

            for (int k = 0; k < j; ++k)
            {
                sum += a[k];
            }

            Console.WriteLine("Сума елементів масиву до максимального = " + sum);
        }
    }
}