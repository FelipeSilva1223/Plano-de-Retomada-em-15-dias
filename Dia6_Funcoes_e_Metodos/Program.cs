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
            /* string frase = Saudar("Felipe");
            Console.WriteLine(frase); */
            Console.WriteLine("Digite uma idade para verificar se está na maioridade");
            int idade = int.Parse(Console.ReadLine());
            bool maioridade = verificarMaioridade(idade);
            if (maioridade)
            {
                Console.WriteLine("É de maior");
            } else
            {
                Console.WriteLine("É de menor");
            }
        }
    }
}