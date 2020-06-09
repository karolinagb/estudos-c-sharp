using System;
using System.Collections.Generic;
using System.IO;

namespace ExercicioPropostoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> eleicoes = new Dictionary<string, int>();

            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();

            try
            {
                //Abrindo o arquivo
                using (StreamReader sr = File.OpenText(path))
                {
                    //enquanto nao chegar no final do arquivo
                    while (!sr.EndOfStream)
                    {
                        //ReadLine = lê a linha
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votos = int.Parse(line[1]);

                        /*Se a minha chave já existir, o programa vai somar a chave existente mais votos (além do que já se tem)
                         Isso é necessário para que o programa não sobrescreva os valores das chaves existentes*/
                        if (eleicoes.ContainsKey(name))
                        {
                            //somando os votos com o anterior
                            eleicoes[name] += votos;
                        }
                        else
                        {
                            //eleicoes.Add(name, votos);
                            //sintaxe alternativa:
                            eleicoes[name] = votos;
                        }
                    }
                    foreach(var item in eleicoes)
                    {
                        Console.WriteLine(item.Key + ", votos: " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
