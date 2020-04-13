/*Referência para o namespace chamado System. Esse namespace é padrão
 do .net e contém configurações basicas de manipulação de programas.*/
using System;

/*Declaração de namespace desse arquivo. O name espace é
 um agrupamento de classes relacionadas.*/
namespace Primeiro
{
    /*Declaração da classe. Todo código C# tem que estar dentro de uma classe.*/
    class Program
    {
        /*O comando abaixo é um membro da classe.
         Declaração padrão do C# para identificar onde a execução começa.*/
        static void Main(string[] args)
        {
            /*O comando abaixo pertence ao namespace System*/
            Console.WriteLine("Olá Mundo!");
        }
    }
}
