using System;
using System.IO;
using System.Threading;

namespace ConversordeTemperatura.Classes
{
    class Gerenciador
    {
        #region VARIÁVEIS

        static string Opcao;
        static string ValorGraus;        
        static bool Decisao;

        #endregion



        #region MÉTODOS

        /// <summary>
        /// Método sem retorno que dispara a inicialização da aplicação.
        /// </summary>
        public static void Inicializacao()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("| BEM VINDO AO CONVERSOR DE TEMPERATURA  |");
            Console.WriteLine("==========================================\n");
            Thread.Sleep(2000);

            MenuPrincipal();
        }

        /// <summary>
        /// Método sem retorno que executa a exibição e manipulação do Menu Principal.
        /// </summary>
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

        /// <summary>
        /// Método sem retorno que executa a exibição e manipulação do Menu de Conversões.
        /// </summary>
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

        /// <summary>
        /// Método responsável por encerrar a aplicação.
        /// </summary>
        static void Encerramento()
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("Encerrando Aplicação...");
            Console.WriteLine("=======================");
            Thread.Sleep(2000);
            Environment.Exit(1);
        }

        /// <summary>
        /// Método sem retorno que contrala a opção escolhida no Menu Principal.
        /// </summary>
        /// <param name="escolha">Inteiro que representa a a opção do Menu Principal.</param>
        static void Etapa1(int escolha)
        {
            Console.Clear();

            switch (escolha)
            {
                case 1:
                    MenuConversor();
                    break;

                case 2:
                    ExibirInformacoes();
                    break;

                case 3:
                    Encerramento();
                    break;
            }
        }

        /// <summary>
        /// Método sem retorno que dispara a Conversão de Temperatura, recebendo com argumento o tipo de conversão escolhida.
        /// </summary>
        /// <param name="escolha">Inteiro que representa a escolha do tipo de conversão no Menu Conversão de temperatura</param>
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

        /// <summary>
        /// Método sem retorno responsável por converter e exibir resultado.
        /// </summary>
        /// <param name="graus">Decimal que representa o valor da Temperatura a sem convertida.</param>
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

        /// <summary>
        /// Método Booleano que Valida o valor da temperatura coletada para conversãp.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Método que invoca a exibição das informações da aplicação.
        /// </summary>
        static void ExibirInformacoes()
        {
            Console.Clear();

            using (StreamReader Leitor = new StreamReader($"{Environment.CurrentDirectory}\\info.txt"))
            {
                while (!Leitor.EndOfStream)
                {
                    Console.WriteLine(Leitor.ReadLine());
                   
                }
            }

            Console.Write("Aperte qualquer tecla para voltar");
            Console.ReadKey();
            MenuPrincipal();
        }

        #endregion
    }
}
