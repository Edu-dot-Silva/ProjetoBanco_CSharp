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
    }
}
