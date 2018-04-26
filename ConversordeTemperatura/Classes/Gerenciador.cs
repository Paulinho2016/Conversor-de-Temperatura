using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConversordeTemperatura.Classes
{
    class Gerenciador
    {
        static string Opcao, ValorGraus;
        static bool Decisao;

        public static void Inicializacao()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("| BEM VINDO AO CONVERSOR DE TEMPERATURA  |");
            Console.WriteLine("==========================================\n");
            Thread.Sleep(2000);

            MenuPrincipal();
        }


        static void MenuPrincipal()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("|            Menu Principal              |");
                Console.WriteLine("==========================================");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|         [1] Conversor                  |");
                Console.WriteLine("|         [2] Informações                |");
                Console.WriteLine("|         [3] Sair                       |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("==========================================\n\n");

                Console.WriteLine("==========================================");
                Console.Write("Informe o nº da opção desejada: ");
                Opcao = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("\n==========================================\n\n");

                if (!char.IsDigit(Opcao[0]) || !char.IsNumber(Opcao[0]))
                {
                    Console.WriteLine("====================================================================");
                    Console.Write($"O dígito '{Opcao}', não faz referência a nenhuma opação do meunu.\nDeseja escolher uma opção?(s/n): ");
                    Opcao = Console.ReadKey().KeyChar.ToString();

                    while (!Opcao.ToUpper().Equals("S") && !Opcao.ToUpper().Equals("N"))
                    {
                        Console.Clear();
                        Console.Write("Digite 'S' para escolher uma opção ou 'N' para sair da aplicação: ");
                        Opcao = Console.ReadKey().KeyChar.ToString();
                    }

                    if (Opcao.ToUpper().Equals("N"))
                        Encerramento();
                }
                else
                {
                    if (Convert.ToInt32(Opcao) < 1 || Convert.ToInt32(Opcao) > 3)
                    {
                        Console.WriteLine("========================================================================");
                        Console.Write("Esse nº não representa nehuma opção, por favor escolha um valor válido!");
                        Console.WriteLine("\n========================================================================");
                        Thread.Sleep(2500);
                    }
                }

            } while ((!Opcao.Equals("1")) && (!Opcao.Equals("2")) && (!Opcao.Equals("3")));

            Etapa1(Convert.ToInt32(Opcao));
        }

        static void MenuConversor()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine("|             TIPOS DE CONVERSÕES                |");
                Console.WriteLine("==================================================");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|           [1] Celsius em Kelvin                |");
                Console.WriteLine("|           [2] Kelvin em Celsius                |");
                Console.WriteLine("|           [3] Celsius em Fahrenheit            |");
                Console.WriteLine("|           [4] Fahrenheit em Celsius            |");
                Console.WriteLine("|           [5] Kelvin em Fahrenheit             |");
                Console.WriteLine("|           [6] Fahrenheit em Kelvin             |");
                Console.WriteLine("|           [7] Voltar                           |");
                Console.WriteLine("|                                                |");
                Console.WriteLine("==================================================\n\n");

                Console.WriteLine("========================================");
                Console.Write("Informe o nº da opção desejada: ");
                Opcao = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("\n========================================\n\n");

                if (!char.IsDigit(Opcao[0]) || !char.IsNumber(Opcao[0]))
                {
                    Console.WriteLine("====================================================================");
                    Console.Write($"O dígito '{Opcao}', não faz referência a nenhuma das opções do meunu.\nDeseja escolher uma opção?(s/n): ");
                    Opcao = Console.ReadKey().KeyChar.ToString();

                    while (!Opcao.ToUpper().Equals("S") && !Opcao.ToUpper().Equals("N"))
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================================================");
                        Console.Write("Digite 'S' para escolher uma opção ou 'N' para voltar ao Menu Principal: ");
                        Opcao = Console.ReadKey().KeyChar.ToString();
                    }

                    if (Opcao.ToUpper().Equals("N"))
                        MenuPrincipal();
                }
                else
                {
                    if (Convert.ToInt32(Opcao) < 1 || Convert.ToInt32(Opcao) > 7)
                    {
                        Console.WriteLine("========================================================================");
                        Console.Write("Esse nº não representa nehuma opção, por favor escolha um valor válido!");
                        Console.WriteLine("\n========================================================================");
                        Thread.Sleep(2500);
                    }
                }

            } while (Convert.ToInt32(Opcao) < 1 || Convert.ToInt32(Opcao) > 7);

            Etapa2(Convert.ToInt32(Opcao));
        }

        static void Encerramento()
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("Encerrando Aplicação...");
            Console.WriteLine("=======================");
            Thread.Sleep(2000);
            Environment.Exit(1);
        }

        static void Etapa1(int escolha)
        {
            Console.Clear();

            switch (escolha)
            {
                case 1:
                    MenuConversor();
                    break;

                case 2:
                    break;

                case 3:
                    Encerramento();
                    break;                
            }
        }

        static void Etapa2(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|      CONVERTER CELSIUS EM KELVIN       |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));
                    break;

                case 2:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|      CONVERTER KELVIN EM CELSIUS       |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));                    
                    break;

                case 3:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|    CONVERTER CELSIUS EM FAHRENHEIT     |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));                    
                    break;

                case 4:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|    CONVERTER FAHRENHEIT EM CELSIUS     |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));                    
                    break;

                case 5:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|     CONVERTER KELVIN EM FAHRENHEIT      |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));
                    break;

                case 6:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("|     CONVERTER FAHRENHEIT EM KELVIN     |");
                        Console.WriteLine("==========================================\n\n");

                        Console.WriteLine("================================================");
                        Console.Write("Informe o valor de Celsius a ser convertido: ");
                        ValorGraus = Console.ReadLine();
                        Console.WriteLine("================================================\n\n");

                        Decisao = ValidarValor();

                    } while (!Decisao);

                    Converter(Convert.ToDecimal(ValorGraus));                    
                    break;

                case 7:
                    MenuPrincipal();
                    break;
            }
        }

        static void Converter(decimal graus)
        {
            switch (Convert.ToUInt32(Opcao))
            {
                case 1:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus}° Celsius equivale a {Temperatura.CelsiusParaKelvin().ToString("N2")} Kelvin");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;

                case 2:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus} Kelvin equivale a {Temperatura.KelvinParaCelsius().ToString("N2")}° Celsius");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;

                case 3:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus}° Celsius equivale a {Temperatura.CelsiusParaFahrenheit().ToString("N2")} Fahrenheit");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;

                case 4:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus} Fahrenheit equivale a {Temperatura.FahrenheitParaCelsius().ToString("N2")}° Celsius");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;

                case 5:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus} Kelvin equivale a {Temperatura.KelvinParaFahrenheit().ToString("N2")} Fahrenheit");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;

                case 6:
                    new Temperatura(graus);
                    Console.WriteLine("================================================");
                    Console.WriteLine($"{ValorGraus} Fahrenheit equivale a {Temperatura.FahrenheitParaKelvin().ToString("N2")} Kelvin");
                    Console.WriteLine("================================================");

                    Console.WriteLine("Conversão efetuada com sucasso!");
                    Console.Write("\n\nAperte uma tecla para continuar: ");
                    Console.ReadKey();
                    break;
            }

            do
            {
                Console.Clear();
                Console.WriteLine("==========================================");
                Console.WriteLine("|           O QUE DESEJA FAZER?          |");
                Console.WriteLine("==========================================");
                Console.WriteLine("|                                        |");
                Console.WriteLine("|      [1] Voltar ao Menu Principal      |");
                Console.WriteLine("|      [2] Continuar Convertendo         |");
                Console.WriteLine("|      [3] Sair                          |");
                Console.WriteLine("|                                        |");
                Console.WriteLine("==========================================\n\n");

                Console.WriteLine("==========================================");
                Console.Write("Informe o nº da opção desejada: ");
                Opcao = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("\n==========================================\n\n");

                if (!char.IsDigit(Opcao[0]) || !char.IsNumber(Opcao[0]))
                {
                    Console.WriteLine("====================================================================");
                    Console.Write($"O dígito '{Opcao}', não faz referência a nenhuma opação do meunu.\nDeseja escolher uma opção?(s/n): ");
                    Opcao = Console.ReadKey().KeyChar.ToString();

                    while (!Opcao.ToUpper().Equals("S") && !Opcao.ToUpper().Equals("N"))
                    {
                        Console.Clear();
                        Console.Write("Digite 'S' para escolher uma opção ou 'N' para sair da aplicação: ");
                        Opcao = Console.ReadKey().KeyChar.ToString();
                    }

                    if (Opcao.ToUpper().Equals("N"))
                        Encerramento();
                }
                else
                {
                    if (Convert.ToInt32(Opcao) < 1 || Convert.ToInt32(Opcao) > 3)
                    {
                        Console.WriteLine("========================================================================");
                        Console.Write("Esse nº não representa nehuma opção, por favor escolha um valor válido!");
                        Console.WriteLine("\n========================================================================");
                        Thread.Sleep(2500);
                    }
                }

            } while ((!Opcao.Equals("1")) && (!Opcao.Equals("2")) && (!Opcao.Equals("3")));

            switch (Convert.ToUInt32(Opcao))
            {
                case 1:
                    MenuPrincipal();
                    break;

                case 2:
                    MenuConversor();
                    break;

                case 3:
                    Encerramento();
                    break;
            }
        }

        static bool ValidarValor()
        {
            if (ValorGraus.Length < 1)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Nenhum valor foi informado!");
                Console.WriteLine("===========================");                
                Thread.Sleep(2500);
                return false;
            }
            else
            {
                foreach (char item in ValorGraus)
                {
                    if (char.IsLetter(item))
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine("O valor informar não é um número!");
                        Console.WriteLine("=================================");
                        Thread.Sleep(2500);
                        return false;
                    }
                }

                if (ValorGraus.Contains(","))
                    ValorGraus.Replace(",", ".");
            }
            return true;
        }
    }    
}
