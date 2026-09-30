using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassino___Seu_Dinheiro_é_Meu
{
    internal class Program
    {
        static string NomeUsuario;
        static int Saldo = 100;

        static void MenuNome()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("       CASSINO SEU DINHEIRO É MEU!      ");
            Console.WriteLine("========================================");
            Console.Write("Qual seu nome? ");
            NomeUsuario = Console.ReadLine();
        }

        static void Saque_deposito() { 
            Console.Clear();
            Cabecalho();
            Console.WriteLine($"Menu de Saques e Depósitos      Saldo:{Saldo}R$");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("0 - Voltar ao menu anterior");
            Console.WriteLine("========================================");
            Console.Write("Digite sua resposta: ");
            int RespostaSaque = int.Parse(Console.ReadLine());
                switch (RespostaSaque)
                {
                    case 1:
                        Console.Clear();
                        Cabecalho();
                        Console.WriteLine($"Saldo atual: {Saldo}R$");
                        Console.Write("Quanto irá sacar? ");
                        int Saque = int.Parse(Console.ReadLine());
                        if (Saldo < Saque)
                        {
                        Console.Clear();
                        Cabecalho();
                            Console.WriteLine($"Saldo Insuficiente!   Saldo Atual: {Saldo}R$");
                            Console.WriteLine($"Aperte qualquer tecla para voltar ao menu anterior...");
                        Console.ReadKey();
                        Saque_deposito();

                        }
                        else
                        {
                        Console.Clear();
                        Cabecalho();
                            Saldo = Saldo - Saque;
                        Console.WriteLine($"Saque feito com sucesso! Novo saldo {Saldo}R$");
                        Console.WriteLine($"Aperte qualquer tecla para voltar ao menu anterior...");
                        Console.ReadKey();
                        Saque_deposito();
                        }
                        break;
                    case 2:
                    Console.Clear();
                    Cabecalho();
                    Console.WriteLine($"Saldo atual: {Saldo}R$");
                    Console.Write("Quanto irá depositar? ");
                    int Deposito = int.Parse(Console.ReadLine());
                    Saldo = Saldo + Deposito;
                    Console.WriteLine("========================================");
                    Console.WriteLine($"Depósito realizado com sucesso, novo saldo: {Saldo}R$");
                    Console.WriteLine($"Aperte qualquer tecla para voltar ao menu anterior...");
                    Console.ReadKey();
                    Saque_deposito();
                    break;
                    case 0:
                    Menu();
                    break;
                default:
                    Console.WriteLine("Resposta Inválida!");
                    Console.WriteLine($"Aperte qualquer tecla para voltar...");
                    Console.WriteLine("========================================");
                    Console.ReadKey();
                    Saque_deposito();
                    break;
                }
        }

            
        

        static void Raspadinha(int OpMenu_main)
        {
            bool repetir = true;    
            while(repetir == true) {
                switch (OpMenu_main)
                {
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Menu Raspadinhas");
                        Console.WriteLine("========================================");
                        Console.WriteLine("1-Raspadinha A");
                        Console.WriteLine("2-Raspadinha B");
                        Console.WriteLine("0-Voltar ao Menu Anterior");
                        Console.WriteLine("========================================");
                        Console.Write("Digite sua Escolha: ");
                        Console.WriteLine("\n========================================");
                        int OpMenu_raspadinhas = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (OpMenu_raspadinhas >= 0 && OpMenu_raspadinhas <= 2)
                        {
                            repetir = false;
                        }
                        switch (OpMenu_raspadinhas)
                        {
                            case 1:
                                int PremioA = 0;
                                if (Saldo >= 2)
                                {
                                    Saldo -= 2;
                                }
                                else
                                {
                                    Cabecalho();
                                    Console.WriteLine("Saldo Insuficiente!");
                                    Console.WriteLine("Aperte qualquer tecla para voltar ao Menu anterior...");
                                    Console.ReadKey();
                                    Menu();
                                }
                                Random NumRaspadinha_usuario = new Random();
                                int Nj = NumRaspadinha_usuario.Next(1, 11);
                                Console.WriteLine($"Número Principal {Nj}");
                                Console.WriteLine("========================================");
                                Random NumRaspadinha_banca = new Random();
                                Random ValorRaspadinha = new Random();
                                for (int contador = 1; contador <= 5; contador++)
                                {
                                    int Valor_rasp = ValorRaspadinha.Next(1, 100);
                                    int Npc = NumRaspadinha_banca.Next(1, 11);
                                    Console.WriteLine($"{contador}º número: {Npc} ({Valor_rasp}R$)");
                                    if (Npc == Nj)
                                    {
                                        PremioA += Valor_rasp;
                                        Saldo += PremioA;
                                    }

                                }
                                Console.WriteLine("========================================");
                                Console.WriteLine($"Prêmio: {PremioA}R$");
                                Console.WriteLine("========================================");
                                Console.Write("Voltar para o menu anterior...");
                                Console.ReadKey();
                                Raspadinha(OpMenu_main);
                                break;

                            case 2:
                                if (Saldo >= 2)
                                {
                                    Saldo -= 2;
                                }
                                else
                                {
                                    Cabecalho();
                                    Console.WriteLine("Saldo Insuficiente!");
                                    Console.WriteLine("Aperte qualquer tecla para voltar ao Menu anterior...");
                                    Console.ReadKey();
                                    Menu();
                                }
                                int Tot3 = 0;
                                Random NumRaspadinhaUsuario2 = new Random();
                                int Nj2 = NumRaspadinhaUsuario2.Next(1, 10);
                                Random NumRaspadinhaBanca2 = new Random();
                                int Npc2 = NumRaspadinhaBanca2.Next(1, 11);
                                Random Nvalor = new Random();
                                int ValorRaspadinha2 = Nvalor.Next(1, 11);
                                Console.WriteLine($"Número principal: {Nj2} ({ValorRaspadinha2})");
                                for (int contador = 1; contador <= 3; contador++)
                                {
                                    Npc2 = NumRaspadinhaBanca2.Next(1, 10);
                                    Console.Write($"{Npc2}   ");
                                    if (Npc2 == Nj2)
                                    {
                                        Tot3 += 1;
                                    }
                                }
                                Console.WriteLine();
                                for (int contador = 1; contador <= 3; contador++)
                                {
                                    Npc2 = NumRaspadinhaBanca2.Next(1, 10);
                                    Console.Write($"{Npc2}   ");
                                    if (Npc2 == Nj2)
                                    {
                                        Tot3 += 1;
                                    }

                                }
                                Console.WriteLine();
                                for (int contador = 1; contador <= 3; contador++)
                                {
                                    Npc2 = NumRaspadinhaBanca2.Next(1, 10);
                                    Console.Write($"{Npc2}   ");
                                    if (Npc2 == Nj2)
                                    {
                                        Tot3 += 1;
                                    }
                                }
                                Console.WriteLine();
                                if (Tot3 == 3)
                                {
                                    Saldo += ValorRaspadinha2;
                                    Console.WriteLine("========================================");
                                    Console.WriteLine($"Parabéns você foi premiado!! Ganhou {ValorRaspadinha2}R$");
                                    Console.WriteLine("========================================");
                                }
                                else
                                {
                                    Console.WriteLine("========================================");
                                    Console.WriteLine("Raspadinha não premiada... Não foi dessa vez!");
                                    Console.WriteLine("========================================");
                                }
                                Console.WriteLine("Aperte qualquer tecla para voltar ao Menu anterior...");
                                Console.ReadKey();
                                Raspadinha(OpMenu_main);
                                break;


                            case 0:
                                Menu();
                                break;
                        }
                        break;
                }

                }
            }

        static void Loteria(int OpMenu_main)
        {
            
            switch (OpMenu_main)
            {
                case 1:
                    Console.Clear();
                    Cabecalho();
                    if (Saldo >= 5)
                    {
                        Saldo -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Saldo Insuficiente!");
                        Console.WriteLine("Aperte qualquer tecla para voltar ao Menu anterior...");
                        Console.ReadKey();
                        Menu();
                    }
                    Random random = new Random();
                    int Premio = random.Next(1000, 10000);
                    Console.WriteLine($"Bilhete Premiado: {Premio}");
                    Console.WriteLine("Qual o Número quer Jogar na Loteria? (1000-9999) ");
                    Console.Write("Digite seu valor: ");
                    int ValorJogador = int.Parse(Console.ReadLine());
                    if (ValorJogador < 1000 || ValorJogador > 9999)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Número inválido!");
                    }
                    if (ValorJogador == Premio && ValorJogador >= 1000)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Parabéns Você Ganhou o 1º Prêmio!");
                        Console.WriteLine("========================================");
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Menu");
                        Console.ReadKey();
                        Console.Clear();
                        Saldo += 1000;
                        Menu();
                    }
                    else if (ValorJogador % 1000 == Premio % 1000 && ValorJogador >= 1000)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Parabéns Você Ganhou o 2º Prêmio!");
                        Console.WriteLine("========================================");
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Menu");
                        Console.ReadKey();
                        Console.Clear();
                        Saldo += 500;
                        Menu();
                    }
                    else if (ValorJogador % 100 == Premio % 100 && ValorJogador >= 1000)
                    {
                        Console.WriteLine("========================================");
                        Console.WriteLine("Parabéns Você Ganhou o 3º Prêmio!");
                        Console.WriteLine("========================================");
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Menu");
                        Console.ReadKey();
                        Console.Clear();
                        Saldo += 100;
                        Menu();
                    }
                    else
                    {
                        Console.WriteLine("Seu bilhete não foi premiado");
                        Console.WriteLine("========================================");
                        Console.WriteLine("Aperte qualquer tecla para voltar para o Menu");
                        Console.ReadKey();
                        Console.Clear();
                        Menu();

                    }
                    break;

                case 0:
                    Console.Clear();
                    Cabecalho();
                    Console.WriteLine("Saindo...\nAperte Qualquer Tecla para Sair");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }



            public static void Cabecalho()
            {
                Console.WriteLine("========================================");
                Console.WriteLine("       CASSINO SEU DINHEIRO É MEU!      ");
                Console.WriteLine("========================================");
            }
            
            static void Menu()
            {
            
            bool Loops = true;

            while (Loops == true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("       CASSINO SEU DINHEIRO É MEU!      ");
                Console.WriteLine("========================================");
                Console.Clear();
                Cabecalho();
                Console.WriteLine($"Bem vindo {NomeUsuario}!             Saldo: {Saldo}R$");
                Console.WriteLine("========================================");
                Console.WriteLine("Escolha uma das opções: ");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Saques/Depósitos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("========================================");
                Console.Write("Digite sua Resposta: ");
                Console.WriteLine("\n========================================");
                int OpMenu_main = int.Parse(Console.ReadLine());
                if (OpMenu_main >= 0 && OpMenu_main <= 3)
                {
                    Loops = false;
                }
                else
                {
                    Console.Clear();
                    Cabecalho();
                    Console.WriteLine("Resposta Inválida!");
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    Loops = true;
                    Console.Clear();
                }
                switch (OpMenu_main)
                {
                    case 1:
                        Loteria(OpMenu_main);
                        break;
                    case 2:
                        Raspadinha(OpMenu_main);
                        break;
                    case 3:
                        Saque_deposito();
                        break;
                }
            }
                

               
            



        }
            static void Main(string[] args)
            {
                MenuNome();
                Menu();
            }
        }
    }

