namespace Loja.View.Encomenda
{
    partial class NovaEncomenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaEncomenda));
            this.TxtDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtTema = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.LblDinCart = new System.Windows.Forms.Label();
            this.TxtDinCart = new System.Windows.Forms.TextBox();
            this.RbDinCart = new System.Windows.Forms.RadioButton();
            this.RBOutros = new System.Windows.Forms.RadioButton();
            this.RBCartao = new System.Windows.Forms.RadioButton();
            this.RBDinheiro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblTestedata = new System.Windows.Forms.Label();
            this.TxtValorpago = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnPagarDepos = new System.Windows.Forms.Button();
            this.TxtValorPendente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtDataEntrega
            // 
            this.TxtDataEntrega.Location = new System.Drawing.Point(133, 126);
            this.TxtDataEntrega.Mask = "00/00/0000";
            this.TxtDataEntrega.Name = "TxtDataEntrega";
            this.TxtDataEntrega.Size = new System.Drawing.Size(142, 20);
            this.TxtDataEntrega.TabIndex = 30;
            this.TxtDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(202, 609);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(84, 29);
            this.BtnSalvar.TabIndex = 29;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(133, 231);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(142, 69);
            this.txtDescricao.TabIndex = 28;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(133, 179);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(142, 20);
            this.TxtValor.TabIndex = 27;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(133, 153);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(142, 20);
            this.TxtQuantidade.TabIndex = 26;
            // 
            // TxtTema
            // 
            this.TxtTema.Location = new System.Drawing.Point(133, 205);
            this.TxtTema.Name = "TxtTema";
            this.TxtTema.Size = new System.Drawing.Size(142, 20);
            this.TxtTema.TabIndex = 25;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(133, 74);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(142, 20);
            this.TxtTipo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "*Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "*Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "*Data de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "*Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adicionar nova encomenda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "*Data de entrega:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Tema:";
            // 
            // TxtDataEntrada
            // 
            this.TxtDataEntrada.Location = new System.Drawing.Point(133, 100);
            this.TxtDataEntrada.Mask = "00/00/0000";
            this.TxtDataEntrada.Name = "TxtDataEntrada";
            this.TxtDataEntrada.Size = new System.Drawing.Size(142, 20);
            this.TxtDataEntrada.TabIndex = 34;
            this.TxtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // LblDinCart
            // 
            this.LblDinCart.BackColor = System.Drawing.Color.Orange;
            this.LblDinCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDinCart.ForeColor = System.Drawing.Color.Red;
            this.LblDinCart.Location = new System.Drawing.Point(108, 419);
            this.LblDinCart.Name = "LblDinCart";
            this.LblDinCart.Size = new System.Drawing.Size(169, 43);
            this.LblDinCart.TabIndex = 54;
            this.LblDinCart.Text = "Informe o valor pago em cartão no campo acima!";
            this.LblDinCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDinCart.Visible = false;
            // 
            // TxtDinCart
            // 
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtDinCart.Location = new System.Drawing.Point(216, 396);
            this.TxtDinCart.Name = "TxtDinCart";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Size = new System.Drawing.Size(72, 20);
            this.TxtDinCart.TabIndex = 53;
            // 
            // RbDinCart
            // 
            this.RbDinCart.AutoSize = true;
            this.RbDinCart.Location = new System.Drawing.Point(106, 397);
            this.RbDinCart.Name = "RbDinCart";
            this.RbDinCart.Size = new System.Drawing.Size(107, 17);
            this.RbDinCart.TabIndex = 52;
            this.RbDinCart.Text = "Dinheiro e Cartão";
            this.RbDinCart.UseVisualStyleBackColor = true;
            this.RbDinCart.CheckedChanged += new System.EventHandler(this.RbDinCart_CheckedChanged);
            // 
            // RBOutros
            // 
            this.RBOutros.AutoSize = true;
            this.RBOutros.Location = new System.Drawing.Point(238, 374);
            this.RBOutros.Name = "RBOutros";
            this.RBOutros.Size = new System.Drawing.Size(56, 17);
            this.RBOutros.TabIndex = 51;
            this.RBOutros.Text = "Outros";
            this.RBOutros.UseVisualStyleBackColor = true;
            this.RBOutros.CheckedChanged += new System.EventHandler(this.RBOutros_CheckedChanged);
            // 
            // RBCartao
            // 
            this.RBCartao.AutoSize = true;
            this.RBCartao.Location = new System.Drawing.Point(176, 374);
            this.RBCartao.Name = "RBCartao";
            this.RBCartao.Size = new System.Drawing.Size(56, 17);
            this.RBCartao.TabIndex = 50;
            this.RBCartao.Text = "Cartão";
            this.RBCartao.UseVisualStyleBackColor = true;
            this.RBCartao.CheckedChanged += new System.EventHandler(this.RBCartao_CheckedChanged);
            // 
            // RBDinheiro
            // 
            this.RBDinheiro.AutoSize = true;
            this.RBDinheiro.Checked = true;
            this.RBDinheiro.Location = new System.Drawing.Point(106, 374);
            this.RBDinheiro.Name = "RBDinheiro";
            this.RBDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RBDinheiro.TabIndex = 49;
            this.RBDinheiro.TabStop = true;
            this.RBDinheiro.Text = "Dinheiro";
            this.RBDinheiro.UseVisualStyleBackColor = true;
            this.RBDinheiro.CheckedChanged += new System.EventHandler(this.RBDinheiro_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo de pagamento";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcular.Location = new System.Drawing.Point(133, 528);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(118, 33);
            this.BtnCalcular.TabIndex = 62;
            this.BtnCalcular.Text = "Calcular troco";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtTroco
            // 
            this.TxtTroco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTroco.Location = new System.Drawing.Point(176, 502);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(73, 20);
            this.TxtTroco.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Troco:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(238, 21);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 63;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(238, 47);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 61;
            this.LblTestedata.Text = "Data";
            // 
            // TxtValorpago
            // 
            this.TxtValorpago.Location = new System.Drawing.Point(176, 476);
            this.TxtValorpago.Name = "TxtValorpago";
            this.TxtValorpago.Size = new System.Drawing.Size(73, 20);
            this.TxtValorpago.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(92, 479);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Valor recebido:";
            // 
            // BtnPagarDepos
            // 
            this.BtnPagarDepos.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnPagarDepos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPagarDepos.Location = new System.Drawing.Point(17, 609);
            this.BtnPagarDepos.Name = "BtnPagarDepos";
            this.BtnPagarDepos.Size = new System.Drawing.Size(151, 29);
            this.BtnPagarDepos.TabIndex = 64;
            this.BtnPagarDepos.Text = "Finalizar (PAGAR DEPOIS)";
            this.BtnPagarDepos.UseVisualStyleBackColor = false;
            this.BtnPagarDepos.Click += new System.EventHandler(this.BtnPagarDepos_Click);
            // 
            // TxtValorPendente
            // 
            this.TxtValorPendente.Location = new System.Drawing.Point(191, 567);
            this.TxtValorPendente.Name = "TxtValorPendente";
            this.TxtValorPendente.Size = new System.Drawing.Size(73, 20);
            this.TxtValorPendente.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Valor pendente:";
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(315, 12);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 67;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Nome cliente:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(133, 306);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(142, 20);
            this.TxtNome.TabIndex = 68;
            // 
            // NovaEncomenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 660);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.TxtValorPendente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnPagarDepos);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.TxtValorpago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblDinCart);
            this.Controls.Add(this.TxtDinCart);
            this.Controls.Add(this.RbDinCart);
            this.Controls.Add(this.RBOutros);
            this.Controls.Add(this.RBCartao);
            this.Controls.Add(this.RBDinheiro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDataEntrada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtDataEntrega);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtTema);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaEncomenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaEncomenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox TxtDataEntrega;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtTema;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TxtDataEntrada;
        private System.Windows.Forms.Label LblDinCart;
        private System.Windows.Forms.TextBox TxtDinCart;
        private System.Windows.Forms.RadioButton RbDinCart;
        private System.Windows.Forms.RadioButton RBOutros;
        private System.Windows.Forms.RadioButton RBCartao;
        private System.Windows.Forms.RadioButton RBDinheiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblTestedata;
        private System.Windows.Forms.TextBox TxtValorpago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnPagarDepos;
        private System.Windows.Forms.TextBox TxtValorPendente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnDuvida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtNome;
    }
}