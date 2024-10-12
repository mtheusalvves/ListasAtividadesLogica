using System;
using System.Collections.Generic;
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
            Console.Write("Digite a hora de inicio do jogo (0 a 23): ");
            int horaInicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a hora do fim do jogo (0 a 23): ");
            int horaFim = Convert.ToInt32(Console.ReadLine());

            int duracao;
            if(horaFim >= horaInicio) 
            {
                duracao = horaFim - horaInicio;
            }
            else 
            {
                duracao = (24 - horaInicio) + horaFim;
            }

            int horasMaxima = 24;
            int horasRestantes = horasMaxima - duracao;

            Console.WriteLine($"Duração do jogo:  {duracao} horas");

            if(horasRestantes > 0)
            {
                Console.WriteLine($"Horas restantes: {horasRestantes} horas");
            }
            else if (horasRestantes < 0)
            {
                Console.WriteLine($"Horas excedentes: {-horasRestantes} horas");        
            }
            else
            {
                Console.WriteLine(" O jogo durou exatamente 24 horas. ");
            }
        }

        private static void exercicio10()
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3 };

            Array.Reverse(valores);
            Array.Sort(valores);
            

            Console.WriteLine("Valores do menor para o maior: ");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }

        private static void exercicio9()
        {
            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            int[] valores = { valor1, valor2, valor3 };

            Array.Sort(valores);
            Array.Reverse(valores);

            Console.WriteLine("Valores do maior para o menor: ");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }
        }

        private static void exercicio8()
        {
            Console.Write("Digite um número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 0)
            {
                double dobro = numero * 2;
                Console.WriteLine("O dobro do número é: " + dobro);
            }
            else if(numero<0) 
            {
                double triplo = numero * 3;
                Console.WriteLine("O triplo do número é: " + triplo);
            }
            else {
                Console.WriteLine("O número é zero."); }
        }

        private static void exercicio7()
        {
            Console.Write("Digite o valor de A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            if(A == B)
            {
                int soma = A + B;
                Console.WriteLine("Os valores são iguais. A soma é: "+ soma);
            }
            else 
            {
                int multiplicacao = A * B;
                Console.WriteLine("Os valores são diferentes. A multiplicação é: " + multiplicacao);
            }
        }

        private static void exercicio6()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine($"O número  é par. ");
            }
            else 
            {
                Console.WriteLine($"O número é impar. ");
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

            if (A+B<C)
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
            Console.Write("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (valor >= 10)
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
