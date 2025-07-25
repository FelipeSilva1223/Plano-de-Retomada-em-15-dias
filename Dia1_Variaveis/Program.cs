using System.Security.Cryptography.X509Certificates;

namespace Dia1_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("Digite seu peso");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine("O seu IMC é igual a: " + imc);
        }
    }
}