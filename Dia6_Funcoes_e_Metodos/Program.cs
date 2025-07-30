using System;

namespace Dia6_Funcoes_e_Metodos
{
    class Program
    {
        public static String Saudar(string nome)
        {
            return $"Olá {nome}! Bem-vindo ao sistema.";
        }
        public static bool verificarMaioridade(int idade)
        {
            return idade >= 18;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("==== MENU ====");
            Console.WriteLine("1 - Saudar");
            Console.WriteLine("2 - Verificar maioridade");
            Console.WriteLine("==============");

            Console.WriteLine("Digite a opção desejada");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();
                string frase = Saudar(nome);
                Console.WriteLine(frase);
            }
            else if (escolha == 2)
            {
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());
                bool maioridade = verificarMaioridade(idade);
                if (maioridade)
                {
                    Console.WriteLine("Você é maior de idade");
                }
                else
                {
                    Console.WriteLine("Você é menor de idade");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}