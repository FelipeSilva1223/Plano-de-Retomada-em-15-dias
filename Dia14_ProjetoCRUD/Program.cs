namespace Dia14_ProjetoCRUD
{
    class Program
    {

        static List<string> tarefas = new();
        public static int ExibirMenu()
        {
            Console.WriteLine("=== GERENCIADOR DE TAREFAS ===");
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Listar tarefas");
            Console.WriteLine("3 - Editar tarefa");
            Console.WriteLine("4 - Excluir tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string entrada = (Console.ReadLine() ?? "").Trim();

            return int.TryParse(entrada, out int opcao) ? opcao : -1;

        }
        static void AdicionarTarefa()
        {
            Console.Write("\nDigite a descrição da tarefa: ");
            string tarefa = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrEmpty(tarefa)){ Console.WriteLine("Descrição vazia. Operação cancelada!"); return; }
            else { 
                tarefas.Add(tarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
        }
        static void ExibirTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("\n(Lista vazia)\n");
                return;
            }
            Console.Clear();
            Console.WriteLine("--- Lista de tarefas ---");
            int index = 1;
            foreach (string tarefa in tarefas)
            {
                Console.WriteLine($"{index} - {tarefa}");
                index++;
            }
            Console.WriteLine("------------------------");
        }
        static void EditarTarefas()
        {
            ExibirTarefas();
            if (tarefas.Count == 0) return;
            Console.Write("Escolha qual tarefa vai editar: ");
            ExibirTarefas();
            string entrada = (Console.ReadLine() ?? "");
            if (int.TryParse(entrada, out int saida))
            {
                string novaDescricao = (Console.ReadLine() ?? "");
                tarefas[saida - 1] = novaDescricao;
            }
            else { Console.WriteLine("Número Inválido"); return; }
        }
        static void ExcluirTarefa()
        {
            ExibirTarefas();
            if (tarefas.Count > 0)
            {
                Console.WriteLine("Escolha qual tarefa vai excluir");
                string entrada = (Console.ReadLine() ?? "");
                if (int.TryParse(entrada, out int saida) && saida >= 1 && saida <= tarefas.Count)
                {
                    tarefas.RemoveAt(saida - 1);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else { Console.WriteLine("Número inválido!"); }
            }
            else return;
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
                    case 4: ExcluirTarefa(); break;
                    case 0: sair = true; break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
            } while (!sair);
        }
    }
}