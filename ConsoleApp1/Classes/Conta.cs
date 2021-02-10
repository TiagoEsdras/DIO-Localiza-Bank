using System;
using System.Collections.Generic;

namespace ConsoleBank
{
    class Conta
    {
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if(this.Saldo + this.Credito < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("O valor disponível na conta de {0} é R$ {1}", this.Nome, this.Saldo.ToString("F2"));
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("O valor disponível na conta de {0} é R$ {1}", this.Nome, this.Saldo.ToString("F2"));
        }

        public void Transferir(Conta contaDestino, double valorTranferir)
        {
            if(this.Sacar(valorTranferir))
            {
                contaDestino.Depositar(valorTranferir);
            } 
        }

        public override string ToString()
        {
            string msg = "";
            msg += "Tipo de conta: " + this.TipoConta + " | ";
            msg += "Nome: " + this.Nome + " | ";
            msg += "Saldo: R$ " + this.Saldo.ToString("F2") + " | ";
            msg += "Crédito: R$ " + this.Credito.ToString("F2") + " | ";
            return msg;
        }
    }

}
