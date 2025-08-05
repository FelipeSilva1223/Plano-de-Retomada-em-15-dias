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
        public static double LerNumero(string mensagem)
        {
            Console.WriteLine("Escolha um número: ");
            double numero = double.Parse(Console.ReadLine());
            return numero;
        }
        public static double Somar()
        {
            double x = LerNumero("Escolha o primeiro número: ");
            double y = LerNumero("Escolha o segundo número: ");
            Thread.Sleep(1000);
            return x + y;
        }
        public static double Subtrair()
        {
            double x = LerNumero("Escolha o primeiro número: ");
            double y = LerNumero("Escolha o segundo número: ");
            Thread.Sleep(1000);
            return x - y;
        }
        public static double Multiplicar()
        {
            double x = LerNumero("Escolha o primeiro número: ");
            double y = LerNumero("Escolha o segundo número: ");
            Thread.Sleep(1000);
            return x * y;
        }
        public static double Dividir()
        {
            double x = LerNumero("Escolha o primeiro número: ");
            double y = LerNumero("Escolha o segundo número: ");
            if (x != 0 && y != 0)
            {
                Thread.Sleep(1000);
                return x / y;
            } else
            {
                Thread.Sleep(1000);
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
                        Thread.Sleep(1000);
                        Console.WriteLine("O resultado é: " + Somar());
                        break;
                    case 2:
                        Console.WriteLine("Subtração selecionada");
                        Thread.Sleep(1000);
                        Console.WriteLine("O resultado é: " + Subtrair());
                        break;
                    case 3:
                        Console.WriteLine("Multiplicação selecionada");
                        Thread.Sleep(1000);
                        Console.WriteLine("O resultado é: " + Multiplicar());
                        break;
                    case 4:
                        Console.WriteLine("Divisao selecionada");
                        Thread.Sleep(1000);
                        Console.WriteLine("O resultado é: " + Dividir());
                        break;
                    case 0:
                        Console.Write("Encerrando");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Thread.Sleep(1000);
                        Console.WriteLine("\nAté a próxima!");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Thread.Sleep(1000);
                        break;
                    Thread.Sleep(1000);
                }
            } while (opcao != 0);
        }
    }
}