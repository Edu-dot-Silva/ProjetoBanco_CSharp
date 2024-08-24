using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    internal class Conta_Bancaria
    {
        public int agencia, numero_conta;
        public string titular;
        public double valor,saldo=100;

        public void Sacar()
        {
            if (saldo >= valor) {
                saldo = saldo - valor;
                MessageBox.Show($"Saque de R${valor} foi efetivado com sucesso!", "Aviso");
                

            }
            else
            {
                DialogResult
                resultado = MessageBox.Show($"Saldo insuficiente! apenas {saldo}," + $"podera ser retirado,deseja continuar?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(resultado == DialogResult.Yes)
                {
                    saldo = 0;
                }
                else
                {
                    MessageBox.Show("Operação Cancelada.O saldo permanece inalterado", "Aviso");
                }
            }
        }
        public void Depositar()
        {
            saldo = saldo += valor;

            MessageBox.Show($"O deposito {valor} foi efetivado com sucesso!","Aviso");
        }
    }
}
