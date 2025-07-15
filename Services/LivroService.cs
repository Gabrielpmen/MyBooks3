using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RepositorioLivros.Entities;

namespace RepositorioLivros.Services
{
    public class LivroService
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "livros.json");

        public List<CadastroLivro> CarregarLivros()
        {
            if (!File.Exists(FilePath) || string.IsNullOrEmpty(File.ReadAllText(FilePath)))
            {
                return new List<CadastroLivro>();
            }
            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<CadastroLivro>>(json) ?? new List<CadastroLivro>();
        }

        public void SalvarLivros(List<CadastroLivro> livros)
        {
            string json = JsonConvert.SerializeObject(livros, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public void ExcluirLivro(Guid idDoLivro)
        {
            List<CadastroLivro> livros = CarregarLivros();
            var livroParaRemover = livros.FirstOrDefault(livro => livro.Id == idDoLivro);

            if (livroParaRemover != null)
            {
                livros.Remove(livroParaRemover);
                SalvarLivros(livros);
            }
        }

        // --- NOVO MÉTODO PARA ATUALIZAR UM LIVRO ---
        public void AtualizarLivro(CadastroLivro livroAtualizado)
        {
            List<CadastroLivro> livros = CarregarLivros();
            // Encontra o índice do livro antigo na lista usando o ID
            int index = livros.FindIndex(livro => livro.Id == livroAtualizado.Id);

            // Se encontrou o livro (índice é diferente de -1), o substitui
            if (index != -1)
            {
                livros[index] = livroAtualizado;
                SalvarLivros(livros);
            }
        }
    }
}