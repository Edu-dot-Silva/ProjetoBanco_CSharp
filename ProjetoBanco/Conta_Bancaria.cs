using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Conta_Bancaria
    {
        public int agencia, numero_conta;
        public string titular;
        public double valor,saldo=100;

        public void Sacar()
        {
            saldo = saldo - valor;
        }
        public void Depositar()
        {
            saldo = saldo + valor;
        }
    }
}
