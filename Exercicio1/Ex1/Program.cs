using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program

/*
1.	Crie uma classe chamada Jogo com seguintes atributos:
•	Código -  (int)
•	Nome  - (string)
•	Categoria – (string)
•	Data de lançamento -  (DateTime)

Instancie um objeto da classe Jogo, preencha os seus atributos e exiba em vídeo os dados.
*/
        class Jogo
        {
           public int Codigo;
           public string Nome;
           public string Categoria;
           public DateTime DataLancamento;
        }
        static void Main(string[] args)
        {
            Jogo Game = new Jogo();
            
            Game.Codigo = 01;

           
            Game.Nome ="FIFA 22";

           
            Game.Categoria = "Esportes";

            
            Game.DataLancamento = Convert.ToDateTime("23/02/2022");

            Console.WriteLine("Você cadastrou o Jogo:  ");
            Console.WriteLine($"Código: {Game.Codigo}");
            Console.WriteLine($"Nome: {Game.Nome}");
            Console.WriteLine($"Categoria: {Game.Categoria} ");
            Console.WriteLine($"Data de Lançamento: {Game.DataLancamento}");

            Console.ReadLine();
        }
    }
}
