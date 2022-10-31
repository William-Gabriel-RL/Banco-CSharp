using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Adiciona(Conta conta)
        {
            SaldoTotal += conta.Saldo;
        }
    }
}
