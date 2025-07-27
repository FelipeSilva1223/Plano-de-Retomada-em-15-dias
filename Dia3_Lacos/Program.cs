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
                Console.WriteLine($"{contador}°");
                Console.Beep();
                Thread.Sleep(500);
            }
        }
        public static void ContarAte15()
        {
            for (int index = 0; index < 15; index++)
            {
                Console.WriteLine(index);
                Console.Beep();
                Thread.Sleep(500);
            }
        }
        static void Main(String[] args)
        {
            //ContarAte10();
            ContarAte15();
        }
    }
}