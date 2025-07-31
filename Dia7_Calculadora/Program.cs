using System;

namespace Dia7_Calculadora
{
    class Program
    {
        public static int ExibirMenu(int opc)
        {
            Console.WriteLine("==== CALCULADORA ====");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            int acao = int.Parse(Console.ReadLine());
            return acao;
        }
        static void Main(String[] args)
        {
            int opcao = 5;
            while (opcao != 0)
            {
                int comando = ExibirMenu(opcao);
            }
        }
    }
}