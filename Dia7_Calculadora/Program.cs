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
        public static double Somar()
        {
            Console.WriteLine("Escolha o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            return x + y;
        }
        public static double Subtrair()
        {
            Console.WriteLine("Escolha o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            return x - y;
        }
        public static double Multiplicar()
        {
            Console.WriteLine("Escolha o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            return x * y;
        }
        public static double Dividir()
        {
            Console.WriteLine("Escolha o primeiro número: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número: ");
            double y = double.Parse(Console.ReadLine());
            if (x != 0 && y != 0)
            {
                return x / y;
            } else
            {
                return 0;
            }
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
                        Console.WriteLine("Soma selecionada");
                        Console.WriteLine("O resultado é: " + Somar());
                        break;
                    case 2:
                        Console.WriteLine("Subtração selecionada");
                        Console.WriteLine("O resultado é: " + Subtrair());
                        break;
                    case 3:
                        Console.WriteLine("Multiplicação selecionada");
                        Console.WriteLine("O resultado é: " + Multiplicar());
                        break;
                    case 4:
                        Console.WriteLine("Divisao selecionada");
                        Console.WriteLine("O resultado é: " + Dividir());
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