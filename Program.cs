
using System.IO;


namespace RepositorioLivros
{
    public static class Program
    {
      
        [STAThread]
        public static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new MyBook());

            StreamWriter x;

            string CaminhoNome = "C:\\Users\\gabriel.mendonca\\Desktop\\arq01.txt";

            x = File.CreateText(CaminhoNome);

        }
    }
}