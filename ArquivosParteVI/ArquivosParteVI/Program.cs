using System;
using System.IO;

namespace ArquivosParteVI
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            //GetDirectoryName = pega a porção do string correspondente a pasta:

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            //DirectorySeparatorChar = caracter separador 
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            //PathSeparator = separador de pastas
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            //GetFileName = Pega o nome do arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            //GetFileNameWithoutExtension = Nome do arquivo sem extensão:
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            //GetExtension = Pega apenas a extensão do arquivo:
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));

            //GetFullPath = pega todo o caminho do arquivo:
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            //GetTempPath = Pasta temporária do sistema:
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
