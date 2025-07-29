using System;

namespace Dia5_Dicionarios
{
    class Program
    {
        static void Main(String[] args)
        {
            Dictionary<int, String> Agenda = new(); // Declaração de um dicionário

            Agenda.Add(1, "Felipe"); // Adicionando valores ao dicinário
            Agenda.Add(2, "Pet");
            Agenda.Add(3, "Pirubola");
            Agenda.Add(4, "Abu");

            if (Agenda.ContainsKey(1)) // Declaração da Função ContainKey
            {
                Console.WriteLine(Agenda[1]);
            }
        }
    }
}