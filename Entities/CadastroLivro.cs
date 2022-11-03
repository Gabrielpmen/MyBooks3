using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RepositorioLivros;

namespace RepositorioLivros.Entities
{
    public class CadastroLivro
    {
        public string Titulo { get; set; }    
        public string Genero { get; set;}   
        public string Midia { get; set; }
        public DateTime AnoLancamento { get; set; }

        public string StatusLeitura { get; set; }
        public DateTime AnoCompra { get; set; } 

        public double ValorPago { get; set; }
        public string Autor { get; set; }
        public bool Esaga { get; set; }
        public static string path { get; private set; }

         






        public CadastroLivro(string titulo, string genero, string midia, DateTime anoLancamento, string statusLeitura, DateTime anoCompra, double valorPago, string autor, bool esaga, string path)
        {
            Titulo = titulo;
            Genero = genero;
            Midia = midia;
            AnoLancamento = anoLancamento;
            StatusLeitura = statusLeitura;
            AnoCompra = anoCompra;
            ValorPago = valorPago;
            Autor = autor;
            Esaga = esaga;
            CadastroLivro.path = path;
        }

        

       

        static public void  cadastraolivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, string valorPago, string autor, string esaga)
        {
            
            
            //File.AppendAllText(@"C:\\Users\\gabriel.mendonca\\Desktop\\arq01.txt", titulo + "," + genero + "," + midia + "," + anoLancamento + "," + statusLeitura + "," + anoCompra + "," + valorPago + "," + autor + "," + esaga + Environment.NewLine);

            StreamWriter sw = new StreamWriter("C:\\Users\\gabriel.mendonca\\Desktop\\arq01.txt", true, Encoding.ASCII);

            

            sw.WriteLine(titulo + "," + genero + "," + midia + "," + anoLancamento + "," + statusLeitura + "," + anoCompra + "," + valorPago + "," + autor + "," + esaga);

            sw.Close();
        }


        
    }
}
