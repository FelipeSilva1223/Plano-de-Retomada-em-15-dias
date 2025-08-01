namespace Dia8_Manipulacao_de_arquivos
{
    class Program
    {
        public static bool ChecarArquivo(string caminho)
        {
            if (File.Exists(caminho))
            {
                return true;
            }
            else return false;
        }
        public static void EscreverFrase(string caminho)
        {
            string frase = "Frase de teste numero 2";
            string frase2 = "\nnuma nova linha";

            if (ChecarArquivo(caminho))
            {
                File.WriteAllText(caminho, frase); // Escrever no arqui (substitui o antigo)
                File.AppendAllText(caminho, frase2); // Adicionar outro texto sem apagar o antigo
                Console.WriteLine($"A frase {frase} foi adicionada ao arquivo");
            }
            else Console.WriteLine("Arquivo não existe!");

        }
        public static void LerFrase(string caminho)
        {
            if (ChecarArquivo(caminho))
            {
                string texto = File.ReadAllText(caminho); // Ler arquivo
                Console.WriteLine(texto);
            }
            else Console.WriteLine("Arquivo não existe!");
        }
        public static void LerLinhas(string caminho)
        {
            if (ChecarArquivo(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            else Console.WriteLine("Arquivo não existe!");
        }
        static void Main(String[] args)
        {
            string caminhoDoArquivo = @"C:\Users\felip\Documents\meudocumento.txt";
            //EscreverFrase(caminhoDoArquivo);

            //LerFrase(caminhoDoArquivo);

            LerLinhas(caminhoDoArquivo);
        }
    }
}