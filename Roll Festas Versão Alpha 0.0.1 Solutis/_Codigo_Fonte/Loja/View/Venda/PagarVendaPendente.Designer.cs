namespace Loja.View.Venda
{
    partial class PagarVendaPendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagarVendaPendente));
            this.TxtDinCart = new System.Windows.Forms.TextBox();
            this.RbDinCart = new System.Windows.Forms.RadioButton();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LBITEM = new System.Windows.Forms.ListBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LvPesquisa = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblDinCart = new System.Windows.Forms.Label();
            this.BtnDuvida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDinCart
            // 
            this.TxtDinCart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtDinCart.Location = new System.Drawing.Point(603, 299);
            this.TxtDinCart.Name = "TxtDinCart";
            this.TxtDinCart.ReadOnly = true;
            this.TxtDinCart.Size = new System.Drawing.Size(72, 20);
            this.TxtDinCart.TabIndex = 75;
            // 
            // RbDinCart
            // 
            this.RbDinCart.AutoSize = true;
            this.RbDinCart.Location = new System.Drawing.Point(493, 300);
            this.RbDinCart.Name = "RbDinCart";
            this.RbDinCart.Size = new System.Drawing.Size(107, 17);
            this.RbDinCart.TabIndex = 74;
            this.RbDinCart.Text = "Dinheiro e Cartão";
            this.RbDinCart.UseVisualStyleBackColor = true;
            this.RbDinCart.CheckedChanged += new System.EventHandler(this.RbDinCart_CheckedChanged_1);
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnFinalizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFinalizar.Location = new System.Drawing.Point(546, 392);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(115, 29);
            this.BtnFinalizar.TabIndex = 72;
            this.BtnFinalizar.Text = "Finalizar (PAGO)";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPesquisar.Location = new System.Drawing.Point(354, 35);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(90, 31);
            this.BtnPesquisar.TabIndex = 71;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.Red;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.Info;
            this.BtnLimpar.Location = new System.Drawing.Point(37, 386);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(101, 35);
            this.BtnLimpar.TabIndex = 70;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsuario.Location = new System.Drawing.Point(577, 19);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(57, 17);
            this.LblUsuario.TabIndex = 69;
            this.LblUsuario.Text = "Usuário";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdicionar.Location = new System.Drawing.Point(37, 59);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(81, 32);
            this.BtnAdicionar.TabIndex = 68;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LBITEM
            // 
            this.LBITEM.FormattingEnabled = true;
            this.LBITEM.Location = new System.Drawing.Point(13, 105);
            this.LBITEM.Name = "LBITEM";
            this.LBITEM.Size = new System.Drawing.Size(156, 264);
            this.LBITEM.TabIndex = 66;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCalcular.Location = new System.Drawing.Point(636, 161);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(79, 33);
            this.BtnCalcular.TabIndex = 65;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblTestedata
            // 
            this.LblTestedata.AutoSize = true;
            this.LblTestedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestedata.Location = new System.Drawing.Point(577, 42);
            this.LblTestedata.Name = "LblTestedata";
            this.LblTestedata.Size = new System.Drawing.Size(33, 15);
            this.LblTestedata.TabIndex = 64;
            this.LblTestedata.Text = "Data";
            // 
            // RBOutros
            // 
            this.RBOutros.AutoSize = true;
            this.RBOutros.Location = new System.Drawing.Point(625, 277);
            this.RBOutros.Name = "RBOutros";
            this.RBOutros.Size = new System.Drawing.Size(56, 17);
            this.RBOutros.TabIndex = 63;
            this.RBOutros.Text = "Outros";
            this.RBOutros.UseVisualStyleBackColor = true;
            this.RBOutros.CheckedChanged += new System.EventHandler(this.RBOutros_CheckedChanged_1);
            // 
            // RBCartao
            // 
            this.RBCartao.AutoSize = true;
            this.RBCartao.Location = new System.Drawing.Point(563, 277);
            this.RBCartao.Name = "RBCartao";
            this.RBCartao.Size = new System.Drawing.Size(56, 17);
            this.RBCartao.TabIndex = 62;
            this.RBCartao.Text = "Cartão";
            this.RBCartao.UseVisualStyleBackColor = true;
            this.RBCartao.CheckedChanged += new System.EventHandler(this.RBCartao_CheckedChanged_1);
            // 
            // RBDinheiro
            // 
            this.RBDinheiro.AutoSize = true;
            this.RBDinheiro.Checked = true;
            this.RBDinheiro.Location = new System.Drawing.Point(493, 277);
            this.RBDinheiro.Name = "RBDinheiro";
            this.RBDinheiro.Size = new System.Drawing.Size(64, 17);
            this.RBDinheiro.TabIndex = 61;
            this.RBDinheiro.TabStop = true;
            this.RBDinheiro.Text = "Dinheiro";
            this.RBDinheiro.UseVisualStyleBackColor = true;
            this.RBDinheiro.CheckedChanged += new System.EventHandler(this.RBDinheiro_CheckedChanged_1);
            // 
            // TxtTroco
            // 
            this.TxtTroco.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTroco.Location = new System.Drawing.Point(546, 203);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(83, 20);
            this.TxtTroco.TabIndex = 60;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(546, 168);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(83, 20);
            this.TxtValor.TabIndex = 59;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtTotal.Location = new System.Drawing.Point(546, 131);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(83, 20);
            this.TxtTotal.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tipo de pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Valor recebido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Pesquisar vendas pendentes:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(101, 16);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(68, 20);
            this.TxtId.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Código da venda:";
            // 
            // LvPesquisa
            // 
            this.LvPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.LvPesquisa.HideSelection = false;
            this.LvPesquisa.Location = new System.Drawing.Point(198, 72);
            this.LvPesquisa.Name = "LvPesquisa";
            this.LvPesquisa.Size = new System.Drawing.Size(264, 349);
            this.LvPesquisa.TabIndex = 76;
            this.LvPesquisa.UseCompatibleStateImageBehavior = false;
            this.LvPesquisa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Valor pendente:";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data:";
            this.columnHeader3.Width = 100;
            // 
            // LblDinCart
            // 
            this.LblDinCart.BackColor = System.Drawing.Color.Orange;
            this.LblDinCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDinCart.ForeColor = System.Drawing.Color.Red;
            this.LblDinCart.Location = new System.Drawing.Point(526, 338);
            this.LblDinCart.Name = "LblDinCart";
            this.LblDinCart.Size = new System.Drawing.Size(155, 41);
            this.LblDinCart.TabIndex = 77;
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
            this.BtnDuvida.Location = new System.Drawing.Point(683, 8);
            this.BtnDuvida.Name = "BtnDuvida";
            this.BtnDuvida.Size = new System.Drawing.Size(35, 35);
            this.BtnDuvida.TabIndex = 78;
            this.BtnDuvida.Text = "?";
            this.BtnDuvida.UseVisualStyleBackColor = false;
            this.BtnDuvida.Click += new System.EventHandler(this.BtnDuvida_Click);
            // 
            // PagarVendaPendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.BtnDuvida);
            this.Controls.Add(this.LblDinCart);
            this.Controls.Add(this.LvPesquisa);
            this.Controls.Add(this.TxtDinCart);
            this.Controls.Add(this.RbDinCart);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.LBITEM);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblTestedata);
            this.Controls.Add(this.RBOutros);
            this.Controls.Add(this.RBCartao);
            this.Controls.Add(this.RBDinheiro);
            this.Controls.Add(this.TxtTroco);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PagarVendaPendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PagarVendaPendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtDinCart;
        private System.Windows.Forms.RadioButton RbDinCart;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.ListBox LBITEM;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LvPesquisa;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label LblDinCart;
        private System.Windows.Forms.Button BtnDuvida;
    }
}