using System;

namespace Dia5_Dicionarios
{
    class Program
    {
        static void Main(String[] args)
        {
            /*            Dictionary<int, String> Agenda = new(); // Declaração de um dicionário

                        Agenda.Add(1, "Felipe"); // Adicionando valores ao dicinário
                        Agenda.Add(2, "Pet");
                        Agenda.Add(3, "Pirubola");
                        Agenda.Add(4, "Abu");

                        if (Agenda.ContainsKey(1)) // Declaração da Função ContainKey
                        {
                            Console.WriteLine(Agenda[1]);
                        }*/
            Dictionary<string, List<string>> Agenda = new();
            Agenda.Add("Felipe", new List<string> { "27996937796", "felipe@hotmail.com" });
            Agenda.Add("Pet", new List<string> { "55996937796", "pet@gmail" });
            Agenda.Add("Pirubola", new List<string> { "11996937796", "pbola@outlook.com" });
            Agenda.Add("Abu", new List<string> { "33996937796", "abu@hotmail.com" });

            Console.WriteLine("Lista de contatos:");
            foreach (var (nome, dados) in Agenda)
            {
                Console.WriteLine($"\nContato; {nome}");
                foreach (var item in dados)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}