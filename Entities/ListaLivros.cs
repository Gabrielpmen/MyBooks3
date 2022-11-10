using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioLivros.Entities
{
    public class ListaLivros
    {

        List<CadastroLivro> listaLivros = new List<CadastroLivro>();

        public ListaLivros()
        {
            
        }

         public void AdicionaLivro(CadastroLivro cadastro)
        {
           

            
            listaLivros.Add(cadastro);



        }
    }
}
