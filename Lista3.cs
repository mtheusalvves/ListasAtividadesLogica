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
                        // 1. Faça um programa que receba 3 valores e retorne a soma deles.
                        exercicio1();
                        break;

                    case "2":
                        // 2. Faça um programa que receba quatro notas e retorne a média.
                        exercicio2();
                        break;

                    case "3":
                        // 3. Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome.
                        exercicio3();
                        break;

                    case "4":
                        // 4. Faça um programa que retorne a quantidade de números pares existente entre 35 e 98111.
                        exercicio4();
                        break;

                    case "5":
                        // 5. Faça um programa que some todos os números ímpares de 1 até 5000.
                        exercicio5();
                        break;

                    case "6":
                        // 6. Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.
                        exercicio6();
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (escolha != ("0"));




        
    }

        private static void exercicio6()
        {
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Tabuada de {numero}: ");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }

        private static void exercicio5()
        {
            int soma = 0;

            
            for (int i = 1; i <= 5000; i++)
            {
                
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }
            Console.WriteLine("A soma dos números ímpares de 1 até 5000 é:" + soma);
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
