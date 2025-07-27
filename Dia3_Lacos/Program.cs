using System;
using System.Threading;

namespace dia3_lacos
{
    class Program
    {
        public static void ContarAte10()
        {
            int contador = 0;
            while (contador < 10)
            {
                contador += 1;
                Console.WriteLine($"{contador}");
                Console.Beep();
                Thread.Sleep(500);
            }
        }
        static void Main(String[] args)
        {
            ContarAte10();
        }
    }
}