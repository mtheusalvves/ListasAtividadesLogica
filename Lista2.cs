using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    internal class Lista2
    {
        public static void escolherExercicio()

        {
            string escolha;
            do
            {
                Console.WriteLine("Digite o número do exercício");
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
                    case "7":

                        exercicio7();
                        break;
                    case "8":

                        exercicio8();
                        break;
                    case "9":

                        exercicio9();
                        break;
                    case "10":

                        exercicio10();
                        break;
                    case "11":
                        exercicio11();
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (escolha != ("0"));
        }

        private static void exercicio11()
        {
            throw new NotImplementedException();
        }

        private static void exercicio10()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            int c = int.Parse(Console.ReadLine());

            // Ordena os valores
            int menor, meio, maior;

            if (a <= b && a <= c)
            {
                menor = a;
                if (b <= c)
                {
                    meio = b;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = b;
                }
            }
            else if (b <= a && b <= c)
            {
                menor = b;
                if (a <= c)
                {
                    meio = a;
                    maior = c;
                }
                else
                {
                    meio = c;
                    maior = a;
                }
            }
            else
            {
                menor = c;
                if (a <= b)
                {
                    meio = a;
                    maior = b;
                }
                else
                {
                    meio = b;
                    maior = a;
                }
            }

            
            Console.WriteLine("Valores em ordem crescente: " + menor + ", " + meio + ", " + maior);
        }
    


        private static void exercicio9()
        {
            Console.Write("Digite o primeiro valor: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int C = int.Parse(Console.ReadLine());

            int maior, meio, menor;

            if (A >= B && A >= C)
            {
                maior = A;
                if (B >= C)
                {
                    meio = B;
                    menor = C;

                }
                else
                {
                    meio = C;
                    menor = B;
                }
            }
            else if (B >= A && B >= C)
            {
                maior = B;
                if (A >= C)
                {
                    meio = A;
                    menor = C;
                }
                else
                {
                    meio = C;
                    menor = A;
                }
            }
            else
            {
                maior = C;
                if (A >= B)
                {
                    meio = A;
                    menor = B;
                }
                else
                {
                    meio = B;
                    menor = A;
                }
                Console.WriteLine("Valores em ordem decrescente: " + maior + "," + meio + "," + menor);
            }



        }


        private static void exercicio8()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int resultado;

            if (numero > 0)
            {
                resultado = numero * 2;
            }
            else
            {
                resultado = numero * 3;
            }
            Console.Write("O resultado é: " + resultado);
        }

        private static void exercicio7()
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            int C;

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }
            Console.WriteLine("O resultado é: " + C);
        }

        private static void exercicio6()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número não é par.");
            }
        }

        private static void exercicio5()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sexo (M/F): ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Digite seu estado civil: ");
            string estadoCivil = Console.ReadLine().ToUpper();

            if (nome == "F" && estadoCivil == "Casada")
            {
                Console.WriteLine("Digite o tempo de casada (em anos): ");
                int anosCasada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}, Tempo de casada {anosCasada} anos");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}, Sexo: {sexo}, Estado Civil: {estadoCivil}");
            }
        }

        private static void exercicio4()
        {
            Console.Write("Digite o primeiro valor inteiro: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int soma = valor1 + valor2;

            if (soma > 10)
            {
                Console.WriteLine($"A soma é: {soma}");
            }
            else
            {
                Console.WriteLine($"A soma é menor ou igual a 10.");
            }
        }

        private static void exercicio3()
        {
            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma A e B NÃO é menor que C.");
            }
        }

        private static void exercicio2()
        {
            Console.WriteLine("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor > 10)
            {
                Console.WriteLine("É MAIOR QUE 10");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10");
            }
        }

        private static void exercicio1()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 20)
            {
                Console.Write($"O número {numero} é maior que 20");

            }
            else
            {

                Console.Write($"O número não é maior que 20");

            }
        }
    }
}



    

