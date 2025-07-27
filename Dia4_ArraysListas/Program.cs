using System;

namespace Dia4_ArraisListas
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] animais = { "Macaco", "Cachorro", "Papagaio", "Gato" };
            foreach (string animal in animais)
            {
                Console.WriteLine(animal);
            }
        }
    }
}