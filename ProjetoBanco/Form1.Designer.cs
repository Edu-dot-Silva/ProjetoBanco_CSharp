namespace ProjetoBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_agencia = new System.Windows.Forms.Label();
            this.txt_agencia = new System.Windows.Forms.TextBox();
            this.txt_nconta = new System.Windows.Forms.TextBox();
            this.lbl_nconta = new System.Windows.Forms.Label();
            this.lbl_tituloConta = new System.Windows.Forms.Label();
            this.txt_tituloConta = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.btn_saque = new System.Windows.Forms.Button();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Location = new System.Drawing.Point(94, 97);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(46, 13);
            this.lbl_agencia.TabIndex = 0;
            this.lbl_agencia.Text = "Agência";
            this.lbl_agencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(67, 123);
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(100, 20);
            this.txt_agencia.TabIndex = 1;
            // 
            // txt_nconta
            // 
            this.txt_nconta.Location = new System.Drawing.Point(239, 123);
            this.txt_nconta.Name = "txt_nconta";
            this.txt_nconta.Size = new System.Drawing.Size(100, 20);
            this.txt_nconta.TabIndex = 2;
            // 
            // lbl_nconta
            // 
            this.lbl_nconta.AutoSize = true;
            this.lbl_nconta.Location = new System.Drawing.Point(263, 97);
            this.lbl_nconta.Name = "lbl_nconta";
            this.lbl_nconta.Size = new System.Drawing.Size(65, 13);
            this.lbl_nconta.TabIndex = 3;
            this.lbl_nconta.Text = "N° da Conta";
            // 
            // lbl_tituloConta
            // 
            this.lbl_tituloConta.AutoSize = true;
            this.lbl_tituloConta.Location = new System.Drawing.Point(466, 97);
            this.lbl_tituloConta.Name = "lbl_tituloConta";
            this.lbl_tituloConta.Size = new System.Drawing.Size(79, 13);
            this.lbl_tituloConta.TabIndex = 4;
            this.lbl_tituloConta.Text = "Titulo da Conta";
            // 
            // txt_tituloConta
            // 
            this.txt_tituloConta.Location = new System.Drawing.Point(459, 123);
            this.txt_tituloConta.Name = "txt_tituloConta";
            this.txt_tituloConta.Size = new System.Drawing.Size(100, 20);
            this.txt_tituloConta.TabIndex = 5;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(645, 97);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(648, 123);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 7;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(824, 97);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(89, 13);
            this.lbl_saldo.TabIndex = 8;
            this.lbl_saldo.Text = "Saldo Disponivel:";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(813, 123);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo.TabIndex = 9;
            // 
            // btn_saque
            // 
            this.btn_saque.Location = new System.Drawing.Point(91, 280);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(75, 23);
            this.btn_saque.TabIndex = 10;
            this.btn_saque.Text = "Saque";
            this.btn_saque.UseVisualStyleBackColor = true;
            // 
            // btn_deposito
            // 
            this.btn_deposito.Location = new System.Drawing.Point(223, 280);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(75, 23);
            this.btn_deposito.TabIndex = 11;
            this.btn_deposito.Text = "Depósito";
            this.btn_deposito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 634);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_tituloConta);
            this.Controls.Add(this.lbl_tituloConta);
            this.Controls.Add(this.lbl_nconta);
            this.Controls.Add(this.txt_nconta);
            this.Controls.Add(this.txt_agencia);
            this.Controls.Add(this.lbl_agencia);
            this.Name = "Form1";
            this.Text = "Internet Banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_agencia;
        private System.Windows.Forms.TextBox txt_agencia;
        private System.Windows.Forms.TextBox txt_nconta;
        private System.Windows.Forms.Label lbl_nconta;
        private System.Windows.Forms.Label lbl_tituloConta;
        private System.Windows.Forms.TextBox txt_tituloConta;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button btn_saque;
        private System.Windows.Forms.Button btn_deposito;
    }
}

