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
            string avaliacao = "";
            if (imc < 18.5) avaliacao = "abaixo do peso";
            else if (imc >= 18.5 && imc <= 24.9) avaliacao = "peso normal";
            else if (imc >= 25 && imc <= 29.9) avaliacao = "sobrepeso" ;
            else if (imc >= 30 && imc <= 34.9) avaliacao = "obesidade grau I";
            else if (imc >= 35 && imc <= 39.9) avaliacao = "obesidade grau II";
            else if (imc > 40) avaliacao = "obesidade grau III";
            Console.WriteLine("---------------------------");
            Console.WriteLine($"O seu IMC é igual a: {imc:F2}, você está com {avaliacao}.");
            Console.WriteLine("---------------------------");
        }
        static void Main(string[] args)
        {
            CalcularIMC();
        }
    }
}