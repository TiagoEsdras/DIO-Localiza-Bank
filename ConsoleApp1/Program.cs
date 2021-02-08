using System;

namespace ConsoleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
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
    }
}
