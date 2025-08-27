namespace Dia14_ProjetoCRUD
{
    class Program
    {
        public static int ExibirMenu()
        {
            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Editar tarefa");
            Console.WriteLine("4 - Excluir tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string entrada = Console.ReadLine();

            return int.TryParse(entrada, out int opcao) ? opcao : -1;

        }
        static void AdicionarTarefa()
        {
            List<string> tarefas = new List<string>();
            foreach (string t in tarefas)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("Adicinoar tarefa selecionado!");
        }
        static void ExibirTarefas()
        {
            Console.WriteLine("Exibir tarefa selecionado!");
        }
        static void EditarTarefas()
        {
            Console.WriteLine("Editar tarefa selecionado!");
        }
        static void ExcluirTarefa()
        {
            Console.WriteLine("Excluir tarefa selecionado!");
        }
        static void Main(String[] args)
        {
            int opcao;

            bool sair = false;

            do
            {
                opcao = ExibirMenu();
                
                switch (opcao)
                {
                    case 1: AdicionarTarefa(); break;
                    case 2: ExibirTarefas(); break;
                    case 3: EditarTarefas(); break;
                    case 4: ExibirTarefas(); break;
                    case 0: sair = true; break;
                }
            } while (!sair);
        }
    }
}