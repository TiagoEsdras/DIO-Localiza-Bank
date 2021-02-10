using System;
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
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "X":
                        break;
                    default:
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }                        
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-------- Escolha uma opção --------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1 - Cadastrar ---------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("2 - Depositar ---------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("3 - Sacar -------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("4 - Transferir --------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("X - Sair --------------------------");
            Console.WriteLine("-----------------------------------");

            string opcaoUsuario = Console.ReadLine().ToUpper();
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

            contas.Add(novaConta);
        }
    }
}
