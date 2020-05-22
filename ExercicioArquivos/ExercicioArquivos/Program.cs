using ExercicioArquivos.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caminho do arquivo csv de origem
            Console.WriteLine("Enter file full path:");
            string sourceFilePath = Console.ReadLine();

            try
            {
                //Lendo os dados do arquivo csv origem e guardando no vetor:
                string[] lines = File.ReadAllLines(sourceFilePath);

                //Pegando caminho da pasta de origem que guarda o csv origem
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                //Concatenando caminho pasta de origem com a pasta que vou criar
                //para guardar na variável de caminho de pasta de destino
                string targetFolderPath = sourceFolderPath + @"\out";

                //Concatenando caminho pasta de destino com o arquivo csv destino
                //para guardar na variável de caminho do arquivo de destino
                string targetFilePath = targetFolderPath + @"\summary.csv";

                //Criando a pasta de destino
                Directory.CreateDirectory(targetFolderPath);

                //Objeto StreamWriter criado para escrever no arquivo de destino
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    //Pecorrendo array lines
                    foreach (string line in lines)
                    {
                        //Guardando cada line, separada por virgula, do array lines no array fields
                        string[] fields = line.Split(',');

                        //Atribuindo cada elemento do array fields para variáveis:
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        //Instanciando um produto
                        Product prod = new Product(name, price, quantity);

                        //Usando o objeto StreamWriter que está associado ao arquivo de destino
                        //Escrevendo no arquivo de destino o Nome e o total do produto:
                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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
