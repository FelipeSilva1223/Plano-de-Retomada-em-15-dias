using System;
using System.Threading;

namespace Dia7_Calculadora
{
    class Program
    {
        public static int ExibirMenu()
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
        public static double Somar(double x, double y)
        {
            return x + y;
        }
        public static double Subtrair(double x, double y)
        {
            return x - y;
        }
        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public static double Dividir(double x, double y)
        {
            return x / y;
        }
        public static double LerNumero()
        {
            return 1;
        }
        static void Main(String[] args)
        {
            int opcao;
            do
            {
                opcao = ExibirMenu();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("teste2");
                        break;
                    case 2:
                        Console.WriteLine("teste2");
                        break;
                    case 3:
                        Console.WriteLine("teste3");
                        break;
                    case 4:
                        Console.WriteLine("teste4");
                        break;
                    case 0:
                        Console.WriteLine("Encerrando...");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}