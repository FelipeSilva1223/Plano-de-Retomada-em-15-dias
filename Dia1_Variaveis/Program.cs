using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Dia1_variaveis
{
    class Program
    {
        public static void CalcularIMC()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Calculadora de IMC");
            Console.WriteLine("------------------");
            Console.WriteLine("Digite seu peso");
            float peso = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Digite sua altura: ");
            float altura = float.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            float imc = peso / (altura * altura);
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O seu IMC é igual a: {imc:F2}");
            Console.WriteLine("---------------------------");
        }
        static void Main(string[] args)
        {
            CalcularIMC();
        }
    }
}