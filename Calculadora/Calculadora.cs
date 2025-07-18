﻿namespace Calculadora

{
    public class Calculadora
    {

        public static void Main(string[] args)
        {
            var menu = new Menu();
            Console.Clear();
            Console.WriteLine("Calculadora");
            Console.WriteLine("=============================================");
            menu.ExibirMenu();
            var escolha = Console.ReadLine();
            Console.Clear();
            switch (escolha)
            {
                case "1":
                    var soma = new Soma(0, 0, 0);
                    soma.Somar();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "2":
                    var subtracao = new Subtracao(0, 0, 0);
                    subtracao.Subtrair();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "3":
                    var multiplicacao = new Multiplicacao(0, 0, 0);
                    multiplicacao.Multiplicar();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "4":
                    var divisao = new Divisao(0, 0, 0);
                    divisao.Dividir();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "5":
                    var potencia = new Potencia(0, 0, 0);
                    potencia.CalcularPotencia();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "6":
                    var raizQuadrada = new RaizQuadrada(0, 0);
                    raizQuadrada.CalcularRaizQuadrada();
                    Console.WriteLine("Pressione qualquer tecla para continuar voltar ao Menu inicial.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
                case "7":
                    Console.WriteLine("Obrigado por utilizar a Calculadora! Até a próxima.");
                    Console.WriteLine("Pressione qualquer tecla para fechar.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida do menu.");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadLine();
                    Calculadora.Main(args);
                    break;
            }
        }

        private class Menu
        {
            public void ExibirMenu()
            {
                Console.WriteLine("Qual operação deseja realizar?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("7 - Sair");
            }
        }

        private class Soma
        {
            decimal Valor1 { get; set; }
            decimal Valor2 { get; set; }
            decimal Total { get; set; }

            public Soma() { }

            public Soma(decimal valor1, decimal valor2, decimal total)
            {
                Valor1 = valor1;
                Valor2 = valor2;
                Total = total;
            }

            public decimal Somar()
            {
                Console.WriteLine("Você escolheu a operação de Soma.");
                Console.WriteLine("=============================================");

                Valor1 = LeitorValores.LerValor("Digite o primeiro valor:");
                Valor2 = LeitorValores.LerValor("Digite o segundo valor:");

                Total = Valor1 + Valor2;

                Console.WriteLine($"O resultado da soma é: {Total}");
                return Total;
            }
        }

    
        private class Subtracao
        {
            public decimal Valor1 { get; set; }
            public decimal Valor2 { get; set; }
            public decimal Total { get; set; }

            public Subtracao() { }

            public Subtracao(decimal valor1, decimal valor2, decimal total)
            {
                Valor1 = valor1;
                Valor2 = valor2;
                Total = total;
            }

            public decimal Subtrair()
            {
                Console.WriteLine("Você escolheu a operação de Subtração.");
                Console.WriteLine("=============================================");

                Valor1 = LeitorValores.LerValor("Digite o primeiro valor:");
                Valor2 = LeitorValores.LerValor("Digite o segundo valor:");

                Total = Valor1 - Valor2;

                Console.WriteLine($"O resultado da subtração é: {Total.ToString("F2")}");
                return Total;
            }
        }

        private class Multiplicacao
        {
            public decimal Valor1 { get; set; }
            public decimal Valor2 { get; set; }
            public decimal Total { get; set; }

            public Multiplicacao() { }

            public Multiplicacao(decimal valor1, decimal valor2, decimal total)
            {
                Valor1 = valor1;
                Valor2 = valor2;
                Total = total;
            }

            public decimal Multiplicar()
            {
                Console.WriteLine("Você escolheu a operação de Multiplicação.");
                Console.WriteLine("=============================================");

                Valor1 = LeitorValores.LerValor("Digite o primeiro valor:");
                Valor2 = LeitorValores.LerValor("Digite o segundo valor:");

                Total = Valor1 * Valor2;

                Console.WriteLine($"O resultado da multiplicação é: {Total.ToString("F2")}");
                return Total;
            }
        }

        private class Divisao
        {
            public decimal Valor1 { get; set; }
            public decimal Valor2 { get; set; }
            public decimal Total { get; set; }

            public Divisao() { }

            public Divisao(decimal valor1, decimal valor2, decimal total)
            {
                Valor1 = valor1;
                Valor2 = valor2;
                Total = total;
            }

            public decimal Dividir()
            {
                Console.WriteLine("Você escolheu a operação de Divisão.");
                Console.WriteLine("=============================================");

                Valor1 = LeitorValores.LerValor("Digite o primeiro valor:");
                Valor2 = LeitorValores.LerValor("Digite o segundo valor:");

                Total = Valor1 / Valor2;

                Console.WriteLine($"O resultado da divisão é: {Total.ToString("F2")}");
                return Total;
            }

        }

        private class Potencia
        {
            public decimal Base { get; set; }
            public decimal Expoente { get; set; }
            public decimal Resultado { get; set; }

            public Potencia() { }

            public Potencia(decimal valorBase, decimal expoente, decimal resultado)
            {
                Base = valorBase;
                Expoente = expoente;
                Resultado = resultado;
            }

            public decimal CalcularPotencia()
            {
                Console.WriteLine("Você escolheu a operação de Potência.");
                Console.WriteLine("=============================================");

                Base = LeitorValores.LerValor("Digite a base:");
                Expoente = LeitorValores.LerValor("Digite o expoente:");

                Resultado = (decimal)Math.Pow((double)Base, (double)Expoente);

                Console.WriteLine($"O resultado da potência é: {Resultado.ToString("F2")}");
                return Resultado;
            }

        }

        private class RaizQuadrada
        {
            public decimal Valor { get; set; }
            public decimal Resultado { get; set; }

            public RaizQuadrada() { }

            public RaizQuadrada(decimal valor, decimal resultado)
            {
                Valor = valor;
                Resultado = resultado;
            }

            public decimal CalcularRaizQuadrada()
            {
                Console.WriteLine("Você escolheu a operação de Raiz Quadrada.");
                Console.WriteLine("=============================================");

                Valor = LeitorValores.LerValor("Digite o valor:");

                Resultado = (decimal)Math.Sqrt((double)Valor);

                Console.WriteLine($"O resultado da raiz quadrada é: {Resultado.ToString("F2")}");
                return Resultado;
            }
        }

        private static class LeitorValores
        {
            public static decimal LerValor(string mensagem)
            {
                while (true)
                {
                    Console.WriteLine(mensagem);
                    string entrada = Console.ReadLine();

                    if (decimal.TryParse(entrada, out decimal valor) && valor >= 0)
                        return valor;

                    Console.WriteLine("Valor inválido. Por favor, insira um número maior ou igual a zero.");
                }
            }
        }
    }
}