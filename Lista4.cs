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
                        // 1. Verificação de Número Par ou Ímpar:
                        // Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar.
                        exercicio1();
                        break;

                    case "2":
                        // 2. Classificação de Idade:
                        // Peça ao usuário para inserir sua idade e classifique-o como "Criança" (0-12), "Adolescente" (13-17), "Adulto" (18-64), ou "Idoso" (65+).
                        exercicio2();
                        break;

                    case "3":
                        // 3. Verificação de Notas:
                        // Crie um programa que receba uma nota (0 a 10) e exiba se o aluno foi "Aprovado" (nota maior ou igual a 6), "Recuperação" (nota entre 4 e 5.9) ou "Reprovado" (nota menor que 4).
                        exercicio3();
                        break;

                    case "4":
                        // 4. Cálculo de IMC:
                        // Peça ao usuário para informar seu peso e altura e, em seguida, calcule o Índice de Massa Corporal (IMC) e determine sua categoria: "Abaixo do peso", "Peso normal", "Sobrepeso" ou "Obesidade".
                        exercicio4();
                        break;

                    case "5":
                        // 5. Maior de Dois Números:
                        // Escreva um programa que receba dois números do usuário e exiba qual é o maior, ou informe se os números são iguais.
                        exercicio5();
                        break;

                    case "6":
                        // 6. Verificação de Voto:
                        // Peça ao usuário sua idade e informe se ele é obrigado a votar (18-70 anos), voto facultativo (16-17 ou acima de 70), ou se não pode votar (abaixo de 16 anos).
                        exercicio6();
                        break;

                    case "7":
                        // 7. Cálculo de Desconto:
                        // Crie um programa que receba o valor de uma compra e aplique um desconto de 10% caso o valor seja superior a R$100.
                        exercicio7();
                        break;

                    case "8":
                        // 8. Classificação de Temperatura:
                        // Peça ao usuário para informar a temperatura em graus Celsius e classifique se está "Frio" (abaixo de 15°C), "Agradável" (15-25°C), ou "Quente" (acima de 25°C).
                        exercicio8();
                        break;

                    case "9":
                        // 9. Cálculo de Média de Três Números:
                        // Solicite três números ao usuário e calcule a média. 
                        // Caso a média seja maior que 7, exiba "Aprovado", senão exiba "Reprovado".
                        exercicio9();
                        break;

                    case "10":
                        // 10. Verificação de Ano Bissexto:
                        // Peça ao usuário que insira um ano e verifique se ele é bissexto (divisível por 4 e não divisível por 100, exceto se for divisível por 400).
                        exercicio10();
                        break;
                }

                Console.ReadKey();
                Console.Clear();


            } while (escolha != ("0"));
        }

        private static void exercicio10()
        {
            Console.Write("Informe um ano: ");

            if (int.TryParse(Console.ReadLine(), out int ano))
            {
                bool bissexto = (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);

                Console.WriteLine(bissexto ? "O ano é bissexto." : "O ano não é bissexto.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }

        private static void exercicio9()
        {
            Console.WriteLine("Informe três números:");

            Console.Write("Número 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            double num3 = double.Parse(Console.ReadLine());

            double media = (num1 + num2 + num3) / 3;

            string resultado = media > 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"Média: {media:F2} - {resultado}");
        }

        private static void exercicio8()
        {
            Console.Write("Informe a temperatura em graus Celsius: ");

            if (double.TryParse(Console.ReadLine(), out double temperatura))
            {
                string classificacao = temperatura < 15 ? "Frio" :
                                       temperatura <= 25 ? "Agradável" : "Quente";

                Console.WriteLine($"A temperatura está: {classificacao}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
            }
        }

        private static void exercicio7()
        {
            Console.Write("Digite o valor da comprar: R$");
            string valorInput = Console.ReadLine();

            if (decimal.TryParse(valorInput, out decimal valorCompra))
            {
                if (valorCompra > 100)
                {
                    decimal desconto = valorCompra * 0.10m;
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

            if (int.TryParse(idadeInput, out int idade))
            {
                if (idade < 16)
                {
                    Console.WriteLine("Você não pode votar.");
                }
                else if (idade >= 16 && idade < 18 || idade > 70)
                {
                    Console.WriteLine("Seu voto é facultativo");
                }
                else if (idade >= 18 && idade <= 70)
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

            if (int.TryParse(nota, out int numero))

                if (numero >= 6)
                {
                    Console.WriteLine("Aprovado!");
                }
                else if (numero >= 4 && numero <= 5.9)
                {
                    Console.WriteLine("Recuperação");
                }
                else if (numero < 4)
                {
                    Console.WriteLine("Reprovado..");
                }
        }

        private static void exercicio2()
        {
            Console.Write("Digite sua idade: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int idade))

                if (idade >= 0 && idade <= 12)
                {
                    Console.WriteLine("Você é uma criança.");
                }
                else if (idade >= 13 && idade <= 17)
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
