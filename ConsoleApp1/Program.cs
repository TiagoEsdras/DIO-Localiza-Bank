﻿using System;
using System.Collections.Generic;

namespace ConsoleBank
{
    class Program
    {
        static List<Conta> contas = new List<Conta>();
        static void Main(string[] args)        {
            
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        InserirConta();
                        break;
                    case "2":
                        ListarContas();
                        break;
                    case "3":
                        Depositar();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Transferir();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine("Opção inexistente");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }                        
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-------- Escolha uma opção --------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Cadastrar ---------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("2 - Listar Contas -----------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("3 - Depositar ---------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("4 - Sacar -------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("5 - Transferir --------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("X - Sair --------------------------");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.Clear();
            return opcaoUsuario;
        }

        private static void InserirConta()
        {
            string nome;
            int tipoConta;
            double saldo, credito;

            Console.WriteLine("Escolha o tipo de conta:");
            Console.WriteLine("1 - Pessoa Fisica");
            Console.WriteLine("2 - Pessoa Juridica");

            tipoConta = Convert.ToInt32(Console.ReadLine());          

            Console.WriteLine();

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Saldo: R$ ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Crédito: R$ ");
            credito = Convert.ToDouble(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta)tipoConta, nome, saldo, credito);
            Console.Clear();

            contas.Add(novaConta);
        }

        private static void Depositar()
        {
            double valorDeposito;
            int conta;

            Console.Write("Digite o numero da conta: ");
            conta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Valor a ser depositado: R$ ");
            valorDeposito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            contas[conta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            double valorSaque;
            int conta;

            Console.Write("Digite o numero da conta: ");
            conta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Valor a ser sacado: R$ ");
            valorSaque = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            contas[conta].Sacar(valorSaque);
        }

        private static void Transferir()
        {
            double valorTransferencia;
            int contaOrigem, contaDestino;

            Console.Write("Digite o numero da conta de origem: ");
            contaOrigem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite o numero da conta de destino: ");
            contaDestino = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Valor a ser transferido: R$ ");
            valorTransferencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            contas[contaOrigem].Transferir(contas[contaDestino], valorTransferencia);
        }

        private static void ListarContas()
        {
            if (contas.Count == 0) Console.WriteLine("Nenhuma conta cadastrada");
            else
            {
                for (int i = 0; i < contas.Count; i++)
                {
                    Conta conta = contas[i];
                    Console.WriteLine("N° conta: {0} - {1}", i, conta);
                }

            }            
        }
    }
}
