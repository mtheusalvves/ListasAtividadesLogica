using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    internal class Lista3
    {
       public static void escolherExercicio()
    {
            string escolha;
            do
            {
                Console.Write("Digite o número do exercício: ");
                escolha = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Exercicio " + escolha + "\n");
                switch (escolha)
                {

                    case "1":
                        
                        exercicio1();
                        break;

                    case "2":
                        
                        exercicio2();
                        break;
                    case "3":
                        
                        exercicio3();
                        break;
                    case "4":
                        
                        exercicio4();
                        break;
                    case "5":
                        
                        exercicio5();
                        break;
                    case "6":
                       
                        exercicio6();
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (escolha != ("0"));




        
    }

        private static void exercicio6()
        {
            throw new NotImplementedException();
        }

        private static void exercicio5()
        {
            throw new NotImplementedException();
        }

        private static void exercicio4()
        {
            int contadorPares = 0;

            for (int i = 35;i <=98111; i++)
            {

             if (i % 2 == 0)
            { 
                    contadorPares++;
            }
                
            }
            Console.WriteLine($"A quantidade de números pares entre 35 e 98111 é: {contadorPares}");

            }
        private static void exercicio3()
        {
            string nome;

            do
            {
                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();
            }while (nome != ("João"));

            Console.WriteLine("Você digitou o nome João");
        }

        private static void exercicio2()
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;    

            Console.WriteLine($"A média das notas é: {media:F2}");

        }

        private static void exercicio1()
        {
            double valor1, valor2, valor3, soma;

            Console.Write("Digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            valor3 = Convert.ToDouble(Console.ReadLine());

            soma = valor1 + valor2 + valor3;

            Console.WriteLine("A soma dos valores é: " + soma);

        }
    }
}
