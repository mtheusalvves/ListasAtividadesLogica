using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    internal class Lista4
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
                }

                Console.ReadKey();
                Console.Clear();


            } while (escolha != ("0"));
        }

        private static void exercicio10()
        {
            throw new NotImplementedException();
        }

        private static void exercicio9()
        {
            throw new NotImplementedException();
        }

        private static void exercicio8()
        {
            throw new NotImplementedException();
        }

        private static void exercicio7()
        {
            Console.Write("Digite o valor da comprar: R$");
            string valorInput = Console.ReadLine();

            if(decimal .TryParse(valorInput,out decimal valorCompra))
            {
                if(valorCompra > 100)
                {
                    decimal  desconto = valorCompra * 0.10m;
                    valorCompra -= desconto;
                    Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
                }

                Console.WriteLine($"Valor final da compra: R$ {valorCompra:F2}");
            }
        }

        private static void exercicio6()
        {
            Console.Write("Digite sua idade: ");
            string idadeInput = Console.ReadLine();

            if(int .TryParse(idadeInput, out int idade))
            {
                if(idade < 16)
                {
                    Console.WriteLine("Você não pode votar.");
                }
                else if (idade >=  16  &&  idade < 18 || idade > 70)
                {
                    Console.WriteLine("Seu voto é facultativo");
                }
                else if (idade >= 18  && idade <= 70)
                {
                    Console.WriteLine("Você é obrigado a votar");
                }
            }
        }

        private static void exercicio5()
        {
            Console.Write("Digite o primeiro número: ");
            string primeiroInput = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            string segundoInput = Console.ReadLine();

            if (int.TryParse(primeiroInput, out int primeiroNumero) && int.TryParse(segundoInput, out int segundoNumero))
            {
                if (primeiroNumero > segundoNumero)
                {
                    Console.WriteLine($"O maior número é: {primeiroNumero}");
                }
                else if (segundoNumero > primeiroNumero)
                {
                    Console.WriteLine($"O maior número é: {segundoNumero}");
                     
                }
                else
                {
                    Console.WriteLine("Os números são iguais.");
                }
            }

        }

        private static void exercicio4()
        {
            Console.Write("Digite seu peso em kg: ");
            string pesoInput = Console.ReadLine();

            Console.Write("Digite sua altura em metros: ");
            string alturaInput = Console.ReadLine();

            if (float.TryParse(pesoInput, out float peso) && float.TryParse(alturaInput, out float altura))
            {
                float imc = peso / (altura * altura);

                string categoria;

                if (imc < 18.5)
                {
                    categoria = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    categoria = "Peso normal";
                }
                else if (imc >= 25 && imc < 29.9)
                {
                    categoria = "Sobrepeso";
                }
                else
                {
                    categoria = "Obesidade";
                }

                Console.WriteLine($"Seu IMC é: {imc:F2} ({categoria})");

            }
        }

        private static void exercicio3()
        {
            Console.Write("Digite uma nota:");
            string nota = Console.ReadLine();

            if(int.TryParse(nota, out int numero))

            if(numero >= 6)
            {
                    Console.WriteLine("Aprovado!");
            }
            else if(numero >= 4 && numero <= 5.9)
            {
                    Console.WriteLine("Recuperação");
            }
            else if(numero < 4)
            {
                    Console.WriteLine("Reprovado..");
            }
        }

        private static void exercicio2()
        {
            Console.Write("Digite sua idade: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int idade)) ;

            if(idade >= 0 && idade <= 12)
            {
                Console.WriteLine("Você é uma criança.");
            }
            else if (idade >= 13  && idade <= 17)
            {
                Console.WriteLine("Você é um adolescente.");
            }
            else if (idade >= 18 && idade <= 64)
            {
                Console.WriteLine("Você é um adulto");
            }
            else if (idade >= 65)
            {
                Console.WriteLine("Você é um idoso");
            }
        }

        private static void exercicio1()
        {
            Console.Write("Digite um número: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é um número par.");
                }
                else
                {
                    Console.WriteLine($"{numero} é um número ímpar.");
                }
            }
        }
    }
}
