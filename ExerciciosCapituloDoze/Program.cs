using System;
using System.Collections.Generic;
using ExerciciosCapituloDoze.ClassesAuxiliares;
using ExerciciosCapituloDoze.Exercicios.Exercicio01;
using ExerciciosCapituloDoze.Exercicios.Exercicio02;
using ExerciciosCapituloDoze.Exercicios.Exercicio03;

namespace ExerciciosCapituloDoze
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios Capítulo 12");
            Console.WriteLine("---------------------------------------------\n");

            bool executarMaisUmExercicio = true;

            while (executarMaisUmExercicio)
            {
                Console.WriteLine("Digite abaixo o número do exercício que você quer executar:");
                int numeroDoExercicio = int.Parse(Console.ReadLine());

                switch (numeroDoExercicio)
                {
                    case 1:
                        Exercicio01();
                        break;
                    case 2:
                        Exercicio02();
                        break;
                    case 3:
                        Exercicio03();
                        break;
                    case 4:
                        Exercicio04();
                        break;
                    case 5:
                        Exercicio05();
                        break;
                    case 6:
                        Exercicio06();
                        break;
                    case 7:
                        Exercicio07();
                        break;
                    case 8:
                        Exercicio08();
                        break;
                    case 9:
                        Exercicio09();
                        break;
                    case 10:
                        Exercicio10();
                        break;
                    case 11: 
                        Exercicio11();
                        break;
                    case 12: 
                        Exercicio12();
                        break;
                    case 13: 
                        Exercicio13();
                        break;
                    case 14: 
                        Exercicio14();
                        break;
                    case 15: 
                        Exercicio15();
                        break;
                    case 16: 
                        Exercicio16();
                        break;
                    case 17: 
                        Exercicio17();
                        break;
                    case 18: 
                        Exercicio18();
                        break;
                    case 19: 
                        Exercicio19();
                        break;
                    case 20:
                        Exercicio20();
                        break;
                    case 21:
                        Exercicio21();
                        break;
                    case 22:
                        Exercicio22();
                        break;
                    case 23: 
                        Exercicio23();
                        break;
                    case 24: 
                        Exercicio24();
                        break;
                    case 25: 
                        Exercicio25();
                        break;
                    case 26: 
                        Exercicio26();
                        break;
                    case 27:
                        Exercicio27();
                        break;
                    case 28: 
                        Exercicio28();
                        break;
                    case 29: 
                        Exercicio29();
                        break;
                    case 30: 
                        Exercicio30();
                        break;
                    case 31: 
                        Exercicio31();
                        break;
                    case 32: 
                        Exercicio32();
                        break;
                    case 33: 
                        Exercicio33();
                        break;
                    case 34: 
                        Exercicio34();
                        break;
                    case 35: 
                        Exercicio35();
                        break;
                    case 36: 
                        Exercicio36();
                        break;
                    case 37: 
                        Exercicio37();
                        break;
                    case 38: 
                        Exercicio38();
                        break;
                    case 39:
                        Exercicio39();
                        break;
                    case 40:
                        Exercicio40();
                        break;
                    default:
                        Console.WriteLine("Número Inválido!");
                        break;
                }

                Console.WriteLine("Deseja finalizar a aplicação? (digite S para confirmar ou qualquer tecla para seguir)");
                string finalizar = Console.ReadLine().ToUpper();

                if (finalizar == "S")
                {
                    executarMaisUmExercicio = false;
                }

                Console.Clear();
            }

            Exercicio01();

            Exercicio02();

            Exercicio03();

            Exercicio04();

            Exercicio05();

            Exercicio06();

            Exercicio07();

            Exercicio08();

            Exercicio09();

            Exercicio10();

            Exercicio11();

            Exercicio12();

            Exercicio13();

            Exercicio14();

            Exercicio15();

            Exercicio16();

            Exercicio17();

            Exercicio18();

            Exercicio19();

            Exercicio20();

            Exercicio21();

            Exercicio22();

            Exercicio23();

            Exercicio24();

            Exercicio25();

            Exercicio26();

            Exercicio27();

            Exercicio28();

            Exercicio29();

            Exercicio30();

            Exercicio31();

            Exercicio32();

            Exercicio33();

            Exercicio34();

            Exercicio35();

            Exercicio36();

            Exercicio37();

            Exercicio38();

            Exercicio39();

            Exercicio40();
        }

        private static void Exercicio01()
        {
            Console.WriteLine("Exercício 1\n");

            Console.WriteLine("Insira o valor do salário mínimo abaixo.");
            double salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade de Watts gasta pela residência.");
            int quantidadeDeWatts = int.Parse(Console.ReadLine());

            Exercicio1 exercicio1 = new Exercicio1(salarioMin, quantidadeDeWatts);

            exercicio1.ImprimirValorPorCadaKw();
            exercicio1.ImprimirValorTotalASerPago();
            exercicio1.ImprimirValorTotalASerPago(10);

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio02()
        {
            Console.WriteLine("Exercício 2\n");

            Console.WriteLine("Insira abaixo o valor do produto que irá receber o desconto.");
            double valorDoProduto = double.Parse(Console.ReadLine());

            Exercicio2 exercicio2 = new Exercicio2(valorDoProduto);

            exercicio2.ImprimirValorComDesconto();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio03()
        {
            Console.WriteLine("Exercício 3\n");

            Console.WriteLine("Insira abaixo o valor da hora aula.");
            double valorHoraAula = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o numero de aulas dadas no mês.");
            double numeroDeAulas = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o desconto do inss."); // Ex.: Se 15% então deve-se inserir apenas 15
            double descontoInss = double.Parse(Console.ReadLine());

            Exercicio3 exercicio3 = new Exercicio3(valorHoraAula, numeroDeAulas, descontoInss);

            exercicio3.ImprimirValorDoSalarioLiquido();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio04()
        {
            Console.WriteLine("Exercício 4\n");

            Console.WriteLine("Insira abaixo o valor gasto no jantar.");
            double valorGastoNoJantar = double.Parse(Console.ReadLine());

            //Exercicio4 exercicio4 = new Exercicio4(valorGastoNoJantar);

            //exercicio3.ImprimirValorDaContaComGorjetaDeDezPorcento();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio05()
        {
            Console.WriteLine("Exercício 5\n");

            Console.WriteLine("Insira abaixo o valor constante aplicado mensalmente.");
            double valorConstanteAplicado = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o valor da taxa.");
            double valorDaTaxa = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o numero de meses.");
            int numeroDeMeses = int.Parse(Console.ReadLine());

            //Exercicio5 exercicio5 = new Exercicio5();

            //exercicio5.ImprimirRendimento();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio06()
        {
            Console.WriteLine("Exercício 6\n");

            Console.WriteLine("Insira abaixo um número que será exibido caso seja maior que 20.");
            int numero = int.Parse(Console.ReadLine());

            //Exercicio6 exercicio6 = new Exercicio6();

            //exercicio6.ImprimirNumeroSeForMaiorQueVinte();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio07()
        {
            Console.WriteLine("Exercício 7\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumero = int.Parse(Console.ReadLine());

            //Exercicio7 exercicio7 = new Exercicio7();

            //exercicio7.ImprimirValorDaSomaSeForMaiorQueVinte();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio08()
        {
            Console.WriteLine("Exercício 8\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx8 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx8 = int.Parse(Console.ReadLine());

            //Exercicio8 exercicio8 = new Exercicio8();

            //exercicio8.ImprimirValorDaSomaComARegraAplicada();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio09()
        {
            Console.WriteLine("Exercício 9\n");

            Console.WriteLine("Insira abaixo o salário bruto.");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o valor da prestação desejada.");
            double valorDaPrestacao = double.Parse(Console.ReadLine());

            //Exercicio9 exercicio9 = new Exercicio9();

            //exercicio9.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio10()
        {
            Console.WriteLine("Exercício 10\n");

            Console.WriteLine("Insira abaixo um número.");
            int numeroEx10 = int.Parse(Console.ReadLine());

            //Exercicio10 exercicio10 = new Exercicio10();

            //exercicio10.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio11()
        {
            Console.WriteLine("Exercício 11\n");

            Console.WriteLine("Insira abaixo um número.");
            int numeroEx11 = int.Parse(Console.ReadLine());

            //Exercicio11 exercicio11 = new Exercicio11();

            //exercicio11.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio12()
        {
            Console.WriteLine("Exercício 12\n");

            Console.WriteLine("Insira abaixo o nome.");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira abaixo o sexo. Use M para masculino e F para feminino.");
            string sexo = Console.ReadLine();

            Console.WriteLine("Insira abaixo a idade.");
            int idade = int.Parse(Console.ReadLine());

            //Exercicio12 exercicio12 = new Exercicio12();

            //exercicio12.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio13()
        {
            Console.WriteLine("Exercício 13\n");

            Console.WriteLine("Insira abaixo a sigla do estado.");
            string siglaDoEstado = Console.ReadLine();

            //Exercicio13 exercicio13 = new Exercicio13();

            //exercicio13.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio14()
        {
            Console.WriteLine("Exercício 14\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx14 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx14 = int.Parse(Console.ReadLine());

            //Exercicio14 exercicio14 = new Exercicio14();

            //exercicio14.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio15()
        {
            Console.WriteLine("Exercício 15\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx15 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx15 = int.Parse(Console.ReadLine());

            //Exercicio15 exercicio15 = new Exercicio15();

            //exercicio15.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio16()
        {
            Console.WriteLine("Exercício 16\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx16 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx16 = int.Parse(Console.ReadLine());

            //Exercicio16 exercicio16 = new Exercicio16();

            //exercicio16.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio17()
        {
            Console.WriteLine("Exercício 17\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx17 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx17 = int.Parse(Console.ReadLine());

            //Exercicio17 exercicio17 = new Exercicio17();

            //exercicio17.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio18()
        {
            Console.WriteLine("Exercício 18\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx18 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx18 = int.Parse(Console.ReadLine());

            //Exercicio18 exercicio18 = new Exercicio18();

            //exercicio18.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio19()
        {
            Console.WriteLine("Exercício 19\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx19 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx19 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o terceiro número.");
            int terceiroNumeroEx19 = int.Parse(Console.ReadLine());

            //Exercicio19 exercicio19 = new Exercicio19();

            //exercicio19.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio20()
        {
            Console.WriteLine("Exercício 20\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx20 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx20 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o terceiro número.");
            int terceiroNumeroEx20 = int.Parse(Console.ReadLine());

            //Exercicio20 exercicio20 = new Exercicio20();

            //exercicio20.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio21()
        {
            Console.WriteLine("Exercício 21\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx21 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx21 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o terceiro número.");
            int terceiroNumeroEx21 = int.Parse(Console.ReadLine());

            //Exercicio21 exercicio21 = new Exercicio21();

            //exercicio21.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio22()
        {
            Console.WriteLine("Exercício 22\n");

            Console.WriteLine("Insira abaixo o primeiro número.");
            int primeiroNumeroEx22 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o segundo número.");
            int segundoNumeroEx22 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo o terceiro número.");
            int terceiroNumeroEx22 = int.Parse(Console.ReadLine());

            //Exercicio22 exercicio22 = new Exercicio22();

            //exercicio22.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio23()
        {
            Console.WriteLine("Exercício 23\n");

            Console.WriteLine("Qual a quantidade de numeros a serem inputados?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<int> numerosInputados = new List<int>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo o {contador}º numero.");
                int numeroInputado = int.Parse(Console.ReadLine());

                numerosInputados.Add(numeroInputado);
            }

            //Exercicio23 exercicio23 = new Exercicio23();

            //exercicio23.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio24()
        {
            Console.WriteLine("Exercício 24\n");

            Console.WriteLine("Insira abaixo a idade da pessoa.");
            int idadeEx24 = int.Parse(Console.ReadLine());

            //Exercicio24 exercicio24 = new Exercicio24();

            //exercicio24.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio25()
        {
            Console.WriteLine("Exercício 25\n");

            Console.WriteLine("Insira abaixo o nome do aluno.");
            string nomeEx25 = Console.ReadLine();

            Console.WriteLine("Insira abaixo a nota da prova 1.");
            double notaProvaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira abaixo a nota da prova 2.");
            double notaProvaDois = double.Parse(Console.ReadLine());

            //Exercicio25 exercicio25 = new Exercicio25();

            //exercicio25.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio26()
        {
            Console.WriteLine("Exercício 26\n");

            Console.WriteLine("Insira abaixo o valor do produto.");
            double valorDoProdutoEx26 = double.Parse(Console.ReadLine());

            //Exercicio26 exercicio26 = new Exercicio26();

            //exercicio26.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio27()
        {
            Console.WriteLine("Exercício 27\n");

            Console.WriteLine("Insira abaixo o nome do cliente.");
            string nomeEx27 = Console.ReadLine();

            Console.WriteLine("Insira abaixo o valor da conta.");
            double valorDaConta = double.Parse(Console.ReadLine());

            //Exercicio27 exercicio27 = new Exercicio27();

            //exercicio27.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio28()
        {
            Console.WriteLine("Exercício 28\n");

            Console.WriteLine("Insira abaixo a placa do veículo.");
            string placaDoVeiculo = Console.ReadLine();

            //Exercicio28 exercicio28 = new Exercicio28();

            //exercicio28.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio29()
        {
            Console.WriteLine("Exercício 29\n");

            //Exercicio29 exercicio29 = new Exercicio29();

            //exercicio29.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio30()
        {
            Console.WriteLine("Exercício 30\n");

            Console.WriteLine("Insira abaixo um numero.");
            int numeroEx30 = int.Parse(Console.ReadLine());

            //Exercicio30 exercicio30 = new Exercicio30();

            //exercicio30.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio31()
        {
            Console.WriteLine("Exercício 31\n");

            //Exercicio31 exercicio31 = new Exercicio31();

            //exercicio31.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio32()
        {
            Console.WriteLine("Exercício 32\n");

            int[] grupo1 = new int[4] { 1, 13, 16, 3 };
            int[] grupo2 = new int[4] { 4, 6, 8, 11 };
            int[] grupo3 = new int[4] { 22, 15, 40, 14 };
            int[] grupo4 = new int[4] { 17, 9, 12, 5 };
            int[] grupo5 = new int[4] { 33, 41, 55, 7 };

            //Exercicio32 exercicio32 = new Exercicio32();

            //exercicio32.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio33()
        {
            Console.WriteLine("Exercício 33\n");

            Console.WriteLine("Insira abaixo o nome do cliente.");
            string nomeDoClienteEx33 = Console.ReadLine();

            Console.WriteLine("Insira abaixo o valor das compras no ano passado.");
            double valorDasComprasAnoAnterior = double.Parse(Console.ReadLine());

            //Exercicio33 exercicio33 = new Exercicio33();

            //exercicio33.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio34()
        {
            Console.WriteLine("Exercício 34\n");

            //Exercicio34 exercicio34 = new Exercicio34();

            //exercicio34.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio35()
        {
            Console.WriteLine("Exercício 35\n");

            Console.WriteLine("Qual a quantidade de idades a serem inputadas?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<int> idadesInputadas = new List<int>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo a {contador}ª idade.");
                int idadeInputada = int.Parse(Console.ReadLine());

                idadesInputadas.Add(idadeInputada);
            }

            //Exercicio35 exercicio35 = new Exercicio35();

            //exercicio35.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio36()
        {
            Console.WriteLine("Exercício 36\n");

            Console.WriteLine("Qual a quantidade de idades a serem inputadas?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<int> idadesInputadas = new List<int>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo a {contador}ª idade.");
                int idadeInputada = int.Parse(Console.ReadLine());

                idadesInputadas.Add(idadeInputada);
            }

            //Exercicio36 exercicio36 = new Exercicio36();

            //exercicio36.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio37()
        {
            Console.WriteLine("Exercício 37\n");

            //Exercicio37 exercicio37 = new Exercicio37();

            //exercicio37.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio38()
        {
            Console.WriteLine("Exercício 38\n");

            Console.WriteLine("Qual a quantidade de transações a serem inputadas?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<Transacao> transacoesInputadas = new List<Transacao>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo o código da {contador}ª transação. Use V ou P");
                string codigo = Console.ReadLine().ToUpper();
                Console.WriteLine($"Insira abaixo o valor da {contador}ª transação");
                double valor = double.Parse(Console.ReadLine());

                Transacao transacao = new Transacao(codigo, valor);

                transacoesInputadas.Add(transacao);
            }

            //Exercicio38 exercicio38 = new Exercicio38();

            //exercicio38.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio39()
        {
            Console.WriteLine("Exercício 39\n");

            Console.WriteLine("Qual a quantidade de pessoas a serem inputadas?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<Pessoa> pessoasInputadas = new List<Pessoa>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo a idade da {contador}ª pessoa.");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira abaixo a altura da {contador}ª pessoa (em centimentros)");
                int altura = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira abaixo o peso da {contador}ª pessoa");
                double peso = double.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(idade, altura, peso);

                pessoasInputadas.Add(pessoa);
            }

            //Exercicio39 exercicio39 = new Exercicio39();

            //exercicio39.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }

        private static void Exercicio40()
        {
            Console.WriteLine("Exercício 40\n");

            Console.WriteLine("Qual a quantidade de pessoas a serem inputadas?");
            int quantidadeDeInputs = int.Parse(Console.ReadLine());

            List<Pessoa> pessoasInputadas = new List<Pessoa>();

            for (int contador = 1; contador <= quantidadeDeInputs; contador++)
            {
                Console.WriteLine($"Insira abaixo a idade da {contador}ª pessoa.");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira abaixo a altura da {contador}ª pessoa (em centimentros)");
                int altura = int.Parse(Console.ReadLine());
                Console.WriteLine($"Insira abaixo o peso da {contador}ª pessoa");
                double peso = double.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(idade, peso);

                pessoasInputadas.Add(pessoa);
            }

            //Exercicio40 exercicio40 = new Exercicio40();

            //exercicio40.ImprimirResposta();

            Console.WriteLine("---------------------------------------------\n");
        }
    }
}
