using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RepositorioLivros.Entities;
using System;

namespace RepositorioLivros.Services
{
    public class LivroService
    {
        // Define um caminho padrão para o arquivo de dados.
        // O arquivo "livros.json" será salvo no mesmo diretório do executável.
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "livros.json");

        /// <summary>
        /// Carrega a lista de livros a partir do arquivo JSON.
        /// </summary>
        /// <returns>Uma lista de objetos CadastroLivro.</returns>
        public List<CadastroLivro> CarregarLivros()
        {
            // Se o arquivo não existir, retorna uma lista nova e vazia.
            if (!File.Exists(FilePath))
            {
                return new List<CadastroLivro>();
            }

            // Lê todo o conteúdo do arquivo.
            string json = File.ReadAllText(FilePath);

            // Se o arquivo estiver vazio, retorna uma lista vazia para evitar erros.
            if (string.IsNullOrEmpty(json))
            {
                return new List<CadastroLivro>();
            }

            // Deserializa a string JSON para uma lista de livros.
            var livros = JsonConvert.DeserializeObject<List<CadastroLivro>>(json) ?? new List<CadastroLivro>();

            return livros;
        }

        /// <summary>
        /// Salva a lista inteira de livros no arquivo JSON, sobrescrevendo o conteúdo anterior.
        /// </summary>
        /// <param name="livros">A lista de livros a ser salva.</param>
        public void SalvarLivros(List<CadastroLivro> livros)
        {
            // Serializa a lista para uma string JSON formatada.
            string json = JsonConvert.SerializeObject(livros, Formatting.Indented);

            // Escreve a string no arquivo.
            File.WriteAllText(FilePath, json);
        }
    }
}