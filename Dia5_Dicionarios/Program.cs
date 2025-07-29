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
            Dictionary<int, List<string>> Agenda = new();
            Agenda.Add(1, new List<string> { "Felipe", "27996937796" });
            Agenda.Add(2, new List<string> { "Pet", "55996937796" });
            Agenda.Add(3, new List<string> { "Pirubola", "11996937796" });
            Agenda.Add(4, new List<string> { "Abu", "33996937796" });

            Console.WriteLine("Lista de Contatos");
            foreach (var (key, value) in Agenda)
            {
                Console.WriteLine("\n");
                foreach (var item in value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}