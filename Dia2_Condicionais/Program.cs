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
            Console.ReadKey();
        }
        public static void QueDia()
        {
            Console.WriteLine("Que dia é hoje? (digite entre 1 e 7)");
            int dia = Console.ReadLine() switch
            {
                <= 1 => Console.WriteLine("Hoje é Domingo"),
                <= 2 => Console.WriteLine("Hoje é Segunda-feira!"),
                <= 3 => Console.WriteLine("Hoje é Terça-feira!"),
                <= 4 => Console.WriteLine("Hoje é Quarta-feira!"),
                <= 5 => Console.WriteLine("Hoje é Quinta-feira!"),
                <= 6 => Console.WriteLine("Hoje é Sexta-feira! Sextou bebê!!!"),
                <= 7 => Console.WriteLine("Hoje é Sábado!"),
                _ => Console.WriteLine($"{dia} não é um dia")
            };
        }
        static void Main(string[] args)
        {
            //VerificarFaixaEtaria();
            QueDia();
        }
    }
}