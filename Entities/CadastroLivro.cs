﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RepositorioLivros;
using Newtonsoft.Json;


namespace RepositorioLivros.Entities
{
    public class CadastroLivro
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Midia { get; set; }
        public string AnoLancamento { get; set; }

        public string StatusLeitura { get; set; }
        public string AnoCompra { get; set; }

        public double ValorPago { get; set; }
        public string Autor { get; set; }
        public string Esaga { get; set; }
        public static string path { get; private set; }





        public CadastroLivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, double valorPago, string autor, string esaga)
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
            
        }

        public CadastroLivro()
        {
        }

        public string JsonSerializar ( CadastroLivro cadastrolivro)
        {
            return JsonConvert.SerializeObject(cadastrolivro);
        }
        public static CadastroLivro Jsondesserializar(string Json)
        {
            return JsonConvert.DeserializeObject<CadastroLivro>(Json);
        }




        static public void cadastraolivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, string valorPago, string autor, string esaga)
        {


            //File.AppendAllText(@"C:\\Users\\gabriel.mendonca\\Desktop\\arq01.txt", titulo + "," + genero + "," + midia + "," + anoLancamento + "," + statusLeitura + "," + anoCompra + "," + valorPago + "," + autor + "," + esaga + Environment.NewLine);

            StreamWriter sw = new StreamWriter("C:\\Users\\gabriel.mendonca\\Desktop\\arq01.txt", true, Encoding.ASCII);



            sw.WriteLine(titulo + "," + genero + "," + midia + "," + anoLancamento + "," + statusLeitura + "," + anoCompra + "," + valorPago + "," + autor + "," + esaga);

            sw.Close();

            



        }
        static public void AdicionaLivro(string titulo, string genero, string midia, string anoLancamento, string statusLeitura, string anoCompra, string valorPago, string autor, string esaga)
        {
            List<string> listaLivros = new List<string>();


            listaLivros.Add(titulo + genero + midia + anoLancamento + statusLeitura + anoCompra + valorPago + autor);

       

        }

        


    }
    }



