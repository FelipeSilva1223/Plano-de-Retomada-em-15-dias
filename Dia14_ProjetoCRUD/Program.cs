namespace Dia14_ProjetoCRUD
{
    class Program
    {
        public static void MensagemColorida(string mensagem, ConsoleColor cor)
        {
            var corAntiga = Console.ForegroundColor;
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ForegroundColor = corAntiga;
        }
        public static int ExibirMenu()
        {
            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Editar tarefa");
            Console.WriteLine("4 - Excluir tarefa");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            string entrada = Console.ReadLine();

            return int.TryParse(entrada, out int opcao) ? opcao : -1;

        }
        static void Main(String[] args)
        {
            MensagemColorida("Isso é um teste de vermelhor", ConsoleColor.Red);
            Console.WriteLine("abu");
        }
    }
}