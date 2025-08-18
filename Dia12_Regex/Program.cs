using System.Text.RegularExpressions;

namespace Dia12_Regex
{
    class Program
    {
        public static void ExibirMenu()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("--- VALIDADADOR ---");
                Console.WriteLine("O que deseja validar?");
                Console.WriteLine("1 - Email");
                Console.WriteLine("2 - CPF");
                Console.WriteLine("3 - Sair");
                string escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Digite o email:");
                        string email = Console.ReadLine();
                        ValidarEmail(email);
                        break;
                    case "2":
                        Console.WriteLine("Digite o CPF:");
                        string cpf = Console.ReadLine();
                        ValidarCpf(cpf);
                        break;
                    case "3":
                        Console.WriteLine("Saindo...");
                        Thread.Sleep(3000);
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.\n");
                        break;
                }
            } while (continuar);
        }
        public static void ValidarEmail(string entrada)
        {
            if (Regex.IsMatch(entrada, @"[^@\s\.]+@[^@\s\.]+.[^@\s\.]+$"))
            {
                Console.WriteLine("Email válido!\n");
            }
            else
            {
                Console.WriteLine("Email inválido!\n");
            }
        }
        public static void ValidarCpf(string entrada)
        {
            if (Regex.IsMatch(entrada, "^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}"))
            {
                Console.WriteLine("CPF válido!");
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }
        }
        static void Main(String[] args)
        {
            ExibirMenu();
        }
    }
}