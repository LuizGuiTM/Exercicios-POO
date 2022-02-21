using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
/*
2.	Utilizando a classe jogo criada no exercício anterior, faça um programa que instancie 10 jogos.Após efetuar os cadastros, exiba os dados em vídeo.Encapsule os atributos. Validações:


Código -  (int)  ( > 0)
Nome  - (string) (obrigatório)
Categoria – (string) (válido apenas “ação”  “luta” “tiro” e “Esportes” )
Data de lançamento -  (DateTime) (deve ser  inferior à data atual)
*/
     class Program
    {
        static void Main(string[] args)
        {
            Jogo[] Jogos = new Jogo[10];
            
            
            
            for(int n = 0; n < Jogos.Length; n++)   
            {
                try
                {
                    do
                    {
                        Jogos[n] = new Jogo();
                        try
                        {
                            Console.WriteLine("Digite o código");
                            Jogos[n].setCodigo(Convert.ToInt32(Console.ReadLine()), n);
                            break;
                        }
                        catch (Exception erro)
                        {
                            Console.WriteLine("Erro encontrado: " + erro.Message);
                        }
                    } while (1 == 1);



                    Console.WriteLine("Digite o Nome");
                    Jogos[n].setNome(Console.ReadLine(), n);

                    Console.WriteLine("Digite a Categoria");
                    Jogos[n].setCategoria(Console.ReadLine(), n);

                    Console.WriteLine("Digite a Data de lançamento");
                    Jogos[n].setData(Convert.ToDateTime(Console.ReadLine()), n);

                    
              


                }
                catch (Exception erro)
                {
                    Console.WriteLine("Erro encontrado:" + erro.Message);
                }

            } 

            for (int i = 0; i < Jogos.Length; i++)
            {
                
                if (Jogos[i].GetNome() != null)
                {
                    Console.WriteLine("\n\nDados do jogo: \n");
                    Console.WriteLine($"Codigo: {Jogos[i].GetCodigo()}");
                    Console.WriteLine($"Nome: {Jogos[i].GetNome()}");
                    Console.WriteLine($"Data de lançamento: {Jogos[i].GetData().ToString("dd/MM/yyyy")}");
                    Console.WriteLine($"Categoria: {Jogos[i].GetCategoria()}");
                }
            }
         

            Console.ReadLine();
        }

        
    }
}
