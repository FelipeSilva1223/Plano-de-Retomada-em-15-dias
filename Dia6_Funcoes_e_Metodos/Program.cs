using System;

namespace Dia6_Funcoes_e_Metodos
{
    class Program
    {
        public static String Saudar(string nome)
        {
            return $"Olá {nome}! Bem-vindo ao sistema.";
        }
        static void Main(String[] args)
        {
            string frase = Saudar("Felipe");
            Console.WriteLine(frase);
        }
    }
}