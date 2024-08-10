namespace ProjetoBanco
{
    partial class frm_banco
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.btn_saque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_agencia
            // 
            this.lbl_agencia.AutoSize = true;
            this.lbl_agencia.Location = new System.Drawing.Point(450, 275);
            this.lbl_agencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_agencia.Name = "lbl_agencia";
            this.lbl_agencia.Size = new System.Drawing.Size(55, 15);
            this.lbl_agencia.TabIndex = 0;
            this.lbl_agencia.Text = "Agência";
            this.lbl_agencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_agencia
            // 
            this.txt_agencia.Location = new System.Drawing.Point(453, 294);
            this.txt_agencia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_agencia.MaxLength = 4;
            this.txt_agencia.Name = "txt_agencia";
            this.txt_agencia.Size = new System.Drawing.Size(202, 22);
            this.txt_agencia.TabIndex = 1;
            this.txt_agencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nconta
            // 
            this.txt_nconta.Location = new System.Drawing.Point(453, 475);
            this.txt_nconta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nconta.MaxLength = 5;
            this.txt_nconta.Name = "txt_nconta";
            this.txt_nconta.Size = new System.Drawing.Size(202, 22);
            this.txt_nconta.TabIndex = 2;
            this.txt_nconta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nconta
            // 
            this.lbl_nconta.AutoSize = true;
            this.lbl_nconta.Location = new System.Drawing.Point(450, 456);
            this.lbl_nconta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nconta.Name = "lbl_nconta";
            this.lbl_nconta.Size = new System.Drawing.Size(77, 15);
            this.lbl_nconta.TabIndex = 3;
            this.lbl_nconta.Text = "N° da Conta";
            // 
            // lbl_tituloConta
            // 
            this.lbl_tituloConta.AutoSize = true;
            this.lbl_tituloConta.Location = new System.Drawing.Point(450, 365);
            this.lbl_tituloConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloConta.Name = "lbl_tituloConta";
            this.lbl_tituloConta.Size = new System.Drawing.Size(96, 15);
            this.lbl_tituloConta.TabIndex = 4;
            this.lbl_tituloConta.Text = "Titulo da Conta";
            this.lbl_tituloConta.Click += new System.EventHandler(this.lbl_tituloConta_Click);
            // 
            // txt_tituloConta
            // 
            this.txt_tituloConta.Location = new System.Drawing.Point(453, 384);
            this.txt_tituloConta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tituloConta.MaxLength = 30;
            this.txt_tituloConta.Name = "txt_tituloConta";
            this.txt_tituloConta.Size = new System.Drawing.Size(202, 22);
            this.txt_tituloConta.TabIndex = 5;
            this.txt_tituloConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(538, 551);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(39, 15);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(495, 586);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(119, 22);
            this.txt_valor.TabIndex = 7;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(879, 663);
            this.lbl_saldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(150, 22);
            this.lbl_saldo.TabIndex = 8;
            this.lbl_saldo.Text = "Saldo Disponivel:";
            // 
            // txt_saldo
            // 
            this.txt_saldo.BackColor = System.Drawing.Color.Black;
            this.txt_saldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_saldo.Enabled = false;
            this.txt_saldo.Font = new System.Drawing.Font("Eras Medium ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldo.ForeColor = System.Drawing.Color.White;
            this.txt_saldo.Location = new System.Drawing.Point(770, 689);
            this.txt_saldo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(259, 43);
            this.txt_saldo.TabIndex = 9;
            this.txt_saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_saldo.TextChanged += new System.EventHandler(this.txt_saldo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "SENAC BANK";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Image = global::ProjetoBanco.Properties.Resources.sair__2_;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.Location = new System.Drawing.Point(992, 770);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Padding = new System.Windows.Forms.Padding(3);
            this.btn_sair.Size = new System.Drawing.Size(86, 57);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Image = global::ProjetoBanco.Properties.Resources.banco;
            this.logo.Location = new System.Drawing.Point(502, 73);
            this.logo.MinimumSize = new System.Drawing.Size(100, 100);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.TabIndex = 12;
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_deposito
            // 
            this.btn_deposito.BackColor = System.Drawing.Color.Green;
            this.btn_deposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deposito.Image = global::ProjetoBanco.Properties.Resources.deposito1;
            this.btn_deposito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deposito.Location = new System.Drawing.Point(571, 663);
            this.btn_deposito.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Padding = new System.Windows.Forms.Padding(3);
            this.btn_deposito.Size = new System.Drawing.Size(124, 51);
            this.btn_deposito.TabIndex = 11;
            this.btn_deposito.Text = "Depósito";
            this.btn_deposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deposito.UseVisualStyleBackColor = false;
            // 
            // btn_saque
            // 
            this.btn_saque.BackColor = System.Drawing.Color.Crimson;
            this.btn_saque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saque.ForeColor = System.Drawing.Color.White;
            this.btn_saque.Image = global::ProjetoBanco.Properties.Resources.saque1;
            this.btn_saque.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_saque.Location = new System.Drawing.Point(403, 663);
            this.btn_saque.Margin = new System.Windows.Forms.Padding(4);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Padding = new System.Windows.Forms.Padding(3);
            this.btn_saque.Size = new System.Drawing.Size(124, 51);
            this.btn_saque.TabIndex = 10;
            this.btn_saque.Text = "Saque";
            this.btn_saque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_saque.UseVisualStyleBackColor = false;
            // 
            // frm_banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1090, 839);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_banco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Banking";
            this.Load += new System.EventHandler(this.formulario_banco_Load);
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
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sair;
    }
}

