namespace Dia14_ProjetoCRUD
{
    class Program
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Editar tarefa");
            Console.WriteLine("4 - Excluir tarefa");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção: ");

        }
        static void Main(String[] args)
        {
            ExibirMenu();
        }
    }
}