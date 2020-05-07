using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaOOGabrielBertti
{
    class Conta_Comum: Conta
    {
        

        public override void Sacar(double valor)
        {
            if (this.Conta_Saldo < valor)
                throw new System.ArgumentException("Saldo indisponivel");
            else { this.Conta_Saldo -= valor; }
            
        }

      
    }
}
