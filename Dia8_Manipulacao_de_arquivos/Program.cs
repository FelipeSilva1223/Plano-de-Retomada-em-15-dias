﻿namespace Dia8_Manipulacao_de_arquivos
{
    class Program
    {
        public static bool ChecarArquivo(string arquivo)
        {
            return File.Exists(arquivo);
        }
        public static void EscreverFrase(string arquivo)
        {
            try
            {
                string frase = "Frase de teste numero 2";
                string frase2 = "\nnuma nova linha";

                if (ChecarArquivo(arquivo))
                {
                    File.WriteAllText(arquivo, frase); // Escrever no arqui (substitui o antigo)
                    File.AppendAllText(arquivo, frase2); // Adicionar outro texto sem apagar o antigo
                    Console.WriteLine($"A frase {frase} foi adicionada ao arquivo");
                }
                else Console.WriteLine("Arquivo não existe!");

            } catch (IOException ex)
            {
                Console.WriteLine("Erro ao escrever no arquivo: " + ex.Message);
            } catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Acesso negado: " + ex.Message);
            }

        }
        public static void LerFrase(string arquivo)
        {
            try
            {
                if (ChecarArquivo(arquivo))
                {
                    string texto = File.ReadAllText(arquivo); // Ler arquivo
                    Console.WriteLine(texto);
                }
                else Console.WriteLine("Arquivo não existe!");
            } catch (IOException ex)
            {
                Console.WriteLine("Erro na leitura: " + ex.Message);
            }
        }
        public static void LerLinhas(string arquivo)
        {
            try
            {
                if (ChecarArquivo(arquivo))
                {
                    string[] linhas = File.ReadAllLines(arquivo);
                    foreach (string linha in linhas)
                    {
                        Console.WriteLine(linha);
                    }
                }
                else Console.WriteLine("Arquivo não existe!");
            } catch (IOException ex)
            {
                Console.WriteLine("Erro ao ler linhas: " + ex.Message);
            }
        }
        public static void ApagarArquivo(string arquivo)
        {
            ChecarArquivo(arquivo);

        }
        static void Main(String[] args)
        {
            string caminhoDoArquivo = @"C:\Users\felip\Documents\meudocumento.txt";
            EscreverFrase(caminhoDoArquivo);

            LerFrase(caminhoDoArquivo);

            LerLinhas(caminhoDoArquivo);
        }
    }
}