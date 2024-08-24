using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBanco
{
    public partial class frm_banco : Form
    {
        public frm_banco()
        {
            InitializeComponent();
        }

        Conta_Bancaria conta = new Conta_Bancaria();
        int quantidade_saques,quantidade_depositos;
        int idade, mes_nascimento;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tituloConta_Click(object sender, EventArgs e)
        {

        }

        private void formulario_banco_Load(object sender, EventArgs e)
        {
            txt_saldo.Text = conta.saldo.ToString("c2");

        }

        private void txt_saldo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            if(txt_agencia.TextLength == 4 && txt_nconta.TextLength == 5 && txt_tituloConta.TextLength >=3 && txt_valor.Text != "")
            {
                conta.agencia = int.Parse(txt_agencia.Text);
                conta.numero_conta = int.Parse(txt_nconta.Text);
                conta.titular = txt_tituloConta.Text;
                conta.valor = double.Parse(txt_valor.Text);

                if(conta.saldo >= conta.valor)
                {
                    conta.Sacar();
                    txt_saldo.Text = conta.saldo.ToString("c2");
                    txt_valor.Text = "";
                    quantidade_saques++;
                    qtd_saques.Text = quantidade_saques.ToString();
                }
                else
                {
                    MessageBox.Show("Voce não tem saldo suficiente","Aviso");
                }
            }
            else
            {
                MessageBox.Show("É preciso preencher os campos anteriores", "Aviso");
            }
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            conta.valor = double.Parse(txt_valor.Text);
            conta.Depositar();
            txt_saldo.Text = conta.saldo.ToString("c2");
            txt_valor.Text = "";
            quantidade_depositos++;
            qtd_depositos.Text = quantidade_depositos.ToString();
            
        }

    
        private void txt_agencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {
                if (txt_agencia.TextLength == 4)
                {
                    txt_nconta.Focus();
                }
                else
                {
                    MessageBox.Show("É necessario digitar os 5 numeros da agencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_tituloConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {
                if (txt_tituloConta.TextLength >= 3)
                {
                    txt_valor.Focus();
                }
                else
                {
                    MessageBox.Show("É necessario digitar so menor 3 letras para o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_nconta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {
                if (txt_nconta.TextLength == 5)
                {
                    txt_tituloConta.Focus();
                }
                else
                {
                    MessageBox.Show("É necessario difitar os 5 numeros da conta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (txt_valor.Text != "")
                {
                    MessageBox.Show("Ultilize os botoes de saque ou deposito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Informe um valor pra continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_agencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
