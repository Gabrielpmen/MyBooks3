using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioLivros.Entities
{
    internal class LivroDigital : CadastroLivro
    {
        public LivroDigital(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, double valorPago, string autor, string esaga) : base(titulo, genero, midia, anoLancamento, statusLeitura, anoCompra, valorPago, autor, esaga)
        {
        }
    }
}
