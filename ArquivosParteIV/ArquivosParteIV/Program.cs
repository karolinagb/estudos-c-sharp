using System;
using System.IO;

namespace ArquivosParteIV
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\projetos\file1.txt";
            string targetPath = @"c:\projetos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //O AppendText abre o arquivo para escrita no final do mesmo
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        /*Cada linha do vetor lines (que recebeu o sourcePath vai ser escrita dentro
                         do targetPath em maiusculo (ToUpper). Depois o arquivo será aberto para eu escrever algo no final*/
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
