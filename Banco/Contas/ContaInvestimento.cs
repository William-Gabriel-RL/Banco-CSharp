using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Banco.Contas;

namespace Banco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            throw new NotImplementedException();
        }

        public override void Saca(double valor)
        {
            throw new NotImplementedException();
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
