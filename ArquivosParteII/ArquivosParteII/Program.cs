using System;
using System.IO;

namespace ArquivosParteII
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\projetos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                /*Instanciação do FileStream = usar o construtor que pede o caminho do arquivo e o modo
                de instanciação (escrita no arquivo, leitura do mesmo...)*/

                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);

                //Instanciação mais rápida!!:
                sr = File.OpenText(path);

                /*Como acima posso instanciar um Stream Reader através no File.
                 A propriedade OpenText já instancia um FileStream e converte para StreamReader*/

                //Lendo apenas uma linha do arquivo:

                //LENDO VARIAS LINHAS DO STREAM:

                while (!sr.EndOfStream)
                {
                    //Acima lê-se: enquanto eu nao chegar no final da stream
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An Error acurred: " + e.Message);
            }
            finally
            {
                //Fechando manualmente as streams:
                if (sr != null) sr.Close();

                //if (fs != null) fs.Close();
            }
        }
    }
}
