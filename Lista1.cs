using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    internal class Lista1
    {
        public static void escolherExercicio()
        {
            string escolha;
            do
            {
                Console.WriteLine("Digite o número do exercício");
                escolha = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Exercicio " +  escolha + "\n");
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
            Console.WriteLine("Digite a largura da parede (em metros): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da parede (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = largura * altura;

            double quantidadeTinta = area / 2;

            Console.WriteLine($"A área a ser pintada é de {area} m².");
            Console.WriteLine($"A quantidade de tinta necessária  é de {quantidadeTinta} litros.");
        }

        private static void exercicio9()
        {
            const double taxaConversao = 3.45;
            Console.WriteLine("Digite quanto dinheiro você tem na sua carteira (em R$): ");

            double reais = Convert.ToDouble(Console.ReadLine());
            double dolares = reais / taxaConversao;

            Console.WriteLine($"Com R$ {reais:F2} reais, você pode comprar US$ {dolares:F2}.");

        }

        private static void exercicio8()
        {
            Console.WriteLine("Digite uma distância em metros: ");
            double metros = Convert.ToDouble(Console.ReadLine());

            double quilometros = metros / 1000;
            double centimetros = metros * 100;
            double milimetros = metros * 1000;

            Console.WriteLine($"Distância em metros: {metros} m");
            Console.WriteLine($"Distância em quilometros: {quilometros} km");
            Console.WriteLine($"Distância em centimetros: {centimetros} cm");
            Console.WriteLine($"Distância em milimetros: {milimetros} mm");
        }

        private static void exercicio7()
        {
            Console.WriteLine("Digite um número real: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double dobro = numero * 2;
            double terçaParte = numero / 3;

            Console.WriteLine($"O dobro do {numero} é {dobro}");
            Console.WriteLine($"A terça parte de {numero} é {terçaParte}.");
        }

        private static void exercicio6()
        {

            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out int numero))
            {
                int antecessor = numero - 1;
                Console.WriteLine($"O número digitado é: {numero}");
                Console.WriteLine($"O número antecessor é: {antecessor}");
            }
            else
            { Console.WriteLine("Digite um número válido"); }

        }

        private static void exercicio5()
        {
            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            double media = (n1 + n2) / 2;
            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
            string valorFormatado = media.ToString("N2", culturaBrasileira);
            Console.WriteLine($" A média entre {n1} e {n2} é igual a {valorFormatado} " );
        }

        private static void exercicio4()
        {
            Console.Write("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A somatória dos números é: " + (n1 + n2));

        }

        private static void exercicio3()
        {

            Console.Write("Qual o nome do funcionário:");
            string nome = Console.ReadLine();
            Console.Write("Sálario:");
            double valor = double.Parse(Console.ReadLine());
            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
            string valorFormatado = valor.ToString("C2", culturaBrasileira);
            Console.WriteLine("O funcionário " + nome  + " tem um salário de " + valorFormatado);
        }

        private static void exercicio2()
        {
            
            Console.WriteLine("Qual seu Nome?");
            string name = Console.ReadLine();
            Console.WriteLine("Seja bem-vindo(a), " + name);
        }

        public static void exercicio1()
        {
            Console.WriteLine("Olá Mundo!");
        }
            
    }
}

