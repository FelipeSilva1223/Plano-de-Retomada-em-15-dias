namespace Dia11_Datas_e_Horarios
{
    class Program
    {
        
        
        static void Main(String[] args)
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine("-------- AGENDA --------");
            Console.WriteLine("Digite o nome do evento:");
            string eventoNome = Console.ReadLine();

            Console.WriteLine("Digite a data do evento: (dd/MM/yyyy)");
            String dataEntrada = Console.ReadLine();


            if (DateTime.TryParse(dataEntrada, out DateTime dataEvento))
            {
                TimeSpan contagem = dataEvento - agora;
                Console.WriteLine($"Faltam {contagem.Days} dias para \"{eventoNome}\"");
            } else
            {
                Console.WriteLine("Formato da data errado!");
            }
        }
    }
}