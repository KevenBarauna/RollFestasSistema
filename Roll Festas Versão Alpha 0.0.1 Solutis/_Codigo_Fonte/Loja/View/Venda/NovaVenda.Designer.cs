namespace Loja.View.Venda
{
    partial class NovaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaVenda));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LVPesquisa = new System.Windows.Forms.ListView();
            this.CID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPRECO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblTestedata = new System.Windows.Forms.Label();
            this.RBOutros = new System.Windows.Forms.RadioButton();
            this.RBCartao = new System.Windows.Forms.RadioButton();
            this.RBDinheiro = new System.Windows.Forms.RadioButton();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBITEM = new System.Windows.Forms.ListBox();
            this.TxtNumQuant = new System.Windows.Forms.NumericUpDown();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPagarDepos = new System.Windows.Forms.Button();
            this.RbDinCart = new System.Windows.Forms.RadioButton();
            this.TxtDinCart = new System.Windows.Forms.TextBox();
            this.LblDinCart = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do produto:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(110, 10);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(62, 20);
            this.TxtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // LVPesquisa
            // 
            this.LVPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CID,
            this.CNOME,
            this.CPRECO});
            this.LVPesquisa.HideSelection = false;
            this.LVPesquisa.Location = new System.Drawing.Point(220, 111);
            this.LVPesquisa.Name = "LVPesquisa";
            this.LVPesquisa.Size = new System.Drawing.Size(241, 252);
            this.LVPesquisa.TabIndex = 4;
            this.LVPesquisa.UseCompatibleStateImageBehavior = false;
            this.LVPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // CID
            // 
            this.CID.Text = "Código";
            this.CID.Width = 55;
            // 
            // CNOME
            // 
            this.CNOME.Text = "Nome";
            this.CNOME.Width = 110;
            // 
            // CPRECO
            // 
            this.CPRECO.Text = "Preço";
            this.CPRECO.Width = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesquisar produto por nome:";
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(259, 35);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(175, 20);
            this.TxtPesquisa.TabIndex = 6;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Turquoise;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcular.Location = new System.Drawing.Point(559, 168);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(84, 33);
            this.BtnCalcular.TabIndex = 36;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(543, 42);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 35;
            this.LblTestedata.Text = "Data";
            // 
            // RBOutros
            // 
            this.RBOutros.AutoSize = true;
            this.RBOutros.Location = new System.Drawing.Point(627, 282);
            this.RBOutros.Name = "RBOutros";
            this.RBOutros.Size = new System.Drawing.Size(56, 17);
            this.RBOutros.TabIndex = 34;
            this.RBOutros.Text = "Outros";
            this.RBOutros.UseVisualStyleBackColor = true;
            this.RBOutros.CheckedChanged += new System.EventHandler(this.RBOutros_CheckedChanged);
            // 
            // RBCartao
            // 
            this.RBCartao.AutoSize = true;
            this.RBCartao.Location = new System.Drawing.Point(565, 282);
            this.RBCartao.Name = "RBCartao";
            this.RBCartao.Size = new System.Drawing.Size(56, 17);
            this.RBCartao.TabIndex = 33;
            this.RBCartao.Text = "Cartão";
            this.RBCartao.UseVisualStyleBackColor = true;
            this.RBCartao.CheckedChanged += new System.EventHandler(this.RBCartao_CheckedChanged);
            // 
            // RBDinheiro
            // 
            this.RBDinheiro.AutoSize = true;
            this.RBDinheiro.Checked = true;
            this.RBDinheiro.Location = new System.Drawing.Point(495, 282);
            this.RBDinheiro.Name = "RBDinheiro";
            this.RBDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RBDinheiro.TabIndex = 31;
            this.RBDinheiro.TabStop = true;
            this.RBDinheiro.Text = "Dinheiro";
            this.RBDinheiro.UseVisualStyleBackColor = true;
            this.RBDinheiro.CheckedChanged += new System.EventHandler(this.RBDinheiro_CheckedChanged);
            // 
            // TxtTroco
            // 
            this.TxtTroco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTroco.Location = new System.Drawing.Point(559, 219);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(84, 20);
            this.TxtTroco.TabIndex = 30;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(559, 134);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(84, 20);
            this.TxtValor.TabIndex = 29;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTotal.Location = new System.Drawing.Point(559, 100);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(84, 20);
            this.TxtTotal.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tipo de pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Valor recebido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Total:";
            // 
            // LBITEM
            // 
            this.LBITEM.FormattingEnabled = true;
            this.LBITEM.Location = new System.Drawing.Point(16, 111);
            this.LBITEM.Name = "LBITEM";
            this.LBITEM.Size = new System.Drawing.Size(156, 251);
            this.LBITEM.TabIndex = 37;
            // 
            // TxtNumQuant
            // 
            this.TxtNumQuant.Location = new System.Drawing.Point(84, 36);
            this.TxtNumQuant.Name = "TxtNumQuant";
            this.TxtNumQuant.Size = new System.Drawing.Size(88, 20);
            this.TxtNumQuant.TabIndex = 38;
            this.TxtNumQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdicionar.Location = new System.Drawing.Point(51, 73);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(81, 32);
            this.BtnAdicionar.TabIndex = 39;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(543, 19);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 40;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(144, 392);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(101, 35);
            this.BtnLimpar.TabIndex = 41;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnCalcularValorItem_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(298, 73);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(81, 32);
            this.BtnPesquisar.TabIndex = 42;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(416, 392);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(115, 35);
            this.BtnFinalizar.TabIndex = 43;
            this.BtnFinalizar.Text = "Finalizar (PAGO)";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPagarDepos
            // 
            this.BtnPagarDepos.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnPagarDepos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPagarDepos.Location = new System.Drawing.Point(253, 392);
            this.BtnPagarDepos.Name = "BtnPagarDepos";
            this.BtnPagarDepos.Size = new System.Drawing.Size(151, 35);
            this.BtnPagarDepos.TabIndex = 44;
            this.BtnPagarDepos.Text = "Finalizar (PAGAR DEPOIS)";
            this.BtnPagarDepos.UseVisualStyleBackColor = false;
            this.BtnPagarDepos.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbDinCart
            // 
            this.RbDinCart.AutoSize = true;
            this.RbDinCart.Location = new System.Drawing.Point(495, 305);
            this.RbDinCart.Name = "RbDinCart";
            this.RbDinCart.Size = new System.Drawing.Size(107, 17);
            this.RbDinCart.TabIndex = 45;
            this.RbDinCart.Text = "Dinheiro e Cartão";
            this.RbDinCart.UseVisualStyleBackColor = true;
            this.RbDinCart.CheckedChanged += new System.EventHandler(this.RbDinCart_CheckedChanged);
            // 
            // TxtDinCart
            // 
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtDinCart.Location = new System.Drawing.Point(605, 304);
            this.TxtDinCart.Name = "TxtDinCart";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Size = new System.Drawing.Size(72, 20);
            this.TxtDinCart.TabIndex = 46;
            // 
            // LblDinCart
            // 
            this.LblDinCart.BackColor = System.Drawing.Color.Orange;
            this.LblDinCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDinCart.ForeColor = System.Drawing.Color.Red;
            this.LblDinCart.Location = new System.Drawing.Point(479, 327);
            this.LblDinCart.Name = "LblDinCart";
            this.LblDinCart.Size = new System.Drawing.Size(207, 38);
            this.LblDinCart.TabIndex = 47;
            this.LblDinCart.Text = "Informe o valor pago em cartão no campo acima!";
            this.LblDinCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDinCart.Visible = false;
            // 
            // BtnDuvida
            // 
            this.BtnDuvida.BackColor = System.Drawing.Color.Orange;
            this.BtnDuvida.Cursor = System.Windows.Forms.Cursors.Help;
            this.BtnDuvida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnDuvida.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDuvida.Location = new System.Drawing.Point(657, 4);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 48;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // NovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNumQuant);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPagarDepos);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.LblDinCart);
            this.Controls.Add(this.TxtDinCart);
            this.Controls.Add(this.RbDinCart);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LBITEM);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.RBOutros);
            this.Controls.Add(this.RBCartao);
            this.Controls.Add(this.RBDinheiro);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LVPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Venda";
            ((System.ComponentModel.ISupportInitialize)(this.TxtNumQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LVPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblTestedata;
        private System.Windows.Forms.RadioButton RBOutros;
        private System.Windows.Forms.RadioButton RBCartao;
        private System.Windows.Forms.RadioButton RBDinheiro;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LBITEM;
        private System.Windows.Forms.NumericUpDown TxtNumQuant;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.ColumnHeader CID;
        private System.Windows.Forms.ColumnHeader CNOME;
        private System.Windows.Forms.ColumnHeader CPRECO;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPagarDepos;
        private System.Windows.Forms.RadioButton RbDinCart;
        private System.Windows.Forms.TextBox TxtDinCart;
        private System.Windows.Forms.Label LblDinCart;
        private System.Windows.Forms.Button BtnDuvida;
    }
}