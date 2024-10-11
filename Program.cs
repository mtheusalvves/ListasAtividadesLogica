using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            string escolha;
            do
            {
             
                Console.WriteLine("Digite o número da lista (0 para sair) ");


                
                escolha = Console.ReadLine();

    

                switch (escolha)

                {
                    

                    case "1":
                        Console.WriteLine("-------------Lista 1-------------");
                        Lista1.escolherExercicio();
                        break;

                    case "2":
                        Console.WriteLine("-------------Lista 2-------------");
                        Lista2.escolherExercicio();
                        break;

                    case "3":
                        Console.WriteLine("-------------Lista 3-------------");
                        Lista3.escolherExercicio();
                        break;

                    case "4":
                        Console.WriteLine("-------------Lista 4-------------");
                        Lista4.escolherExercicio();
                        break;
                }
            } while (escolha != "0");
        }
    }
}
