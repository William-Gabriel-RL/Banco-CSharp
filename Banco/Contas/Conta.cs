using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        private static int numeroDeContas = 0;
        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public int Numero { get; internal set; }
        public double Saldo { get; protected set; }

        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

        public Conta(Cliente titular)
        {
            Titular = titular;
        }

        public abstract void Deposita(double valor);

        public abstract void Saca(double valor);

        public void Transfere(double valor, Conta destino)
        {
            this.Saldo -= valor;
            destino.Saldo += valor;
        }

        public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }
    }
}