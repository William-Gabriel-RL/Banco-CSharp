using System;
using Banco.Contas;

namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valor;
        }
        public override void Saca(double Valor)
        {
            if (this.Saldo < Valor)
            {
                throw new SaldoInsuficienteException();
            }
            this.Saldo -= Valor + 0.10;
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
