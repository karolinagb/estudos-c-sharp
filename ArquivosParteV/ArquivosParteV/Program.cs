using System;
using System.IO;
using System.Collections.Generic;

namespace ArquivosParteV
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";

            try
            {
                //Listar subpastas a partir de uma pasta:
                //Parâmetro: arquivo base + máscara de busca + opção de busca
                // *.*  =  qualquer arquivo ponto qualquer extensão
                //SearchOption = tipo enumerado (todos os diretorios ou apenas diretorio atual)
               
                IEnumerable <string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                //O resultado acima será uma coleção contendo os string das pastas
                //Essa coleção será do tipo IEnumerable que é um tipo mais genéricos de coleção

                //LISTAR todos os arquivos a partir de uma pasta

                Console.WriteLine();

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string folder in files)
                {
                    Console.WriteLine(folder);
                }

                //Criar uma pasta:
                //path + "newfolder" = aproveita o caminho do path e concatena com a pasta que eu quero criar:
                //Tem que colocar o @ na frente do string ou duas contra barras

                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
