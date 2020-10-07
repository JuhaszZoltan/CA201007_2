using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA201007_2
{
    class Program
    {
        static int[] tomb = new int[100];
        static Random rnd = new Random();
        static void Main()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < 15; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Teglalap(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
            }
            Console.ReadKey();
        }
        static void Teglalap(int sz, int m)
        {
            --sz; --m;
            int kt = (Console.WindowHeight / 2) - (m / 2);
            int kl = (Console.WindowWidth / 2) - (sz / 2);
            Console.SetCursorPosition(kl, kt);

            //felső él
            for (int l = kl; l < kl + sz; l++)
            {
                Console.SetCursorPosition(l, kt);
                Thread.Sleep(10);
                Console.Write("*");
            }
            //jobb
            for (int t = kt; t < kt + m; t++)
            {
                Console.SetCursorPosition(kl + sz, t);
                Thread.Sleep(10);
                Console.Write("*");
            }
            //alsó
            for (int l = kl + sz; l >= kl; l--)
            {
                Console.SetCursorPosition(l, kt + m);
                Thread.Sleep(10);
                Console.Write("*");
            }
            //
            for (int t = kt + m; t >= kt; t--)
            {
                Console.SetCursorPosition(kl, t);
                Thread.Sleep(10);
                Console.Write("*");
            }
        }
    }
}
