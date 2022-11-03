using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioLivros.Entities
{
    internal class LivroDigital : CadastroLivro
    {
        public LivroDigital(string titulo, string genero, string midia, DateTime anoLancamento, string statusLeitura, DateTime anoCompra, double valorPago, string autor, bool esaga) : base(titulo, genero, midia, anoLancamento, statusLeitura, anoCompra, valorPago, autor, esaga, path)
        {
        }
    }
}
