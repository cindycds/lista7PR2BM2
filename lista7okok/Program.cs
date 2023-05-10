using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista7okok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int paradinha = 1;
            while (paradinha != 0)
            {
                int menuzin;
                Console.WriteLine("1- exercicio 1");
                Console.WriteLine("2- exercicio 2");
                Console.WriteLine("3- exercicio 3");
                Console.WriteLine("4- exercicio 4");
                Console.WriteLine("5- exercicio 5");
                Console.WriteLine("6- exercicio 6");
                Console.WriteLine("7- exercicio 7");
                menuzin = int.Parse(Console.ReadLine());

                switch (menuzin)
                {
                    case 1:



                        float quant = 1, valor, totalval = 0, totalitens = 0;
                        while (true)
                        {

                            quant++;
                            Console.WriteLine("Digite a quantidade do produto,quando quiser terminar digite 0:");
                            quant = float.Parse(Console.ReadLine());
                            if (quant == 0)
                                break;

                            Console.WriteLine("Digite o  valor desses produto :");
                            valor = float.Parse(Console.ReadLine());

                            totalitens += quant;
                            totalval += quant * valor;

                        }
                        Console.WriteLine("a quandidade de produtos é:" + totalitens);
                        Console.WriteLine("o valor total da suacompra é:" + totalval);



                        break;
                    case 2:

                        string nome, nomemaio = "", nomemenor = "";
                        int numitens, parada = 2;
                        float preco, menor, maior;

                        maior = float.MaxValue;
                        menor = float.MinValue;

                        while (parada != 1)
                        {
                            Console.WriteLine(" entre com o nome do produto");
                            nome = Console.ReadLine();

                            Console.WriteLine(" entre com o total de itens :");
                            numitens = int.Parse(Console.ReadLine());

                            Console.WriteLine("entrecom o preço unitario");
                            preco = float.Parse(Console.ReadLine());

                            float total = numitens * preco;
                            if (total > maior)
                            {
                                maior = total;
                                nomemaio = nome;

                            }
                            if (total < menor)
                            {
                                menor = total;
                                nomemenor = nome;
                            }

                            Console.WriteLine(" digite 1 para sair e 2 para continuar: ");
                            parada = int.Parse(Console.ReadLine());
                            Console.WriteLine("maior quantia investida {0} no produto {1}", maior, nomemaio);
                            Console.WriteLine("maior quantia investida {0} no produto {1}", menor, nomemenor);

                        }



                        break;
                    case 3:
                        float pesos, tpesos = 0;
                        Console.WriteLine("Digite a quantidade de avaliaçoes que voce fará:");
                        int quantavali = int.Parse(Console.ReadLine());

                        int c = 1;
                        while (c <= quantavali)
                        {
                            c++;
                            Console.WriteLine("Digite os pesos das notas {i}:");
                            pesos = float.Parse(Console.ReadLine());
                            tpesos += pesos;
                        }
                        Console.WriteLine("a soma dos pesos é: " + tpesos);
                        if (tpesos < 100)
                            Console.WriteLine("Pesos insuficientes");

                        else if (tpesos > 100)
                            Console.WriteLine("superior a 100% alcansada");


                        else
                        {
                            Console.WriteLine("porcentagem de 100% alcansada");
                        }

                        break;
                    case 4:
                        string sigla;
                        Console.WriteLine("informe a sigla do estado desejado:");
                        sigla = Console.ReadLine();

                        switch (sigla)
                        {
                            case "AC":
                                Console.WriteLine("sigla referente ao Acre");
                                break;

                            case "AL":
                                Console.WriteLine("sigla referente ao Alagoas");
                                break;
                            case "AP":
                                Console.WriteLine("sigla referente ao Amapá");
                                break;
                            case "AM":
                                Console.WriteLine("sigla referente ao Amazonas");
                                break;
                            case "BA":
                                Console.WriteLine("sigla referente ao Bahia");
                                break;
                            case "CE":
                                Console.WriteLine("sigla referente ao Ceará");
                                break;
                            case "DF":
                                Console.WriteLine("sigla referente ao Distrito Federal");
                                break;
                            case "ES":
                                Console.WriteLine("sigla referente ao Espirito Santo");
                                break;
                            case "GO":
                                Console.WriteLine("sigla referente ao Goiás");
                                break;
                            case "MA":
                                Console.WriteLine("sigla referente ao Maranhão");
                                break;
                            case "MT":
                                Console.WriteLine("sigla referente ao Mato Grosso");
                                break;
                            case "MS":
                                Console.WriteLine("sigla referente ao Mato Grosso do Sul");
                                break;
                            case "MG":
                                Console.WriteLine("sigla referente ao Minas Gerais");
                                break;
                            case "PA":
                                Console.WriteLine("sigla referente ao Pará");
                                break;
                            case "PB":
                                Console.WriteLine("sigla referente ao Paraíba");
                                break;
                            case "PR":
                                Console.WriteLine("sigla referente ao Paraná");
                                break;
                            case "PE":
                                Console.WriteLine("sigla referente ao Pernambuco");
                                break;
                            case "PI":
                                Console.WriteLine("sigla referente ao Piauí");
                                break;
                            case "Rj":
                                Console.WriteLine("sigla referente ao Rio de Janeiro");
                                break;
                            case "RN":
                                Console.WriteLine("sigla referente ao Rio Grande do Norte");
                                break;
                            case "RS":
                                Console.WriteLine("sigla referente ao Rio Grande do Sul");
                                break;
                            case "RO":
                                Console.WriteLine("sigla referente ao Rondonia");
                                break;
                            case "RR":
                                Console.WriteLine("sigla referente ao Roraima");
                                break;
                            case "SC":
                                Console.WriteLine("sigla referente ao Santa Catarina");
                                break;
                            case "SP":
                                Console.WriteLine("sigla referente ao São Paulo");
                                break;
                            case "SE":
                                Console.WriteLine("sigla referente ao Sergipe");
                                break;
                            case "TO":
                                Console.WriteLine("sigla referente ao Tocantins");
                                break;
                            default:
                                Console.WriteLine("Sigla invalida");
                                break;

                        }


                        break;
                    case 5:
                        int mes, dia;

                        Console.WriteLine("Digite o numero do mes em que deseja:");
                        mes = int.Parse(Console.ReadLine());
                        switch (mes)
                        {
                            case (1):
                                Console.WriteLine("A estação é verão");
                                break;
                            case (2):
                                Console.WriteLine("A estação é verão");
                                break;
                            case (3):
                                Console.WriteLine("me informe o dia:");
                                dia = int.Parse(Console.ReadLine());
                                if (dia >= 20)
                                    Console.WriteLine("a estaçao é outono");
                                else
                                    Console.WriteLine("A estação é verão");
                                break;
                            case (4):
                                Console.WriteLine("A estação é outono");
                                break;
                            case (5):
                                Console.WriteLine("A estação é outono");
                                break;
                            case (6):
                                Console.WriteLine("me informe o dia:");
                                dia = int.Parse(Console.ReadLine());
                                if (dia >= 20)
                                    Console.WriteLine("a estaçao é inverno");
                                else
                                    Console.WriteLine("A estação é outono");
                                break;
                            case (7):
                                Console.WriteLine("a estaçao é inverno");
                                break;
                            case (8):
                                Console.WriteLine("a estaçao é inverno");
                                break;
                            case (9):
                                Console.WriteLine("me informe o dia:");
                                dia = int.Parse(Console.ReadLine());
                                if (dia >= 22)
                                    Console.WriteLine("a estaçao é primavera");
                                else
                                    Console.WriteLine("A estação é inverno");
                                break;
                            case (10):
                                Console.WriteLine("a estaçao é primavera");
                                break;
                            case (11):
                                Console.WriteLine("a estaçao é primavera");
                                break;
                            case (12):
                                Console.WriteLine("me informe o dia:");
                                dia = int.Parse(Console.ReadLine());
                                if (dia >= 21)
                                    Console.WriteLine("a estaçao é verão");
                                else
                                    Console.WriteLine("A estação é primavera");
                                break;
                        }

                        break;
                    case 6:
                        float peso, altura, imc;
                        Console.WriteLine("informe sua altura:");
                        altura = float.Parse(Console.ReadLine());
                        Console.WriteLine("informe o seu peso:");
                        peso = float.Parse(Console.ReadLine());
                        imc = peso / (altura * altura);

                        if (imc < 18.5)
                            Console.WriteLine("esta abaixo do peso");
                        else if (imc == 18.5 && imc == 34.90)
                            Console.WriteLine("Peso normal");
                        else if (imc == 25.0 && imc == 29.9)
                            Console.WriteLine("Sobrepeso");
                        else if (imc == 30.0 && imc == 34.9)
                            Console.WriteLine("obesidade grau 1");
                        else if (imc == 35.0 && imc == 39.9)
                            Console.WriteLine("obesidade de grau 2");
                        else
                            Console.WriteLine("Obesidade de grau 3(morbita)");

                        break;
                    case 7:
                        int numero;
                        Console.WriteLine("digite um numero maior que zero:");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Divisores de " + numero + ":");

                        int f = 1;
                        while (f <= numero)
                        {
                            f++;
                            if (numero % f == 0)
                            {
                                Console.WriteLine(f);
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("exercicio inexistente");
                        break;

                }


                Console.WriteLine("se quiser executar novamente digite 1, se nãodigite 0:");
                paradinha = int.Parse(Console.ReadLine());
            }


        }
    }
    }

