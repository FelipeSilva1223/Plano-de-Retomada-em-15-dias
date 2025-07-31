using System;

namespace Dia2_Condicionais
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
            Console.WriteLine("Que dia é hoje? (digite entre 1 e 7");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "1":
                    Console.WriteLine("Hoje é Domingo!");
                    break;
                case "2":
                    Console.WriteLine("Hoje é Segunda-Feira!");
                    break;
                case "3":
                    Console.WriteLine("Hoje é Terça-Feira!");
                    break;
                case "4":
                    Console.WriteLine("Hoje é Quarta-Feira!");
                    break;
                case "5":
                    Console.WriteLine("Hoje é Quinta-Feira!");
                    break;
                case "6":
                    Console.WriteLine("Hoje é Sexta-Feira! Sextou bebê!!!");
                    break;
                case "7":
                    Console.WriteLine("Hoje é Sábado");
                    break;
                default:
                    Console.WriteLine($"{dia} não é um dia");
                    break;
            }
        }
        static void Main(string[] args)
            {
            //VerificarFaixaEtaria();
            QueDia();
            }
    }
}
