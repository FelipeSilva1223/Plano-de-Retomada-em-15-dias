using System;

namespace Dia2_Variaveis
{
    class Program
    {
        public static void VerificarFaixaEtaria()
        {
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 11)
            {
                Console.WriteLine("Você é criança");
            }
            else if (idade > 11 && idade < 18)
            {
                Console.WriteLine("Você é  adolescente");
            }
            else if (idade > 17 && idade < 59)
            {
                Console.WriteLine("Você é adulto");
            }
            else
            {
                Console.WriteLine("Você é idoso");
            }
            Console.Beep();
        }
        static void Main(string[] args)
        {
            VerificarFaixaEtaria();
        }
    }
}