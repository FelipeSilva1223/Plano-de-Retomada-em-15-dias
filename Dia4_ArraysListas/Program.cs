using System;
using System.Collections.Generic;

namespace Dia4_ArraisListas
{
    class Program
    {
        public static void Arrays()
        {
            //String[] comidas = ["Arroz", "Feijão", "Macarrão", "Carne", "Alface"]; - forma simplificada de inserir valores

            String[] comidas = new string[5];
            comidas[0] = "Arroz";
            comidas[1] = "Feijão";
            comidas[2] = "Macarrão";
            comidas[3] = "Carne";
            comidas[4] = "Alface";

            Console.WriteLine("Comidas (usando arrays):");
            foreach (String comida in comidas)
            {
                Console.WriteLine(comida);
            }

            string[] animais = { "Macaco", "Cachorro", "Papagaio", "Gato" };
            animais[2] = "Boi";
            foreach (string animal in animais)
             {
                 Console.WriteLine(animal);
             }
            /*for (int i = 0; i < animais.Length; i++) - é a mesma função porém usando for
            {
                Console.WriteLine(animais[i]);
            }*/
        }
        public static void Listas()
        {
            List<string> comidas = new List<string>();
            comidas.Add("Arroz");
            comidas.Add("Feijão");
            comidas.Add("Macarrão");
            comidas.Add("Carne");

            comidas.Remove("Carne");

            comidas.Insert(0, "Pão");

            comidas.Contains("Pão"); // Retorna True ou False dependendo se a palavra está na lista

            //comidas.Sort();  Organiza a lista em ordem alfabetica

            //comidas.Reverse(); // Organiza a lista em ordem alfabetica ao contrario

            //comidas.Clear(); limpa a lista

            Console.WriteLine("Comidas (usando Listas)");
            Console.WriteLine($"Existem {comidas.Count} alimentos na lista de comidas:");
            Console.WriteLine($"Macarrão está no index {comidas.IndexOf("Macarrão")}");
            foreach (string comida in comidas)
            {
                Console.WriteLine(comida);
            }
        }
        static void Main(String[] args)
        {
            //Arrays();
            Listas();
        }
    }
}