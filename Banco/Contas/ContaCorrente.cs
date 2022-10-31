using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return totalDeContas + 1;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            this.Saldo += valor;
        }
        public override void Saca(double valor)
        {
            if (this.Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            this.Saldo -= valor - 0.05;
        }
    }
}
